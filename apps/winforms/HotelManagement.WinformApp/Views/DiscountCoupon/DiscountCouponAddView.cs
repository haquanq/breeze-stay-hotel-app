using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.DiscountCoupon
{
    public partial class DiscountCouponAddView : Form, IDiscountCouponAddView
    {
        public string DiscountCouponCode { get => txtCouponCode.Text; set => txtCouponCode.Text = value; }
        public string DiscountCouponTitle { get => txtTitle.Text; set => txtTitle.Text = value; }
        public string DiscountCouponDetail { get => txtDetail.Text; set => txtDetail.Text = value; }
        public DateTime DiscountCouponExpiredAt { get => dtpCouponExpireAt.Value; set => dtpCouponExpireAt.Value = value; }
        public int DiscountCouponRate { get => (int)numRatePercent.Value; set => numRatePercent.Value = value; }
        public int DiscountCouponUsageLimit { get => (int)numUsageLimit.Value; set => numUsageLimit.Value = value; }
        public int DiscountCouponMinBalance { get => (int)numMinBalanceRequired.Value; set => numMinBalanceRequired.Value = value; }

        public event EventHandler OnDiscountCouponAdd;
        public event EventHandler OnCancel;
        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;

        public DiscountCouponAddView()
        {
            InitializeComponent();
            dtpCouponExpireAt.CustomFormat = "dd-MM-yyyy HH:mm";

            btnDiscountCouponAdd.Click += delegate { OnDiscountCouponAdd?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
        }
    }
}
