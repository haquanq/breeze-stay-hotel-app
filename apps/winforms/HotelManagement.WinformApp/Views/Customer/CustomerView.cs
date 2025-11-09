using HotelManagement.Domain.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;
using HotelManagement.WinformApp.Constants;

namespace HotelManagement.WinformApp.Views.Customer
{
    public partial class CustomerView : Form, ICustomerView
    {
        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnCustomerUpdateViewOpen;
        public event EventHandler OnCustomerCreateViewOpen;
        public event EventHandler OnCustomerDetailViewOpen;
        public event EventHandler OnCustomerPaginationChange;
        public event EventHandler OnCustomerSearchChange;

        public string SelectedCustomerId
        {
            get
            {
                if (grvCustomer.CurrentRow == null) return null;
                return grvCustomer.CurrentRow.Cells["CustomerId"].Value.ToString();
            }
        }

        public StaffRole CurrentUserRole
        {
            get; set;
        }

        public CustomerStatus SelectedCustomerStatus
        {
            get => (CustomerStatus)cbbCustomerStatusFilter.SelectedValue;
        }

        public string SelectedCustomerSearchField
        {
            get => (string)cbbCustomerSearchField.SelectedValue;
        }

        public bool UsingFilterCustomerStatus
        {
            get => cbbCustomerStatusFilter.SelectedIndex > 0;
        }

        public bool UsingFilterCustomerSearchField
        {
            get => cbbCustomerSearchField.SelectedIndex > 0;
        }

        public string CustomerSearchText
        {
            get => txtCustomerSearch.Text;
        }

        public int CustomerTotalPages
        {
            get => pgnCustomer.TotalPages; set => pgnCustomer.TotalPages = value;
        }

        public int CustomerPageOffset
        {
            get => (int)cbbCustomerPageSize.SelectedValue; set => cbbCustomerPageSize.SelectedValue = value;
        }

        public int CustomerCurrentPage
        {
            get => pgnCustomer.CurrentPage; set => pgnCustomer.CurrentPage = value;
        }

        public void SetupCustomerGridView(BindingSource bindingSource)
        {
            grvCustomer.DataSource = bindingSource;
        }

        public void SetupCustomerSearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbCustomerSearchField.DataSource = bindingSource;
            cbbCustomerSearchField.DisplayMember = displayMember;
            cbbCustomerSearchField.ValueMember = valueMember;
        }

        public void SetupCustomerStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbCustomerStatusFilter.DataSource = bindingSource;
            cbbCustomerStatusFilter.DisplayMember = displayMember;
            cbbCustomerStatusFilter.ValueMember = valueMember;
        }

        public void SetupCustomerPageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbCustomerPageSize.DataSource = bindingSource;
            cbbCustomerPageSize.DisplayMember = displayMember;
            cbbCustomerPageSize.ValueMember = valueMember;
        }

        public CustomerView()
        {
            InitializeComponent();
            DisableSearchBar();

            grvCustomer.Columns["CreatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvCustomer.Columns["UpdatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvCustomer.Columns["Status"].Frozen = true;

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnCustomerCreateViewOpen.Click += delegate { OnCustomerCreateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnCustomerUpdateViewOpen.Click += delegate { OnCustomerUpdateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnCustomerDetailViewOpen.Click += delegate { OnCustomerDetailViewOpen?.Invoke(this, EventArgs.Empty); };
            btnCustomerSearch.Click += delegate { OnCustomerSearchChange?.Invoke(this, EventArgs.Empty); };

            grvCustomer.CellPainting += delegate { PaintCustomerStatusColor(); };
            pgnCustomer.OnPaginationChange += delegate { OnCustomerPaginationChange?.Invoke(this, EventArgs.Empty); };

            cbbCustomerStatusFilter.SelectionChangeCommitted += delegate { OnCustomerSearchChange?.Invoke(this, EventArgs.Empty); };
            cbbCustomerSearchField.SelectionChangeCommitted += delegate { HandleSelectedSearchFieldChange(); };
        }

        private void HandleSelectedSearchFieldChange()
        {
            if (UsingFilterCustomerSearchField)
            {
                txtCustomerSearch.Enabled = true;
                txtCustomerSearch.Text = "";
                txtCustomerSearch.BackColor = SystemColors.Window;
                return;
            };

            DisableSearchBar();
            OnCustomerSearchChange?.Invoke(this, EventArgs.Empty);
        }

        private void DisableSearchBar()
        {
            txtCustomerSearch.Text = "Search...";
            txtCustomerSearch.Enabled = false;
            txtCustomerSearch.BackColor = SystemColors.Window;

        }

        private void HandleCurrentUserPermission()
        {
            if (CurrentUserRole == StaffRole.MANAGER)
            {
                btnCustomerCreateViewOpen.Visible = true;
                btnCustomerUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.RECEPTIONIST)
            {
                btnCustomerCreateViewOpen.Visible = true;
                btnCustomerUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.HOUSEKEEPER)
            {
                btnCustomerCreateViewOpen.Visible = false;
                btnCustomerUpdateViewOpen.Visible = false;
            }
            if (CurrentUserRole == StaffRole.ADMIN)
            {
                btnCustomerCreateViewOpen.Visible = false;
                btnCustomerUpdateViewOpen.Visible = false;
            }
        }

        private void PaintCustomerStatusColor()
        {
            foreach (DataGridViewRow row in grvCustomer.Rows)
            {
                bool isValidStatus = Enum.TryParse(row.Cells["status"].Value.ToString(), out CustomerStatus status);
                if (isValidStatus)
                {
                    row.Cells["Status"].Style.BackColor = ColorTranslator.FromHtml(CustomerViewConfig.StatusColor[status].LightHex);
                    row.Cells["Status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }
        }
    }
}
