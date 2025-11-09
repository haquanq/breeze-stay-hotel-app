using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Constants;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Staff
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        public StaffRole CurrentUserRole { get; set; } = StaffRole.ADMIN;

        public string SelectedStaffId
        {
            get
            {
                if (grvStaff.CurrentRow == null) return null;
                return grvStaff.CurrentRow.Cells["id"].Value.ToString();
            }
        }
        public StaffRole SelectedStaffRole { get => (StaffRole)cbbStaffRoleFilter.SelectedValue; }
        public bool UsingFilterStaffRole { get => cbbStaffRoleFilter.SelectedIndex != 0; }
        public StaffAccountStatus SelectedStaffStatus { get => (StaffAccountStatus)cbbStaffStatusFilter.SelectedValue; }
        public bool UsingFilterStaffStatus { get => cbbStaffStatusFilter.SelectedIndex != 0; }
        public string SelectedStaffSearchField { get => (string)cbbStaffSearchField.SelectedValue; }
        public bool UsingFilterStaffSearchField { get => cbbStaffSearchField.SelectedIndex != 0; }
        public string StaffSearchText { get => txtStaffSearch.Text; }
        public int StaffPageCount { get => pgnStaffView.TotalPages; set => pgnStaffView.TotalPages = value; }
        public int StaffPageNumber { get => pgnStaffView.CurrentPage; set => pgnStaffView.CurrentPage = value; }
        public int StaffPageSize { get => (int)cbbStaffPageSize.SelectedValue; set => cbbStaffPageSize.SelectedValue = value; }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnStaffCreateViewOpen;
        public event EventHandler OnStaffUpdateViewOpen;
        public event EventHandler OnStaffFilterChange;
        public event EventHandler OnStaffPaginationChange;

        public EmployeeView()
        {
            InitializeComponent();

            /// ui
            grvStaff.Columns["Dob"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvStaff.Columns["CreatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvStaff.Columns["UpdatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            DisableSearchBar();

            /// events
            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnStaffUpdate.Click += delegate { OnStaffUpdateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnStaffAdd.Click += delegate { OnStaffCreateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnStaffSearch.Click += delegate { OnStaffFilterChange?.Invoke(this, EventArgs.Empty); };

            cbbStaffRoleFilter.SelectionChangeCommitted += delegate { OnStaffFilterChange?.Invoke(this, EventArgs.Empty); };
            cbbStaffStatusFilter.SelectionChangeCommitted += delegate { OnStaffFilterChange?.Invoke(this, EventArgs.Empty); };
            cbbStaffSearchField.SelectionChangeCommitted += delegate { HandleSelectedSearchFieldChange(); };
            grvStaff.CellPainting += delegate { PaintStaffStatusColor(); };
            pgnStaffView.OnPaginationChange += delegate { OnStaffPaginationChange?.Invoke(this, EventArgs.Empty); };
        }

        private void HandleSelectedSearchFieldChange()
        {
            if (UsingFilterStaffSearchField)
            {
                txtStaffSearch.Enabled = true;
                txtStaffSearch.Text = "";
                txtStaffSearch.BackColor = SystemColors.Window;
                return;
            };
            DisableSearchBar();

            OnStaffFilterChange?.Invoke(this, EventArgs.Empty);
        }

        private void DisableSearchBar()
        {
            txtStaffSearch.Text = "Search...";
            txtStaffSearch.Enabled = false;
            txtStaffSearch.BackColor = SystemColors.Window;
        }

        public void SetupStaffGridView(BindingSource bindingSource)
        {
            grvStaff.DataSource = bindingSource;
        }
        public void SetupStaffRoleFilter(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbStaffRoleFilter.DataSource = bindingSource;
            cbbStaffRoleFilter.DisplayMember = displayMember;
            cbbStaffRoleFilter.ValueMember = valueMember;
        }
        public void SetupStaffStatusFilter(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbStaffStatusFilter.DataSource = bindingSource;
            cbbStaffStatusFilter.DisplayMember = displayMember;
            cbbStaffStatusFilter.ValueMember = valueMember;
        }
        public void SetupStaffSearchField(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbStaffSearchField.DataSource = bindingSource;
            cbbStaffSearchField.DisplayMember = displayMember;
            cbbStaffSearchField.ValueMember = valueMember;
        }
        public void SetupStaffPageSize(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbStaffPageSize.DataSource = bindingSource;
            cbbStaffPageSize.DisplayMember = displayMember;
            cbbStaffPageSize.ValueMember = valueMember;
        }

        private void PaintStaffStatusColor()
        {
            foreach (DataGridViewRow row in grvStaff.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out StaffAccountStatus status))
                {
                    Color lightColor = ColorTranslator.FromHtml(EmployeeViewConfig.AccountStatusColor[status].Light);
                    row.Cells["status"].Style.BackColor = lightColor;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }
        }

        private void HandleCurrentUserPermission()
        {

            if (CurrentUserRole == StaffRole.ADMIN)
            {
                btnStaffUpdate.Visible = true;
                btnStaffAdd.Visible = true;
            }
            if (CurrentUserRole == StaffRole.MANAGER)
            {
                btnStaffUpdate.Visible = true;
                btnStaffAdd.Visible = false;
            }
            if (CurrentUserRole == StaffRole.RECEPTIONIST)
            {
                btnStaffUpdate.Visible = false;
                btnStaffAdd.Visible = false;
            }
            if (CurrentUserRole == StaffRole.HOUSEKEEPER)
            {
                btnStaffUpdate.Visible = false;
                btnStaffAdd.Visible = false;
            }
        }

    }
}
