using HotelManagement.Domain.Dtos.Customer;
using HotelManagement.Domain.Enums;
using HotelManagement.Domain.Services.Customer;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Enums;
using HotelManagement.WinformApp.Views.Customer;
using System;

namespace HotelManagement.WinformApp.Presenters.Customer
{
    public class CustomerAddPresenter
    {
        private readonly ICustomerAddView _customerAddView;
        private readonly ICustomerService _customerService;
        public CustomerAddPresenter(ICustomerAddView view, ICustomerService customerService)
        {
            /// inejceted
            _customerAddView = view;
            _customerService = customerService;

            /// events
            _customerAddView.OnCustomerAdd += HandleCustomerAddEvent;
            _customerAddView.OnCancel += HandleCancel;
        }

        /// <summary>
        /// Private methods for handling CustomerAddView's events
        /// </summary>

        private void HandleCustomerAddEvent(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void HandleCancel(object sender, EventArgs e) { _customerAddView.Close(); }

        /// <summary>
        /// Public methods for handling CustomerAddView's logic
        /// </summary>

        public void ShowView() { _customerAddView.Show(); }

        public async void AddCustomer()
        {
            var customer = new CustomerCreateDto()
            {
                FirstName = _customerAddView.CustomerFirstName,
                LastName = _customerAddView.CustomerLastName,
                Phone = _customerAddView.CustomerPhone,
                Email = _customerAddView.CustomerEmail,
                Address1 = _customerAddView.CustomerAddress1,
                Address2 = _customerAddView.CustomerAddress2,
                CitizenIdNumber = _customerAddView.CustomerCitizenIdNumber,
                Status = CustomerStatus.NEW,
            };

            try
            {
                await _customerService.CreateAsync(customer);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Customer added successfully!");
                CustomerPresenter.Instance.LoadCustomerList();
                _customerAddView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.INFO, ex.Message);
            }
        }
    }
}
