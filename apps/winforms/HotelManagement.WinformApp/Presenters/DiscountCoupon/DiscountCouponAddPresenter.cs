using HotelManagement.Domain.Dtos.DiscountCoupon;
using HotelManagement.Domain.Enums;
using HotelManagement.Domain.Services.DiscountCoupon;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Enums;
using HotelManagement.WinformApp.Views.DiscountCoupon;
using System;

namespace HotelManagement.WinformApp.Presenters.DiscountCoupon
{
    public class DiscountCouponAddPresenter
    {
        private readonly IDiscountCouponAddView _discountCouponCreateView;
        private readonly IDiscountCouponService _discountCouponService;
        public DiscountCouponAddPresenter(
            IDiscountCouponAddView discoutnCouponAddView,
            IDiscountCouponService discountCouponService
            )
        {
            /// injected
            _discountCouponCreateView = discoutnCouponAddView;
            _discountCouponService = discountCouponService;

            /// events
            _discountCouponCreateView.OnDiscountCouponAdd += HandleDiscountCouponCreateEvent;
            _discountCouponCreateView.OnCancel += HandleCancel;
        }

        /// <summary>
        /// Private methods for handling DiscountCouponCreateView events
        /// </summary>
        private void HandleDiscountCouponCreateEvent(object sender, EventArgs e)
        {
            AddDiscountCoupon();
        }

        private void HandleCancel(object sender, EventArgs e) { _discountCouponCreateView.Close(); }

        /// <summary>
        /// Public methods for handling DiscountCouponCreateView logic
        /// </summary>
        public void ShowView()
        {
            _discountCouponCreateView.Show();
        }

        public async void AddDiscountCoupon()
        {
            var v = _discountCouponCreateView;
            var discountCoupon = new DiscountCouponCreateDto()
            {
                Title = v.DiscountCouponTitle,
                Detail = v.DiscountCouponDetail,
                UsageLimit = v.DiscountCouponUsageLimit,
                RatePercent = v.DiscountCouponRate,
                CouponCode = v.DiscountCouponCode,
                ExpiredAt = v.DiscountCouponExpiredAt,
                MinBalance = v.DiscountCouponMinBalance,
                Status = DiscountCouponStatus.AVAILABLE,
            };

            try
            {
                await _discountCouponService.CreateAsync(discountCoupon);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Discount coupon created successfully!");
                DiscountCouponPresenter.Instance.LoadDiscountCouponList();
                _discountCouponCreateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.INFO, ex.Message);
            }
        }
    }
}
