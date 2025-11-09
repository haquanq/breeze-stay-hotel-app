using HotelManagement.Domain.Services.Customer;
using HotelManagement.WinformApp.Views.Customer;
using System;
using HotelManagement.Domain.Dtos.Customer;
using System.Windows.Forms;
using HotelManagement.WinformApp.Constants;
using HotelManagement.Infrastructure.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

namespace HotelManagement.WinformApp.Presenters.Customer
{
    public class CustomerPresenter
    {
        public static CustomerPresenter Instance;

        private CustomerSearchDto _customerSearchDto;

        private readonly ICustomerView _customerView;
        private readonly ICustomerService _customerService;
        private readonly Func<CustomerUpdatePresenter> _customerUpdatePresenterFactory;
        private readonly Func<CustomerAddPresenter> _customerCreatePresenterFactory;

        public CustomerPresenter(
            ICustomerView customerView,
            ICustomerService customerService,
            Func<CustomerUpdatePresenter> customerUpdatePresenterFactory,
            Func<CustomerAddPresenter> customerCreatePresenterFactory)
        {
            Instance = this;
            _customerSearchDto = new CustomerSearchDto();

            _customerView = customerView;
            _customerService = customerService;
            _customerCreatePresenterFactory = customerCreatePresenterFactory;
            _customerUpdatePresenterFactory = customerUpdatePresenterFactory;

            _customerView.OnAmenityViewLoad += HandleViewLoadEvent;
            _customerView.OnCustomerSearchChange += HandleCustomerFilterChange;
            _customerView.OnCustomerPaginationChange += HandleCustomerPaginationChange;
            _customerView.OnCustomerCreateViewOpen += HandleCustomerCreateViewOpen;
            _customerView.OnCustomerUpdateViewOpen += HandleCustomerUdpateViewOpen;
            _customerView.OnCustomerDetailViewOpen += HandleCustomerDetailViewOpen;

            LoadCustomerSearchFieldFilter();
            LoadCustomerStatusFilter();
            LoadCustomerPageSizeFilter();

        }

        private void HandleViewLoadEvent(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void HandleCustomerUdpateViewOpen(object sender, EventArgs e)
        {
            string selectedCustomerId = _customerView.SelectedCustomerId;
            if (selectedCustomerId == null) return;
            _customerUpdatePresenterFactory().ShowView(selectedCustomerId);
        }

        private void HandleCustomerCreateViewOpen(object sender, EventArgs e)
        {
            _customerCreatePresenterFactory().ShowView();
        }

        private void HandleCustomerDetailViewOpen(object sender, EventArgs e)
        {
            /// TODO  
        }

        private void HandleCustomerPaginationChange(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void HandleCustomerFilterChange(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        public void ShowView()
        {
            _customerView.Show();
        }

        public ICustomerView GetView()
        {
            return _customerView;
        }

        public async void LoadCustomerList()
        {
            var result = await _customerService.FindAsync(_customerSearchDto,
                new PageRequest
                {
                    OffsetElements = _customerView.CustomerPageOffset,
                    PageNumber = _customerView.CustomerCurrentPage
                });

            _customerView.CustomerCurrentPage = result.CurrentPage;
            _customerView.CustomerTotalPages = result.TotalPages;
            _customerView.SetupCustomerGridView(new BindingSource(result.Content, null));
        }

        public void LoadCustomerPageSizeFilter()
        {
            var bindingSource = new BindingSource(CustomerViewConfig.PageOffset, null);
            _customerView.SetupCustomerPageSizeComboBox(bindingSource, "Value", "Key");
        }

        public void LoadCustomerStatusFilter()
        {
            var bindingSource = new BindingSource(CustomerViewConfig.StatusDescription, null);
            _customerView.SetupCustomerStatusComboBox(bindingSource, "Value", "Key");
        }

        public void LoadCustomerSearchFieldFilter()
        {
            var dict = new Dictionary<string, string>
            {
                { "All", "Search by (Field)" }
            };

            foreach (var p in typeof(CustomerSearchDto).GetProperties())
            {
                var a = p.GetCustomAttributes<DisplayNameAttribute>();

                if (a.Count() > 0)
                {
                    dict.Add(p.Name, a.First().DisplayName);
                }
            }
            _customerView.SetupCustomerSearchFieldComboBox(new BindingSource(dict, null), "Value", "Key");
        }
    }
}
