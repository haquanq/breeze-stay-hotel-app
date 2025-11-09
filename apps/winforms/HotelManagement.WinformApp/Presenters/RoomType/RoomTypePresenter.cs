using HotelManagement.Domain.Dtos.RoomType;
using HotelManagement.Domain.Services.RoomType;
using HotelManagement.Infrastructure.Common;
using HotelManagement.WinformApp.Views.RoomType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Presenters.RoomType
{
    public class RoomTypePresenter
    {
        public static RoomTypePresenter Instance;

        private RoomTypeSearchDto _roomTypeSearchDto;
        private PageRequest _pageRequest;

        private readonly IRoomTypeView _roomTypeView;
        private readonly IRoomTypeService _roomTypeService;
        private readonly Func<RoomTypeCreatePresenter> _roomTypeCreatePresenterFactory;
        private readonly Func<RoomTypeUpdatePresenter> _roomTypeUpdatePresenterFactory;

        public RoomTypePresenter(
            IRoomTypeView roomTypeView,
            IRoomTypeService roomTypeService,
            Func<RoomTypeCreatePresenter> roomTypeCreatePresenterFactory,
            Func<RoomTypeUpdatePresenter> roomTypeUpdatePresenterFactory)
        {
            Instance = this;

            /// injected
            _roomTypeView = roomTypeView;
            _roomTypeService = roomTypeService;
            _roomTypeCreatePresenterFactory = roomTypeCreatePresenterFactory;
            _roomTypeUpdatePresenterFactory = roomTypeUpdatePresenterFactory;

            /// events
            _roomTypeView.OnAmenityViewLoad += HandleViewLoadEvent;
            _roomTypeView.OnRoomTypeAddViewOpen += HandleRoomTypeAddViewOpen;
            _roomTypeView.OnRoomTypeUpdateViewOpen += HandleRoomTypeUpdateViewOpen;
            _roomTypeView.OnRoomTypePaginationChange += HandleRoomTypePaginationChange;
            _roomTypeView.OnRoomTypeFilterChange += HandleRoomTypeFilterChange;

            LoadRoomTypeSearchField();
        }

        private void HandleViewLoadEvent(object sender, EventArgs e)
        {
            LoadRoomTypeList();
        }

        private void HandleRoomTypeFilterChange(object sender, EventArgs e)
        {
            LoadRoomTypeList();
        }

        private void HandleRoomTypePaginationChange(object sender, EventArgs e)
        {
            LoadRoomTypeList();
        }

        private void HandleRoomTypeAddViewOpen(object sender, EventArgs e)
        {
            _roomTypeCreatePresenterFactory().ShowView();
        }

        private void HandleRoomTypeUpdateViewOpen(object sender, EventArgs e)
        {
            string selectedRoomTypeId = _roomTypeView.SelectedRoomTypeId;
            if (selectedRoomTypeId is null) return;
            _roomTypeUpdatePresenterFactory().ShowView(selectedRoomTypeId);
        }

        /// <--->
        /// Public methods for handling RoomTypeView logics

        public void ShowView()
        {
            _roomTypeView.Show();
        }

        public async void LoadRoomTypeList()
        {
            var result = await _roomTypeService.FindAsync(_roomTypeSearchDto, _pageRequest);

            _roomTypeView.SetupRoomTypeGridView(new BindingSource(result.Content, null));
            _roomTypeView.RoomTypePageCount = result.TotalPages;
            _roomTypeView.RoomTypePageNumber = result.CurrentPage;
        }

        public void LoadRoomTypeSearchField()
        {
            var dict = new Dictionary<string, string>
            {
                { "All", "Search by (Field)" }
            };

            foreach (var p in typeof(RoomTypeSearchDto).GetProperties())
            {
                var a = p.GetCustomAttributes<DisplayNameAttribute>().First();
                if (a != null)
                {
                    dict.Add(p.Name, a.DisplayName);
                }
            }
            _roomTypeView.SetupRoomTypeSearchFieldComboBox(new BindingSource(dict, null), "text", "value");
        }
    }
}
