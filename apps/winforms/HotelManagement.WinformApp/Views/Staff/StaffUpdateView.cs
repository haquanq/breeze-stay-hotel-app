using HotelManagement.Domain.Enums;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Staff
{
    public partial class EmployeeUpdateView : Form, IEmployeeUpdateView
    {
        public StaffRole CurrentUserRole { get; set; } = StaffRole.ADMIN;

        private string _staffId;
        public string StaffId
        {
            get => _staffId;
            set
            {
                _staffId = value;
                lblStaffId.Text = value;
            }
        }
        public string StaffFirstName
        {
            get => txtStaffFirstName.Text;
            set => txtStaffFirstName.Text = value;
        }
        public string StaffLastName
        {
            get => txtStaffLastName.Text; set =>
                txtStaffLastName.Text = value;
        }
        public DateTime StaffDob
        {
            get => dtpStaffDob.Value;
            set => dtpStaffDob.Value = value;
        }
        public string StaffPhone
        {
            get => txtStaffPhone.Text;
            set => txtStaffPhone.Text = value;
        }
        public string StaffEmail
        {
            get => txtStaffEmail.Text;
            set => txtStaffEmail.Text = value;
        }
        public string StaffPassword
        {
            get => txtStaffPassword.Text;
            set => txtStaffPassword.Text = value;
        }
        private DateTime _staffCreatedAt;
        public DateTime StaffCreatedAt
        {
            get => _staffCreatedAt;
            set
            {
                _staffCreatedAt = value;
                lblCreatedAt.Text = $"Created at: {value:dd-MM-yyyy hh:mm tt}";
            }
        }
        private DateTime _staffUpdatedAt;
        public DateTime StaffUpdatedAt
        {
            get => _staffUpdatedAt;
            set
            {
                _staffUpdatedAt = value;
                lblUpdatedAt.Text = $"Created at: {value:dd-MM-yyyy hh:mm tt}";
            }
        }
        public StaffRole StaffRole
        {
            get => (StaffRole)cbbStaffRole.SelectedValue;
            set => cbbStaffRole.SelectedValue = value;
        }
        public StaffAccountStatus StaffStatus
        {
            get => (StaffAccountStatus)cbbStaffStatus.SelectedValue;
            set
            {
                cbbStaffStatus.SelectedValue = value;

                lblStaffstatus.Text = value.ToString();
                /// set status color
            }

        }

        public event EventHandler OnStaffSave;
        public event EventHandler OnStaffDelete;
        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnCancel;
        public event EventHandler OnAmenityViewDisposed;

        public EmployeeUpdateView()
        {
            InitializeComponent();
            dtpStaffDob.CustomFormat = "dd-MM-yyyy";

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate { OnStaffDelete?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
            btnSave.Click += delegate { OnStaffSave?.Invoke(this, EventArgs.Empty); };

            if (CurrentUserRole == StaffRole.ADMIN)
            {
                txtStaffPassword.Visible = true;
                lblPw.Visible = true;
                cbbStaffRole.Enabled = true;
                cbbStaffStatus.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                txtStaffPassword.Visible = false;
                lblPw.Visible = false;
                cbbStaffRole.Enabled = false;
                cbbStaffStatus.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        public void SetupStaffRoleComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbStaffRole.DataSource = bindingSource;
            cbbStaffRole.DisplayMember = displayMember;
            cbbStaffRole.ValueMember = valueMember;
        }

        public void SetupStaffStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbStaffStatus.DataSource = bindingSource;
            cbbStaffStatus.DisplayMember = displayMember;
            cbbStaffStatus.ValueMember = valueMember;
        }
    }
}
