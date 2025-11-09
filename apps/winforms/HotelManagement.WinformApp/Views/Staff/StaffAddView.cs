using HotelManagement.Domain.Enums;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Staff
{
    public partial class EmployeeAddView : Form, IEmployeeAddView
    {
        public string StaffFirstName { get => txtUserFirstName.Text; set => txtUserFirstName.Text = value; }
        public string StaffLastName { get => txtUserLastName.Text; set => txtUserLastName.Text = value; }
        public DateTime StaffDob { get => dtpUserDob.Value; set => dtpUserDob.Value = value; }
        public string StaffPhone { get => txtUserPhone.Text; set => txtUserPhone.Text = value; }
        public string StaffEmail { get => txtUserEmail.Text; set => txtUserEmail.Text = value; }
        public StaffRole StaffRole { get => (StaffRole)cbbUserRole.SelectedValue; set => cbbUserRole.SelectedValue = value; }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnStaffAddClick;
        public event EventHandler OnCancel;

        public EmployeeAddView()
        {
            InitializeComponent();
            dtpUserDob.CustomFormat = "dd-MM-yyyy";

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnAdd.Click += delegate { OnStaffAddClick?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
        }

        public void SetupStaffRoleComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbUserRole.DataSource = bindingSource;
            cbbUserRole.DisplayMember = displayMember;
            cbbUserRole.ValueMember = valueMember;
        }
    }
}
