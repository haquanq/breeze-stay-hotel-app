using HotelManagement.Domain.Dtos.RoomType;
using HotelManagement.Domain.Services.RoomType;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Enums;
using HotelManagement.WinformApp.Views.RoomType;
using System;

namespace HotelManagement.WinformApp.Presenters.RoomType
{
    public class RoomTypeUpdatePresenter
    {
        private readonly IRoomTypeUpdateView _roomTypeUdpateView;
        private readonly IRoomTypeService _roomTypeService;
        public RoomTypeUpdatePresenter(IRoomTypeUpdateView roomTypeUpdateView, IRoomTypeService roomTypeService)
        {
            /// injected
            _roomTypeUdpateView = roomTypeUpdateView;
            _roomTypeService = roomTypeService;

            /// events
            _roomTypeUdpateView.OnAmenityViewLoad += HandleViewLoadEvent;
            _roomTypeUdpateView.OnRoomTypeSave += HandleRoomTypeUpdateEvent;
            _roomTypeUdpateView.OnRoomTypeDelete += HandleRoomTypeDeleteEvent;
            _roomTypeUdpateView.OnCancel += HandleCancel;
        }

        /// <summary>
        /// Private method for handling RoomTypeUpdateView events
        /// </summary>
        private void HandleViewLoadEvent(object s, EventArgs e)
        {
            /// ..... ?
        }

        private void HandleRoomTypeUpdateEvent(object s, EventArgs e)
        {
            UpdateRoomType();
        }

        private void HandleRoomTypeDeleteEvent(object s, EventArgs e)
        {
            DeleteRoomType();
        }

        private void HandleCancel(object s, EventArgs e)
        {
            _roomTypeUdpateView.Close();
        }

        /// <summary>
        /// Public method for handling RoomTypeUpdateView logic
        /// </summary>
        public void ShowView(string roomTypeId)
        {
            LoadSelectedRoomType(roomTypeId);
            _roomTypeUdpateView.Show();
        }

        public async void LoadSelectedRoomType(string roomTypeId)
        {
            var roomType = await _roomTypeService.FindByIdAsync(roomTypeId);

            _roomTypeUdpateView.RoomTypeTitle = roomType.Title;
            _roomTypeUdpateView.RoomTypeDetail = roomType.Detail;
            _roomTypeUdpateView.RoomTypePricePerNight = roomType.PricePerNight;
        }

        public async void UpdateRoomType()
        {
            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to save these changes?");
            if (confirmed == false) return;

            var updated = new RoomTypeUpdateDto()
            {
                Title = _roomTypeUdpateView.RoomTypeTitle,
                Detail = _roomTypeUdpateView.RoomTypeDetail,
                PricePerNight = _roomTypeUdpateView.RoomTypePricePerNight,
            };

            try
            {
                await _roomTypeService.UpdateAsync(updated);
                RoomTypePresenter.Instance.LoadRoomTypeList();
                _roomTypeUdpateView.Close();
                MainPresenter.Instance.ShowMessage(MessageType.ASK, "Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }

        public async void DeleteRoomType()
        {
            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to delete this room type?");
            if (confirmed == false) return;

            try
            {
                await _roomTypeService.DeleteByIdAsync(_roomTypeUdpateView.RoomTypeId);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Success", "Room type deleted successfully!");
                RoomTypePresenter.Instance.LoadRoomTypeList();
                _roomTypeUdpateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }
    }
}
