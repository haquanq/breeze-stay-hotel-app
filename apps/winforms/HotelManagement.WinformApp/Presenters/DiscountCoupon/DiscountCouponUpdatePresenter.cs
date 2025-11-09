using HotelManagement.Domain.Dtos.DiscountCoupon;
using HotelManagement.Domain.Services.DiscountCoupon;
using HotelManagement.WinformApp.Views.DiscountCoupon;
using System;
using System.Data;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Enums;
using System.Windows.Forms;
using HotelManagement.WinformApp.Constants;

namespace HotelManagement.WinformApp.Presenters.DiscountCoupon
{
    public class DiscountCouponUpdatePresenter
    {
        private readonly DataTable _dtbDiscountCouponStatus;

        private readonly IDiscountCouponUpdateView _disocuntCouponUpdateView;
        private readonly IDiscountCouponService _discountCouponService;

        public DiscountCouponUpdatePresenter(
            IDiscountCouponUpdateView discountCouponUpdateView,
            IDiscountCouponService discountCouponService
            )
        {
            /// injected
            _disocuntCouponUpdateView = discountCouponUpdateView;
            _discountCouponService = discountCouponService;

            /// events
            _disocuntCouponUpdateView.OnAmenityViewLoad += HandleViewLoad;
            _disocuntCouponUpdateView.OnDiscountCouponSave += HandleDiscountCouponSave;
            _disocuntCouponUpdateView.OnDiscountCouponDelete += HandleDiscountCouponDelete;
            _disocuntCouponUpdateView.OnCancel += HandleCancel;


            LoadDiscountCouponStatusList();
        }

        /// <summary>
        /// Private methods for handling DiscountCouponUdpateView events
        /// </summary>
        private void HandleViewLoad(object sender, EventArgs e)
        {
        }

        private void HandleDiscountCouponSave(object sender, EventArgs e)
        {
            SaveDiscountCoupon();
        }

        private void HandleDiscountCouponDelete(object sender, EventArgs e)
        {
            DeleteDiscountCoupon();
        }

        private void HandleCancel(object sender, EventArgs e) { _disocuntCouponUpdateView.Close(); }

        /// <summary>
        /// Public methods for handling DiscountCouponUpdateView logic
        /// </summary>
        public void ShowView(string discountCouponId)
        {
            LoadDiscountCouponById(discountCouponId);
            _disocuntCouponUpdateView.Show();
        }

        public void LoadDiscountCouponStatusList()
        {
            var bindingSource = new BindingSource(DiscountCouponViewConfig.StatusDescription, null);
            _disocuntCouponUpdateView.SetupDiscountCouponStatusComboBox(bindingSource, "Value", "Key");
        }

        public async void LoadDiscountCouponById(string discountCouponId)
        {
            var discountCoupon = await _discountCouponService.FindByIdAsync(discountCouponId);

            var v = _disocuntCouponUpdateView;
            v.DiscountCouponId = discountCoupon.DiscountCouponId;
            v.DiscountCouponTitle = discountCoupon.Title;
            v.DiscountCouponDetail = discountCoupon.Detail;
            v.DiscountCouponCode = discountCoupon.CouponCode;
            v.DiscountCouponExpiredAt = discountCoupon.ExpiredAt;
            v.DiscountCouponRatePercent = discountCoupon.RatePercent;
            v.DiscountCouponUsageLimit = discountCoupon.UsageLimit;
            v.DiscountCouponMinBalance = discountCoupon.MinBalance;
            v.DiscountCouponStatus = discountCoupon.Status;
            v.DiscountCouponCreatedAt = discountCoupon.CreatedAt;
            v.DiscountCouponUpdatedAt = discountCoupon.UpdatedAt;
        }

        public async void SaveDiscountCoupon()
        {
            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to save these changes?");
            if (confirmed == false) return;

            var v = _disocuntCouponUpdateView;
            var discountCoupon = new DiscountCouponUpdateDto()
            {
                DiscountCouponId = v.DiscountCouponId,
                Title = v.DiscountCouponTitle,
                Detail = v.DiscountCouponDetail,
                CouponCode = v.DiscountCouponCode,
                UsageLimit = v.DiscountCouponUsageLimit,
                RatePercent = v.DiscountCouponRatePercent,
                ExpiredAt = v.DiscountCouponExpiredAt,
                MinBalance = v.DiscountCouponMinBalance,
                Status = v.DiscountCouponStatus,
            };

            try
            {
                await _discountCouponService.UpdateAsync(discountCoupon);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Changes saved successfully!");
                DiscountCouponPresenter.Instance.LoadDiscountCouponList();
                _disocuntCouponUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.INFO, ex.Message);
            }
        }

        public async void DeleteDiscountCoupon()
        {
            var confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to delete this record?");
            if (confirmed == false) return;

            try
            {
                await _discountCouponService.DeleteByIdAsync(_disocuntCouponUpdateView.DiscountCouponId);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Discount coupon deleted successfully!");
                DiscountCouponPresenter.Instance.LoadDiscountCouponList();
                _disocuntCouponUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.INFO, ex.Message);
            }
        }
    }
}
