using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Customer
{
    public partial class CustomerAddView : Form, ICustomerAddView
    {
        public string CustomerCitizenIdNumber { get => txtCustomerCitizenId.Text; set => txtCustomerCitizenId.Text = value; }
        public string CustomerFirstName { get => txtCustomerFirstName.Text; set => txtCustomerFirstName.Text = value; }
        public string CustomerLastName { get => txtCustomerLastName.Text; set => txtCustomerLastName.Text = value; }
        public string CustomerAddress1 { get => txtCustomerAddress1.Text; set => txtCustomerAddress1.Text = value; }
        public string CustomerAddress2 { get => txtCustomerAddress2.Text; set => txtCustomerAddress2.Text = value; }
        public string CustomerPhone { get => txtCustomerPhone.Text; set => txtCustomerPhone.Text = value; }
        public string CustomerEmail { get => txtCustomerEmail.Text; set => txtCustomerEmail.Text = value; }

        public event EventHandler OnCustomerAdd;
        public event EventHandler OnCancel;
        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;

        public CustomerAddView()
        {
            InitializeComponent();

            btnCustomerAdd.Click += delegate { OnCustomerAdd?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
        }
    }
}
