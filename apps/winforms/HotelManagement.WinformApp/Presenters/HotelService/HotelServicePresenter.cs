using HotelManagement.Domain.Dtos.HotelService;
using HotelManagement.Domain.Services.HotelService;
using HotelManagement.WinformApp.Views.HotelService;
using System;
using System.Reflection;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Infrastructure.Common;
using System.Collections.Generic;

namespace HotelManagement.WinformApp.Presenters.HotelService
{
    public class HotelServicePresenter
    {
        public static HotelServicePresenter Instance;

        private HotelServiceSearchDto _hotelServiceSearchDto;
        private PageRequest _pageRequest;

        private readonly IHotelServiceView _hotelServiceView;
        private readonly IHotelServiceService _hotelServiceService;
        private readonly Func<HotelServiceCreatePresenter> _hotelServiceCreatePresenterFactory;
        private readonly Func<HotelServiceUpdatePresenter> _hotelServiceUpdatePresenterFactory;

        public HotelServicePresenter(
            IHotelServiceView hotelServiceView,
            IHotelServiceService hotelServiceService,
            Func<HotelServiceCreatePresenter> hotelServiceCreatePresenterFactory,
            Func<HotelServiceUpdatePresenter> hotelServiceUpdatePresenterFactory
            )
        {
            Instance = this;

            _hotelServiceView = hotelServiceView;
            _hotelServiceService = hotelServiceService;
            _hotelServiceCreatePresenterFactory = hotelServiceCreatePresenterFactory;
            _hotelServiceUpdatePresenterFactory = hotelServiceUpdatePresenterFactory;

            _hotelServiceView.OnAmenityViewLoad += HandleViewLoadEvent;
            _hotelServiceView.OnHotelServiceCreateViewOpen += HandleHotelServiceCreateViewOpen;
            _hotelServiceView.OnHotelServiceUpdateViewOpen += HandleHotelServiceUpdateViewOpen;
            _hotelServiceView.OnHotelServicePaginationChange += HandleHotelServicePaginationChange;
            _hotelServiceView.OnHotelServiceFilterChange += HandleHotelServiceFilterChange;
        }

        private void HandleViewLoadEvent(object sender, EventArgs e)
        {
            LoadHotelServiceSearchField();
            LoadHotelServiceList();
        }

        private void HandleHotelServicePaginationChange(object sender, EventArgs e)
        {
            LoadHotelServiceList();
        }

        private void HandleHotelServiceFilterChange(object sender, EventArgs e)
        {
            LoadHotelServiceList();
        }

        private void HandleHotelServiceUpdateViewOpen(object sender, EventArgs e)
        {
            string selectedHotelServiceId = _hotelServiceView.SelectedHotelServiceId;
            if (selectedHotelServiceId is null) return;
            _hotelServiceUpdatePresenterFactory().ShowView(selectedHotelServiceId);
        }

        private void HandleHotelServiceCreateViewOpen(object sender, EventArgs e)
        {
            _hotelServiceCreatePresenterFactory().ShowView();
        }

        /// <summary>
        /// Publid methods for hanlding HotelServiceView logic
        /// </summary>

        public void ShowView() => _hotelServiceView.Show();

        public async void LoadHotelServiceList()
        {
            var result = await Task.Run(() => _hotelServiceService.FindAsync(_hotelServiceSearchDto, _pageRequest));

            _hotelServiceView.SetupHotelServiceGridView(new BindingSource(result.Content, null));
            _hotelServiceView.HotelServicePageCount = result.TotalPages;
            _hotelServiceView.HotelServicePageNumber = result.CurrentPage;
        }

        public void LoadHotelServiceSearchField()
        {

            var dict = new Dictionary<string, string>
            {
                { "All", "Search by (Field)" }
            };

            foreach (var p in typeof(HotelServiceSearchDto).GetProperties())
            {
                var a = p.GetCustomAttributes<DisplayNameAttribute>().First();
                if (a != null)
                {
                    dict.Add(p.Name, a.DisplayName);
                }
            }
            _hotelServiceView.SetupHotelServiceSearchFieldComboBox(new BindingSource(dict, null), "Value", "Key");
        }
    }
}

