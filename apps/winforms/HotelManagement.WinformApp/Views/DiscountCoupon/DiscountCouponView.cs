using HotelManagement.Domain.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.DiscountCoupon
{
    public partial class DiscountCouponView : Form, IDiscountCouponView
    {
        public string SelectedDiscountCouponId
        {
            get
            {
                if (grvDiscountCoupon.CurrentRow == null) return null;
                return grvDiscountCoupon.CurrentRow.Cells["DiscountCouponId"].Value.ToString();
            }
        }
        public DiscountCouponStatus SelectedDiscountCouponStatus { get => (DiscountCouponStatus)cbbDiscountCouponStatusFilter.SelectedValue; }
        public string SelectedDiscountCouponSearchField { get => (string)cbbDiscountCouponSearchField.SelectedValue; }
        public bool UsingFilterDiscountCouponStatus { get => cbbDiscountCouponStatusFilter.SelectedIndex != 0; }
        public bool UsingFilterDiscountCouponSearchField { get => cbbDiscountCouponSearchField.SelectedIndex != 0; }
        public string DiscountCouponSearchText { get => txtDiscountCouponSearch.Text; }
        public int DiscountCouponPageCount { get => pgnDiscountCoupon.TotalPages; set => pgnDiscountCoupon.TotalPages = value; }
        public int DiscountCouponPageSize { get => (int)cbbDiscountCouponPageSize.SelectedValue; set => cbbDiscountCouponPageSize.SelectedValue = value; }
        public int DiscountCouponPageNumber { get => pgnDiscountCoupon.CurrentPage; set => pgnDiscountCoupon.CurrentPage = value; }


        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnDiscountCouponCreateViewOpen;
        public event EventHandler OnDiscountCouponUpdateViewOpen;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnDiscountCouponPaginationChange;
        public event EventHandler OnDiscountCouponFilterChange;

        public StaffRole CurrentUserRole { get; set; }

        public DiscountCouponView()
        {
            InitializeComponent();

            /// ui
            grvDiscountCoupon.Columns["ExpiredAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvDiscountCoupon.Columns["CreatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvDiscountCoupon.Columns["UpdatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvDiscountCoupon.Columns["MinBalance"].DefaultCellStyle.Format = "##,0";

            DisableSearchBar();

            /// events
            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnDiscountCouponCreateViewOpen.Click += delegate { OnDiscountCouponCreateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnDiscountCouponUpdateViewOpen.Click += delegate { OnDiscountCouponUpdateViewOpen?.Invoke(this, EventArgs.Empty); };

            btnDiscountCouponSearch.Click += delegate { OnDiscountCouponFilterChange?.Invoke(this, EventArgs.Empty); };
            grvDiscountCoupon.CellPainting += delegate { PaintDiscountCouponStatusColor(); };
            pgnDiscountCoupon.OnPaginationChange += delegate { OnDiscountCouponPaginationChange?.Invoke(this, EventArgs.Empty); };
            cbbDiscountCouponStatusFilter.SelectionChangeCommitted += delegate { OnDiscountCouponFilterChange?.Invoke(this, EventArgs.Empty); };
            cbbDiscountCouponSearchField.SelectionChangeCommitted += delegate { HandleSelectedSearchFieldChange(); };
        }

        private void PaintDiscountCouponStatusColor()
        {
            foreach (DataGridViewRow row in grvDiscountCoupon.Rows)
            {
            }
        }

        private void HandleSelectedSearchFieldChange()
        {
            if (UsingFilterDiscountCouponSearchField)
            {
                txtDiscountCouponSearch.Enabled = true;
                txtDiscountCouponSearch.Text = "";
                txtDiscountCouponSearch.BackColor = SystemColors.Window;
                return;
            };
            DisableSearchBar();

            OnDiscountCouponFilterChange?.Invoke(this, EventArgs.Empty);
        }

        private void DisableSearchBar()
        {
            txtDiscountCouponSearch.Text = "Search...";
            txtDiscountCouponSearch.Enabled = false;
            txtDiscountCouponSearch.BackColor = SystemColors.Window;
        }

        public void SetupDiscountCouponGridView(BindingSource bindingSource)
        {
            grvDiscountCoupon.DataSource = bindingSource;
        }

        public void SetupDiscountCouponSearchField(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbDiscountCouponSearchField.DataSource = bindingSource;
            cbbDiscountCouponSearchField.DisplayMember = displayMember;
            cbbDiscountCouponSearchField.ValueMember = valueMember;
        }

        public void SetupDiscountCouponStatusFilter(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbDiscountCouponStatusFilter.DataSource = bindingSource;
            cbbDiscountCouponStatusFilter.DisplayMember = displayMember;
            cbbDiscountCouponStatusFilter.ValueMember = valueMember;
        }

        private void HandleCurrentUserPermission()
        {
            if (CurrentUserRole == StaffRole.MANAGER)
            {
                btnDiscountCouponCreateViewOpen.Visible = true;
                btnDiscountCouponUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.RECEPTIONIST)
            {
                btnDiscountCouponCreateViewOpen.Visible = true;
                btnDiscountCouponUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.HOUSEKEEPER)
            {
                btnDiscountCouponCreateViewOpen.Visible = false;
                btnDiscountCouponUpdateViewOpen.Visible = false;
            }
            if (CurrentUserRole == StaffRole.ADMIN)
            {
                btnDiscountCouponCreateViewOpen.Visible = false;
                btnDiscountCouponUpdateViewOpen.Visible = false;
            }

        }
    }
}
