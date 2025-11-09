using HotelManagement.Domain.Dtos.Room;
using HotelManagement.Domain.Dtos.RoomType;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Services.Amenity;
using HotelManagement.Domain.Services.Room;
using HotelManagement.Domain.Services.RoomType;
using HotelManagement.Infrastructure.Common;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Views.Room;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace HotelManagement.WinformApp.Presenters.Room
{
    public class RoomAddPresenter
    {
        private List<AmenityModel> _roomAmenityList;

        private RoomTypeSearchDto _roomTypeSearchDto;
        private PageRequest _pageReqest;

        private readonly IRoomAddView _roomAddView;
        private readonly IRoomService _roomService;
        private readonly IRoomTypeService _roomTypeService;
        private readonly IAmenityService _amenityService;

        public RoomAddPresenter(
            IRoomAddView roomAddView,
            IRoomService roomService,
            IRoomTypeService roomTypeService,
            IAmenityService amenityService
            )
        {
            _roomAddView = roomAddView;
            _roomService = roomService;
            _roomTypeService = roomTypeService;
            _amenityService = amenityService;

            _roomAddView.OnAmenityViewLoad += HandleViewLoad;
            _roomAddView.OnAmenitySearchChange += HandleAmenitySearchChange;
            _roomAddView.OnRoomAmenityAdd += HandleRoomAmenityAdd;
            _roomAddView.OnRoomAmenityRemove += HandleRoomAmenityRemove;
            _roomAddView.OnRoomAdd += HandleRoomAdd;
            _roomAddView.OnCancel += HandleCancel;
        }

        /// <----->
        /// private methods for handling RoomAddView events
        private void HandleViewLoad(object sender, EventArgs e)
        {
            LoadRoomTypeList();
        }

        private void HandleRoomAdd(object sender, EventArgs e)
        {
            AddRoom();
        }

        private void HandleRoomAmenityRemove(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandleRoomAmenityAdd(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandleAmenitySearchChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandleCancel(object sender, EventArgs e)
        {
            _roomAddView.Close();
        }

        /// <----->
        /// public methods for handling RoomAddView logic

        public void ShowView()
        {
            _roomAddView.Show();
        }

        public async void LoadRoomTypeList()
        {
            var result = await _roomTypeService.FindAsync(_roomTypeSearchDto, _pageReqest);
            _roomAddView.SetupRoomTypeComboBox(new System.Windows.Forms.BindingSource(result.Content, null), "Title", "RoomTypeId");
        }

        public async void AddRoom()
        {
            var room = new RoomCreateDto
            {
                FloorNumber = _roomAddView.FloorNumber,
                RoomCode = _roomAddView.RoomCode,
                RoomTypeId = _roomAddView.RoomTypeId,
            };

            try
            {
                await _roomService.CreateAsync(room);
                RoomPresenter.Instance.LoadAllRoom();
                MainPresenter.Instance.ShowMessage(Enums.MessageType.INFO, "Room added successfully!");
                _roomAddView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(Enums.MessageType.ERROR, ex.Message);
            }
        }

        public void AddRoomAmenity()
        {

        }

        public void RemoveRoomAmenity()
        {
            string amenityId = _roomAddView.SelectedAmenityId;
            _roomAmenityList = _roomAmenityList.Where(v => v.AmenityId != _roomAddView.SelectedAmenityId).ToList();
        }
    }
}
