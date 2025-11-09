using HotelManagement.Domain.Services.Room;
using System;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using HotelManagement.WinformApp.Views.Room;
using HotelManagement.Domain.Services.RoomType;
using HotelManagement.WinformApp.Constants;
using HotelManagement.Domain.Dtos.Room;
using HotelManagement.Infrastructure.Common;
using System.ComponentModel;
using System.Collections.Generic;
using HotelManagement.Domain.Dtos.RoomType;

namespace HotelManagement.WinformApp.Presenters.Room
{
    public class RoomPresenter
    {
        public static RoomPresenter Instance;

        private RoomSearchDto _roomSearchDto;
        private PageRequest _pageRequest;

        private readonly IRoomView _roomView;
        private readonly IRoomService _roomService;
        private readonly IRoomTypeService _roomTypeService;

        public RoomPresenter
            (
            IRoomView roomView,
            IRoomService roomService,
            IRoomTypeService roomTypeService

            )
        {
            Instance = this;

            /// injected
            _roomView = roomView;
            _roomService = roomService;
            _roomTypeService = roomTypeService;

            /// events
            _roomView.OnAmenityViewLoad += HandleViewLoad;
            _roomView.OnRoomAddViewOpen += HandleRoomCreateViewOpen;
            _roomView.OnRoomUpdateViewOpen += HandleRoomUpdateViewOpen;
            _roomView.OnRoomFilterChange += HandleRoomFilterChange;
            _roomView.OnRoomPaginationChange += HandleRoomPaginationChange;
        }

        /// <summary>
        /// Private methods for handlings RoomView events
        /// </summary>
        private void HandleViewLoad(object sender, EventArgs e)
        {
            LoadAllRoom();
        }

        private void HandleRoomPaginationChange(object sender, EventArgs e)
        {
            LoadAllRoom();
        }

        private void HandleRoomFilterChange(object s, EventArgs e)
        {
            LoadAllRoom();
        }

        private void HandleRoomCreateViewOpen(object sender, EventArgs e)
        {
        }

        private void HandleRoomUpdateViewOpen(object sender, EventArgs e)
        {
            string selectedRoomId = _roomView.SelectedRoomId;
            if (selectedRoomId == null) return;
        }

        /// <summary>
        /// Public methods for handlings RoomView logic
        /// </summary>

        public void ShowView() { _roomView.Show(); }
        public IRoomView GetView() { return _roomView; }

        public void LoadRoomStatusFilter()
        {
            var bindingSource = new BindingSource(RoomViewConfig.StatusDescription, null);
            _roomView.SetupRoomStatusFilterComboBox(bindingSource, "text", "value");
        }

        public void LoadRoomSearchField()
        {

            var dict = new Dictionary<string, string>
            {
                { "All", "Search by (Field)" }
            };

            foreach (var p in typeof(RoomSearchDto).GetProperties())
            {
                var a = p.GetCustomAttributes<DisplayNameAttribute>().First();
                if (a != null)
                {
                    dict.Add(p.Name, a.DisplayName);
                }
            }
            _roomView.SetupRoomSearchFieldComboBox(new BindingSource(dict, null), "Value", "Key");
        }

        public async void LoadRoomTypeFilter()
        {
            var res = await _roomTypeService.FindAsync(new RoomTypeSearchDto(), new PageRequest());
            _roomView.SetupRoomTypeFilterComboBox(new BindingSource(res.Content, null), "text", "value");
        }

        public async void LoadAllRoom()
        {

            var result = await _roomService.FindAsync(_roomSearchDto, _pageRequest);

            _roomView.SetupRoomGridView(new BindingSource(result.Content, null));
            _roomView.RoomPageCount = result.TotalPages;
            _roomView.RoomPageNumber = result.CurrentPage;
        }
    }
}
