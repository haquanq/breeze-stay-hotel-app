using HotelManagement.Domain.Dtos.Staff;
using HotelManagement.Domain.Services.Staff;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Constants;
using HotelManagement.WinformApp.Enums;
using HotelManagement.WinformApp.Views.Staff;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Presenters.Staff
{
    public class EmployeeAddPresenter
    {
        private readonly IEmployeeAddView _staffCreateView;
        private readonly IEmployeeService _staffService;
        public EmployeeAddPresenter(IEmployeeAddView staffCreateView, IEmployeeService staffService)
        {
            /// injected
            _staffCreateView = staffCreateView;
            _staffService = staffService;

            /// events
            _staffCreateView.OnAmenityViewLoad += HandleViewLoad;
            _staffCreateView.OnStaffAddClick += HandleStaffCreateClick;
            _staffCreateView.OnCancel += HandleCancel;
        }

        /// <summary>
        /// Private methods for handling StaffCreateView events
        /// </summary>
        private void HandleViewLoad(object sender, EventArgs e)
        {
            LoadStaffRoleComboBox();
        }

        private void HandleStaffCreateClick(object sender, EventArgs e)
        {
            CreateStaff();
        }

        private void HandleCancel(object sender, EventArgs e)
        {
            _staffCreateView.Close();
        }

        /// <summary>
        /// Public methods for handling StaffCreateView logic
        /// </summary>
        public void ShowView()
        {
            _staffCreateView.Show();
        }

        public async void CreateStaff()
        {
            string defaultPassword = "1";

            var createdStaff = new StaffCreateDto()
            {
                Dob = _staffCreateView.StaffDob,
                FirstName = _staffCreateView.StaffFirstName,
                LastName = _staffCreateView.StaffLastName,
                Email = _staffCreateView.StaffEmail,
                Phone = _staffCreateView.StaffPhone,
                Role = _staffCreateView.StaffRole,
                AccountPassword = defaultPassword,
            };

            try
            {
                await _staffService.CreateAsync(createdStaff);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "User created successfully!");
                EmployeePresenter.Instance.LoadAllStaff();
                _staffCreateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            };
        }

        public void LoadStaffRoleComboBox()
        {
            var bindingSource = new BindingSource(EmployeeViewConfig.RoleDescription, null);
            _staffCreateView.SetupStaffRoleComboBox(bindingSource, "text", "value");
        }
    }
}
