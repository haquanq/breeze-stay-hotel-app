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
    public class EmployeeUpdatePresenter
    {
        private readonly IEmployeeUpdateView _staffUpdateView;
        private readonly IEmployeeService _staffService;

        public EmployeeUpdatePresenter(IEmployeeUpdateView staffUpdateView, IEmployeeService staffService)
        {
            /// inejceted
            _staffUpdateView = staffUpdateView;
            _staffService = staffService;

            /// events
            _staffUpdateView.OnAmenityViewLoad += HandleViewLoad;
            _staffUpdateView.OnStaffSave += HandleStaffSave;
            _staffUpdateView.OnStaffDelete += HandleStaffDelete;
            _staffUpdateView.OnCancel += HandleCancel;



        }

        /// <summary>
        /// Private methods for handling StaffUpdateView events 
        /// </summary>
        private void HandleViewLoad(object sender, EventArgs e)
        {
            ///.......
        }

        private void HandleStaffSave(object sender, EventArgs e)
        {
            SaveStaff();
        }

        private void HandleStaffDelete(object sender, EventArgs e)
        {
            DeleteStaff();
        }

        private void HandleCancel(object sender, EventArgs e)
        {
            _staffUpdateView.Hide();
        }

        /// <summary>
        /// Public methods for handling StaffUpdateView logic 
        /// </summary>
        public void ShowView(string staffId)
        {
            LoadStaffById(staffId);
            _staffUpdateView.Show();
        }

        public async void LoadStaffById(string staffId)
        {
            var staff = await _staffService.FindByIdAsync(staffId);

            _staffUpdateView.StaffId = staff.StaffId;
            _staffUpdateView.StaffFirstName = staff.FirstName;
            _staffUpdateView.StaffLastName = staff.LastName;
            _staffUpdateView.StaffPhone = staff.Phone;
            _staffUpdateView.StaffDob = staff.Dob;
            _staffUpdateView.StaffEmail = staff.Email;
            _staffUpdateView.StaffPassword = staff.AccountPassword;
            _staffUpdateView.StaffCreatedAt = staff.CreatedAt;
            _staffUpdateView.StaffUpdatedAt = staff.UpdatedAt;
        }

        public void LoadStaffRoleList()
        {
            var s = new BindingSource(EmployeeViewConfig.RoleDescription, null);
            _staffUpdateView.SetupStaffRoleComboBox(s, "text", "value");
        }

        public void LoadStaffStatusCatalog()
        {
            var bindingSource = new BindingSource(EmployeeViewConfig.AccountStatusDescription, null);
            _staffUpdateView.SetupStaffStatusComboBox(bindingSource, "text", "value");
        }

        public async void SaveStaff()
        {
            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to save these changes?");
            if (confirmed == false) return;

            var createdStaff = new StaffUpdateDto()
            {
                StaffId = _staffUpdateView.StaffId,
                Dob = _staffUpdateView.StaffDob,
                FirstName = _staffUpdateView.StaffFirstName,
                LastName = _staffUpdateView.StaffLastName,
                Email = _staffUpdateView.StaffEmail,
                Phone = _staffUpdateView.StaffPhone,
                AccountPassword = _staffUpdateView.StaffPassword,
                Role = _staffUpdateView.StaffRole,
                AccountStatus = _staffUpdateView.StaffStatus,
            };

            try
            {
                await _staffService.UpdateAsync(createdStaff);

                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Changes saved successfully!");
                EmployeePresenter.Instance.LoadAllStaff();
                _staffUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }

        public async void DeleteStaff()
        {

            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to delete this staff?");
            if (confirmed == false) return;

            try
            {
                await _staffService.DeleteByIdAsync(_staffUpdateView.StaffId);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Staff deleted successfully!");
                EmployeePresenter.Instance.LoadAllStaff();
                _staffUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }
    }
}
