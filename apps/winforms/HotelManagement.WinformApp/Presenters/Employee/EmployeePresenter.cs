using HotelManagement.Domain.Services.Staff;
using System;
using System.Windows.Forms;
using HotelManagement.WinformApp.Views.Staff;
using HotelManagement.WinformApp.Constants;
using HotelManagement.Domain.Dtos.Staff;
using HotelManagement.Infrastructure.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

namespace HotelManagement.WinformApp.Presenters.Staff
{
    public class EmployeePresenter
    {
        public static EmployeePresenter Instance;

        private EmployeeSearchDto _employeeSearchDto;
        private PageRequest _pageRequest;

        private readonly IEmployeeView _employeeView;
        private readonly IEmployeeService _employeeService;
        private readonly Func<EmployeeAddPresenter> _employeeCreatePresenterFactory;
        private readonly Func<EmployeeUpdatePresenter> _employeeUpdatePresenterFactory;

        public EmployeePresenter(
            IEmployeeView employeeView,
            IEmployeeService employeeService,
            Func<EmployeeAddPresenter> employeeCreatePresenterFactory,
            Func<EmployeeUpdatePresenter> employeeUpdatePresenterFactory)
        {
            Instance = this;

            _employeeView = employeeView;
            _employeeService = employeeService;
            _employeeCreatePresenterFactory = employeeCreatePresenterFactory;
            _employeeUpdatePresenterFactory = employeeUpdatePresenterFactory;

            _employeeView.OnAmenityViewLoad += HandleViewLoad;
            _employeeView.OnStaffCreateViewOpen += HandleStaffCreateViewOpen;
            _employeeView.OnStaffUpdateViewOpen += HandleStaffUpdateViewOpen;
            _employeeView.OnStaffFilterChange += HandleStaffFilterChange;
            _employeeView.OnStaffPaginationChange += HandleStaffPaginationChange;

            LoadStaffRoleFilter();
            LoadStaffStatusFilter();
            LoadStaffSearchField();
        }

        /// <----->
        /// Private methods for handlings StaffView events

        private void HandleViewLoad(object sender, EventArgs e)
        {
            LoadAllStaff();
        }

        private void HandleStaffPaginationChange(object sender, EventArgs e)
        {
            LoadAllStaff();
        }

        private void HandleStaffFilterChange(object s, EventArgs e)
        {
            LoadAllStaff();
        }

        private void HandleStaffCreateViewOpen(object sender, EventArgs e)
        {
            _employeeCreatePresenterFactory().ShowView();
        }

        private void HandleStaffUpdateViewOpen(object sender, EventArgs e)
        {
            string selectedStaffId = _employeeView.SelectedStaffId;
            if (selectedStaffId == null) return;
            _employeeUpdatePresenterFactory().ShowView(selectedStaffId);
        }

        /// <----->
        /// Public methods for handlings StaffView logic

        public void ShowView()
        {
            _employeeView.Show();
        }

        public async void LoadAllStaff()
        {
            var result = await _employeeService.FindAsync(_employeeSearchDto, _pageRequest);

            _employeeView.SetupStaffGridView(new BindingSource(result.Content, null));
            _employeeView.StaffPageNumber = result.CurrentPage;
            _employeeView.StaffPageCount = result.TotalPages;
        }

        public void LoadStaffStatusFilter()
        {
            var bindingSource = new BindingSource(EmployeeViewConfig.AccountStatusDescription, null);
            _employeeView.SetupStaffStatusFilter(bindingSource, "Value", "Key");
        }

        public void LoadStaffRoleFilter()
        {
            var bindingSource = new BindingSource(EmployeeViewConfig.RoleDescription, null);
            _employeeView.SetupStaffRoleFilter(bindingSource, "Value", "Key");
        }

        public void LoadStaffSearchField()
        {
            var dict = new Dictionary<string, string>
            {
                { "All", "Search by (Field)" }
            };

            foreach (var p in typeof(EmployeeSearchDto).GetProperties())
            {
                var a = p.GetCustomAttributes<DisplayNameAttribute>().First();
                if (a != null)
                {
                    dict.Add(p.Name, a.DisplayName);
                }
            }
            _employeeView.SetupStaffSearchField(new BindingSource(dict, null), "Value", "Key");
        }
    }
}
