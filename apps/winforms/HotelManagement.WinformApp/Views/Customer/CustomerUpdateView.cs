using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Constants;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Customer
{
    public partial class CustomerUpdateView : Form, ICustomerUpdateView
    {
        private string _customerId;
        public string CustomerId
        {
            get => _customerId;
            set
            {
                _customerId = value;
                lblCustomerId.Text = value;
            }
        }
        public string CustomerCitizenIdNumber { get => txtCustomerPid.Text; set => txtCustomerPid.Text = value; }
        public string CustomerFirstName { get => txtCustomerFirstName.Text; set => txtCustomerFirstName.Text = value; }
        public string CustomerLastName { get => txtCustomerLastName.Text; set => txtCustomerLastName.Text = value; }
        public string CustomerAddress { get => txtCustomerAddress.Text; set => txtCustomerAddress.Text = value; }
        public string CustomerPhone { get => txtCustomerPhone.Text; set => txtCustomerPhone.Text = value; }
        public string CustomerEmail { get => txtCustomerEmail.Text; set => txtCustomerEmail.Text = value; }

        private DateTime _customerCreatedAt;
        public DateTime CustomerCreatedAt
        {
            get => _customerCreatedAt;
            set
            {
                _customerCreatedAt = value;
                lblCustomerCreatedAt.Text = $"Created at: {value:dd-MM-yyyy HH:mm}";
            }
        }
        private DateTime _customerUpdatedAt;
        public DateTime CustomerUpdatedAt
        {
            get => _customerUpdatedAt;
            set
            {
                _customerUpdatedAt = value;
                lblCustomerUpdatedAt.Text = $"Created at: {value:dd-MM-yyyy HH:mm}";
            }
        }
        public CustomerStatus CustomerStatus
        {
            get => (CustomerStatus)cbbCustomerStatus.SelectedValue;
            set
            {
                Color bgDark = ColorTranslator.FromHtml(CustomerViewConfig.StatusColor[value].DarkHex);

                cbbCustomerStatus.SelectedValue = value;
                lblCustomerStatus.Text = value.ToString();
                lblCustomerStatus.ForeColor = bgDark;
                pnCustomerStatus.BackColor = bgDark;
            }
        }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnCancel;
        public event EventHandler OnCustomerSave;
        public event EventHandler OnCustomerDelete;

        public CustomerUpdateView()
        {
            InitializeComponent();

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnSave.Click += delegate { OnCustomerSave?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate { OnCustomerDelete?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
        }

        public void SetupCustomerStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbCustomerStatus.DataSource = bindingSource;
            cbbCustomerStatus.DisplayMember = displayMember;
            cbbCustomerStatus.ValueMember = valueMember;
        }
    }
}
