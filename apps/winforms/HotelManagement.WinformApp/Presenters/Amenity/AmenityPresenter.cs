using HotelManagement.Domain.Services.Amenity;
using HotelManagement.WinformApp.Views.Amenity;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.WinformApp.Configs;
using HotelManagement.Domain.Dtos.Amenity;
using System.Reflection;
using System.ComponentModel;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.WinformApp.Presenters.Amenity
{
    public class AmenityPresenter
    {
        public static AmenityPresenter Instance;

        private AmenitySearchDto _amenitySearchDto;
        private PageRequest _pageRequest;

        private readonly IAmenityView _amenityView;
        private readonly IAmenityService _amenityService;
        private readonly Func<AmenityAddPresenter> _amenityCreatePresenterFactory;
        private readonly Func<AmenityUpdatePresenter> _amenityUpdatePresenterFactory;

        public AmenityPresenter(
            IAmenityView amenityView,
            IAmenityService amenityService,
            Func<AmenityAddPresenter> amenityCreatePresenterFactory,
            Func<AmenityUpdatePresenter> amenityUpdatePresenterFactory
            )
        {
            Instance = this;

            _amenityView = amenityView;
            _amenityService = amenityService;
            _amenityCreatePresenterFactory = amenityCreatePresenterFactory;
            _amenityUpdatePresenterFactory = amenityUpdatePresenterFactory;

            _amenityView.OnAmenityViewLoad += HandleViewLoadEvent;
            _amenityView.OnAmenityCreateViewOpen += HandleAmenityCreateViewOpen;
            _amenityView.OnAmenityUpdateViewOpen += HandleAmenityUpdateViewOpen;
            _amenityView.OnAmenityPaginationChange += HandleAmenityPaginationChange;
            _amenityView.OnAmenityFilterChange += HandleAmenityFilterChange;
        }

        private void HandleViewLoadEvent(object sender, EventArgs e)
        {
            LoadAmenitySearchFieldFilter();
            LoadAmenitySearchBinding();
            LoadAmenityStatusFilter();
            LoadAmenityList();
        }

        private void HandleAmenityPaginationChange(object sender, EventArgs e)
        {
            LoadAmenityList();
        }

        private void HandleAmenityFilterChange(object sender, EventArgs e)
        {
            LoadAmenityList();
        }

        private void HandleAmenityUpdateViewOpen(object sender, EventArgs e)
        {
            string selectedAmenityId = _amenityView.SelectedAmenityId;
            if (selectedAmenityId is null) return;
            _amenityUpdatePresenterFactory().ShowView(selectedAmenityId);
        }

        private void HandleAmenityCreateViewOpen(object sender, EventArgs e)
        {
            _amenityCreatePresenterFactory().ShowView();
        }

        public async void LoadAmenityList()
        {
            var result = await Task.Run(() => _amenityService.FindAsync(_amenitySearchDto, _pageRequest));

            _amenityView.SetupAmenityGridView(new BindingSource(result.Content, null));
            _amenityView.AmenityPageCount = result.TotalPages;
        }

        public void LoadAmenitySearchFieldFilter()
        {
            var dict = new Dictionary<string, string>
            {
                { "All", "Search by (Field)" }
            };

            foreach (var p in typeof(AmenitySearchDto).GetProperties())
            {
                var a = p.GetCustomAttributes<DisplayNameAttribute>().First();
                if (a != null)
                {
                    dict.Add(p.Name, a.DisplayName);
                }
            }
            _amenityView.SetupAmenitySearchFieldComboBox(new BindingSource(dict, null), "Value", "Key");
        }

        public void LoadAmenityStatusFilter()
        {
            var bindingSource = new BindingSource(AmenityViewConfig.StatusDescription, null);
            bindingSource.Insert(0, new { Value = "All", Key = "All" });
            _amenityView.SetupAmenityStatusComboBox(bindingSource, "Value", "Key");
        }

        public void LoadAmenityPageSizeFilter()
        {
            var bindingSource = new BindingSource(AmenityViewConfig.PageOffset, null);
            _amenityView.SetupAmenityPageSizeComboBox(bindingSource, "Value", "Key");
        }

        public void LoadAmenitySearchBinding()
        {
            _amenitySearchDto = new AmenitySearchDto();
            if (_amenityView.UsingFilterAmenitySearchField == false) return;
            _amenityView.SetupAmenitySearchTextBox(new Binding("Text", _amenitySearchDto, _amenityView.SelectedAmenitySearchField));
        }
    }
}

