using HotelManagement.Domain.Dtos.DiscountCoupon;
using HotelManagement.Domain.Services.DiscountCoupon;
using HotelManagement.Infrastructure.Common;
using HotelManagement.WinformApp.Constants;
using HotelManagement.WinformApp.Views.DiscountCoupon;
using System;
using System.Reflection;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.WinformApp.Presenters.DiscountCoupon
{
    public class DiscountCouponPresenter
    {
        public static DiscountCouponPresenter Instance;

        private DiscountCouponSearchDto _discountCouponSearchDto;
        private PageRequest _pageRequest;

        private readonly IDiscountCouponView _discountCouponView;
        private readonly IDiscountCouponService _discountCouponService;
        private readonly Func<DiscountCouponUpdatePresenter> _discountCouponUpdatePresenterFactory;
        private readonly Func<DiscountCouponAddPresenter> _discountCouponCreatePresenterFactory;

        public DiscountCouponPresenter(
            IDiscountCouponView discountCuoponView,
            IDiscountCouponService discountCouponService,
            Func<DiscountCouponUpdatePresenter> discountCouponUpdatePresenterFactory,
            Func<DiscountCouponAddPresenter> discountCouponCreatePresenterFactory
            )
        {
            Instance = this;

            _discountCouponView = discountCuoponView;
            _discountCouponService = discountCouponService;
            _discountCouponCreatePresenterFactory = discountCouponCreatePresenterFactory;
            _discountCouponUpdatePresenterFactory = discountCouponUpdatePresenterFactory;

            _discountCouponView.OnAmenityViewLoad += HandleViewLoadEvent;
            _discountCouponView.OnDiscountCouponPaginationChange += HandleDiscountCouponPaginationChange;
            _discountCouponView.OnDiscountCouponFilterChange += HandleDiscountCouponFilterChange;
            _discountCouponView.OnDiscountCouponCreateViewOpen += HandleDiscountCouponCreateViewOpen;
            _discountCouponView.OnDiscountCouponUpdateViewOpen += HandleDiscountCouponUdpateViewOpen;

            LoadDiscountCouponSearchField();
            LoadDiscountCouponStatuFilter();
        }

        private void HandleViewLoadEvent(object sender, EventArgs e)
        {
            LoadDiscountCouponList();
        }

        private void HandleDiscountCouponFilterChange(object sender, EventArgs e)
        {
            LoadDiscountCouponList();
        }

        private void HandleDiscountCouponPaginationChange(object sender, EventArgs e)
        {
            LoadDiscountCouponList();
        }

        private void HandleDiscountCouponUdpateViewOpen(object sender, EventArgs e)
        {
            string selectedDiscountCouponId = _discountCouponView.SelectedDiscountCouponId;
            if (selectedDiscountCouponId == null) return;
            _discountCouponUpdatePresenterFactory().ShowView(selectedDiscountCouponId);
        }

        private void HandleDiscountCouponCreateViewOpen(object sender, EventArgs e)
        {
            _discountCouponCreatePresenterFactory().ShowView();
        }

        public void ShowView()
        {
            _discountCouponView.Show();
        }
        public IDiscountCouponView GetViewInstance()
        {
            return _discountCouponView;
        }

        public async void LoadDiscountCouponList()
        {

            var result = await _discountCouponService.FindAsync(_discountCouponSearchDto, _pageRequest);

            _discountCouponView.DiscountCouponPageNumber = result.CurrentPage;
            _discountCouponView.DiscountCouponPageCount = result.TotalPages;
            _discountCouponView.SetupDiscountCouponGridView(new BindingSource(result.Content, null));
        }

        public void LoadDiscountCouponStatuFilter()
        {
            var bindingSource = new BindingSource(DiscountCouponViewConfig.StatusDescription, null);
            bindingSource.Insert(0, new { Key = "All", Value = "All" });
            _discountCouponView.SetupDiscountCouponStatusFilter(bindingSource, "Value", "Key");
        }

        public void LoadDiscountCouponSearchField()
        {
            var dict = new Dictionary<string, string>
            {
                { "All", "Search by (Field)" }
            };

            foreach (var p in typeof(DiscountCouponSearchDto).GetProperties())
            {
                var a = p.GetCustomAttributes<DisplayNameAttribute>().First();
                if (a != null)
                {
                    dict.Add(p.Name, a.DisplayName);
                }
            }
            _discountCouponView.SetupDiscountCouponSearchField(new BindingSource(dict, null), "text", "value");
        }
    }
}
