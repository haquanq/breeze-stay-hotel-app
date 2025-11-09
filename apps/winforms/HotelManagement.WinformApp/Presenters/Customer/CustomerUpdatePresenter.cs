using HotelManagement.Domain.Dtos.Customer;
using HotelManagement.Domain.Services.Customer;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Constants;
using HotelManagement.WinformApp.Enums;
using HotelManagement.WinformApp.Views.Customer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Presenters.Customer
{
    public class CustomerUpdatePresenter
    {
        private DataTable _dtbCustomerStatus;
        private readonly ICustomerUpdateView _customerUpdateView;
        private readonly ICustomerService _customerService;

        public CustomerUpdatePresenter(ICustomerUpdateView customerUpdateView, ICustomerService customerService)
        {
            /// injected
            _customerUpdateView = customerUpdateView;
            _customerService = customerService;

            /// events
            _customerUpdateView.OnCustomerSave += HandleCustomerSave;
            _customerUpdateView.OnCustomerDelete += HandleCustomerDelete;
            _customerUpdateView.OnCancel += HandleCancel;

            LoadCustomerStatusComboBox();
        }

        /// <summary>
        /// Private methods for handling CustomerCreateView events
        /// </summary>

        private void HandleCustomerSave(object sender, EventArgs e)
        {
            SaveCustomer();
        }
        private void HandleCustomerDelete(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void HandleCancel(object sender, EventArgs e)
        {
            _customerUpdateView.Close();
        }

        /// <summary>
        /// Publci methods for handling CustomerCreateView logic
        /// </summary>

        public void ShowView(string customerId)
        {
            LoadCustomerById(customerId);
            _customerUpdateView.Show();
        }

        public async void LoadCustomerById(string customerId)
        {
            var customer = await _customerService.FindByIdAsync(customerId);

            var v = _customerUpdateView;

            v.CustomerId = customer.CustomerId;
            v.CustomerCitizenIdNumber = customer.CitizenIdNumber;
            v.CustomerFirstName = customer.FirstName;
            v.CustomerLastName = customer.LastName;
            v.CustomerPhone = customer.Phone;
            v.CustomerEmail = customer.Email;
            v.CustomerAddress = customer.Address1;
            v.CustomerStatus = customer.Status;
            v.CustomerCreatedAt = customer.CreatedAt;
            v.CustomerUpdatedAt = customer.UpdatedAt;
        }

        public void LoadCustomerStatusComboBox()
        {

            var source = new BindingSource(CustomerViewConfig.StatusDescription, null);
            _customerUpdateView.SetupCustomerStatusComboBox(source, "Value", "Text");
        }

        public async void SaveCustomer()
        {
            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to save these changes?");
            if (!confirmed) return;

            var customer = new CustomerUpdateDto()
            {
                CustomerId = _customerUpdateView.CustomerId,
                FirstName = _customerUpdateView.CustomerFirstName,
                LastName = _customerUpdateView.CustomerLastName,
                Email = _customerUpdateView.CustomerEmail,
                Phone = _customerUpdateView.CustomerPhone,
                Address1 = _customerUpdateView.CustomerAddress,
                Status = _customerUpdateView.CustomerStatus,
                CitizenIdNumber = _customerUpdateView.CustomerCitizenIdNumber,
            };

            try
            {
                await _customerService.UpdateAsync(customer);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Changes saved successfully!");
                _customerUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }

        public async void DeleteCustomer()
        {
            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to delete this customer?");
            if (!confirmed) return;

            try
            {
                await _customerService.DeleteByIdAsync(_customerUpdateView.CustomerId);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Customer deleted successfully!");
                _customerUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }
    }
}
