using HotelManagement.Domain.Enums;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.DiscountCoupon
{
    public partial class DiscountCouponUpdateView : Form, IDiscountCouponUpdateView
    {
        private string _discountCouponId;
        public string DiscountCouponId { get => _discountCouponId; set { _discountCouponId = value; lblDiscountCouponId.Text = value; } }
        public string DiscountCouponCode { get => txtDiscountCouponCode.Text; set => txtDiscountCouponCode.Text = value; }
        public string DiscountCouponTitle { get => txtTitle.Text; set => txtTitle.Text = value; }
        public string DiscountCouponDetail { get => txtDetail.Text; set => txtDetail.Text = value; }
        public DateTime DiscountCouponExpiredAt { get => dtpDiscountCouponExpiredAt.Value; set => dtpDiscountCouponExpiredAt.Value = value; }
        public int DiscountCouponRatePercent { get => (int)numRatePercent.Value; set => numRatePercent.Value = value; }
        public int DiscountCouponUsageLimit { get => (int)numUsageLimit.Value; set => numUsageLimit.Value = value; }
        public int DiscountCouponMinBalance { get => (int)numMinBalanceRequired.Value; set => numMinBalanceRequired.Value = value; }
        public DiscountCouponStatus DiscountCouponStatus
        {
            get => (DiscountCouponStatus)cbbDiscountCouponStatus.SelectedValue;
            set => cbbDiscountCouponStatus.SelectedValue = value;
        }
        private DateTime _discountCouponCreatedAt;
        public DateTime DiscountCouponCreatedAt
        {
            get => _discountCouponCreatedAt;
            set
            {
                _discountCouponCreatedAt = value;
                lblDiscountCouponCreatedAt.Text = $"Created on: {value:dd-MM-yyyy hh:mm tt}";
            }
        }
        private DateTime _discountCouponUpdatedAt;

        public DateTime DiscountCouponUpdatedAt
        {
            get => _discountCouponUpdatedAt;
            set
            {
                _discountCouponUpdatedAt = value;
                lblDiscountCouponUpdatedAt.Text = $"Updated on: {value:dd-MM-yyyy hh:mm tt}";
            }
        }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnDiscountCouponSave;
        public event EventHandler OnDiscountCouponDelete;
        public event EventHandler OnCancel;
        public event EventHandler OnAmenityViewDisposed;

        public DiscountCouponUpdateView()
        {
            InitializeComponent();
            dtpDiscountCouponExpiredAt.CustomFormat = "dd-MM-yyyy HH:mm";

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnDiscountCouponDelete.Click += delegate { OnDiscountCouponDelete?.Invoke(this, EventArgs.Empty); };
            btnDiscountCouponSave.Click += delegate { OnDiscountCouponSave?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
        }

        public void SetupDiscountCouponStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbDiscountCouponStatus.DataSource = bindingSource;
            cbbDiscountCouponStatus.DisplayMember = displayMember;
            cbbDiscountCouponStatus.ValueMember = valueMember;
        }
    }
}
