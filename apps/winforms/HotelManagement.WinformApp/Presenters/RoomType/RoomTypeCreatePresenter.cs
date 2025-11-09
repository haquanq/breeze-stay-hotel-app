using HotelManagement.Domain.Dtos.RoomType;
using HotelManagement.Domain.Services.RoomType;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Enums;
using HotelManagement.WinformApp.Views.RoomType;
using System;

namespace HotelManagement.WinformApp.Presenters.RoomType
{
    public class RoomTypeCreatePresenter
    {
        private readonly IRoomTypeAddView _roomTypeCreateView;
        private readonly IRoomTypeService _roomTypeService;
        public RoomTypeCreatePresenter(
            IRoomTypeAddView roomTypeCreateView,
            IRoomTypeService roomTypeService
            )
        {
            /// injected
            _roomTypeCreateView = roomTypeCreateView;
            _roomTypeService = roomTypeService;

            /// events
            _roomTypeCreateView.OnRoomTypeAdd += HandleRoomTypeCreate;
            _roomTypeCreateView.OnCancel += HandleCancel;
        }

        /// <summary>
        /// Private methods for handling RoomTypeCreateView events
        /// </summary>
        private void HandleRoomTypeCreate(object s, EventArgs e)
        {
            CreateRoomType();
        }

        private void HandleCancel(object s, EventArgs e) { _roomTypeCreateView.Close(); }

        /// <summary>
        /// Public methos for handling RoomTypeCreateView logics
        /// </summary>
        public void ShowView()
        {
            _roomTypeCreateView.Show();
        }

        public async void CreateRoomType()
        {
            var createdRoomType = new RoomTypeCreateDto()
            {
                Title = _roomTypeCreateView.RoomTypeTitle,
                Detail = _roomTypeCreateView.RoomTypeDetail,
                PricePerNight = _roomTypeCreateView.RoomTypePricePerNight,
            };

            try
            {
                await _roomTypeService.CreateAsync(createdRoomType);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Room type created successfully!");
                RoomTypePresenter.Instance.LoadRoomTypeList();
                _roomTypeCreateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);

            }
        }
    }
}
