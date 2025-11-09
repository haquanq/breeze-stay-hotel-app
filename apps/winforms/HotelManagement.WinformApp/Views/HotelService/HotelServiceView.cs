using HotelManagement.Domain.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.HotelService
{
    public partial class HotelServiceView : Form, IHotelServiceView
    {
        public StaffRole CurrentUserRole { get; set; }
        public string SelectedHotelServiceId
        {
            get
            {
                if (grvHotelService.CurrentRow == null) return null;
                return grvHotelService.CurrentRow.Cells["HotelServiceId"].Value.ToString();
            }
        }
        public string SelectedHotelServiceSearchField { get => (string)cbbHotelServiceSearchField.SelectedValue; }
        public bool UsingFilterHotelServiceSearchField { get => cbbHotelServiceSearchField.SelectedIndex > 0; }
        public string HotelServiceSearchText { get => txtHotelServiceSearch.Text; }
        public int HotelServicePageCount { get => pgnHotelServiceView.TotalPages; set => pgnHotelServiceView.TotalPages = value; }
        public int HotelServicePageSize { get => (int)cbbHotelServicePageSize.SelectedValue; set => cbbHotelServicePageSize.SelectedValue = value; }
        public int HotelServicePageNumber { get => pgnHotelServiceView.CurrentPage; set => pgnHotelServiceView.CurrentPage = value; }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnHotelServicePaginationChange;
        public event EventHandler OnHotelServiceFilterChange;
        public event EventHandler OnHotelServiceCreateViewOpen;
        public event EventHandler OnHotelServiceUpdateViewOpen;

        public HotelServiceView()
        {
            InitializeComponent();

            /// ui
            DisableSearchBox();

            /// events
            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnHotelServiceAddViewOpen.Click += delegate { OnHotelServiceCreateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnHotelServiceUpdateViewOpen.Click += delegate { OnHotelServiceUpdateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnHotelServiceSearch.Click += delegate { OnHotelServiceFilterChange?.Invoke(this, EventArgs.Empty); };
            cbbHotelServiceSearchField.SelectionChangeCommitted += delegate { HandleSelectedSearchFieldChange(); };
            pgnHotelServiceView.OnPaginationChange += delegate { OnHotelServicePaginationChange?.Invoke(this, EventArgs.Empty); };
        }

        private void HandleSelectedSearchFieldChange()
        {
            if (UsingFilterHotelServiceSearchField)
            {
                txtHotelServiceSearch.Enabled = true;
                txtHotelServiceSearch.Text = "";
                txtHotelServiceSearch.BackColor = SystemColors.Window;
                return;
            };
            DisableSearchBox();
            OnHotelServiceFilterChange?.Invoke(this, EventArgs.Empty);
        }

        private void DisableSearchBox()
        {
            txtHotelServiceSearch.Text = "Search...";
            txtHotelServiceSearch.Enabled = false;
            txtHotelServiceSearch.BackColor = SystemColors.Window;
        }

        private void HandleUserPermission()
        {
            if (CurrentUserRole == StaffRole.MANAGER)
            {
                btnHotelServiceAddViewOpen.Visible = true;
                btnHotelServiceUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.RECEPTIONIST)
            {
                btnHotelServiceAddViewOpen.Visible = true;
                btnHotelServiceUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.HOUSEKEEPER)
            {
                btnHotelServiceAddViewOpen.Visible = false;
                btnHotelServiceUpdateViewOpen.Visible = false;
            }
            if (CurrentUserRole == StaffRole.ADMIN)
            {
                btnHotelServiceAddViewOpen.Visible = false;
                btnHotelServiceUpdateViewOpen.Visible = false;
            }
        }

        public void SetupHotelServiceGridView(BindingSource bindingSource)
        {
            grvHotelService.DataSource = bindingSource;
        }

        public void SetupHotelServiceSearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbHotelServiceSearchField.DataSource = bindingSource;
            cbbHotelServiceSearchField.DisplayMember = displayMember;
            cbbHotelServiceSearchField.ValueMember = valueMember;
        }

        public void SetupHotelServicePageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbHotelServicePageSize.DataSource = bindingSource;
            cbbHotelServicePageSize.DisplayMember = displayMember;
            cbbHotelServicePageSize.ValueMember = valueMember;
        }
    }
}
