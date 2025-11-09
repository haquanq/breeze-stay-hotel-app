using HotelManagement.Domain.Enums;
using HotelManagement.Infrastructure.Database;
using HotelManagement.WinformApp.Constants;
using HotelManagement.WinformApp.Views.Reservation;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Customer
{
    public partial class CustomerDetailView : Form, ICustomerDetailView
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
        public string CustomerPid
        {
            get => lblCustomerPid.Text;
            set => lblCustomerPid.Text = value;
        }
        public string CustomerFirstName
        {
            get => lblCustomerFirstName.Text;
            set => lblCustomerFirstName.Text = value;
        }
        public string CustomerLastName
        {
            get => lblCustomerLastName.Text;
            set => lblCustomerLastName.Text = value;
        }
        public string CustomerAddress
        {
            get => lblCustomerAddress.Text;
            set => lblCustomerAddress.Text = value;
        }
        public string CustomerPhone
        {
            get => lblCustomerPhone.Text;
            set => lblCustomerPhone.Text = value;
        }
        public string CustomerEmail
        {
            get => lblCustomerEmail.Text;
            set => lblCustomerEmail.Text = value;
        }

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
        private CustomerStatus _customerStatus;
        public CustomerStatus CustomerStatus
        {
            get => _customerStatus;
            set
            {
                _customerStatus = value;
                lblCustomerStatus.Text = value.ToString();

                Color dark = ColorTranslator.FromHtml(CustomerViewConfig.StatusColor[value].Dark);
                lblCustomerStatus.ForeColor = dark;
                pnCustomerStatus.BackColor = dark;
            }
        }

        public event EventHandler OnReservationMoreDetail;
        public event EventHandler OnReservationSearch;
        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnExit;
        public event EventHandler OnAmenityViewDisposed;

        public CustomerDetailView(string selectedCustomerId)
        {
            InitializeComponent();

            DataTable _dtbReservaionSearchType = new DataTable();
            _dtbReservaionSearchType.Columns.Add("value", typeof(string));
            _dtbReservaionSearchType.Columns.Add("text", typeof(string));
            _dtbReservaionSearchType.Rows.Add("id", "Reservation ID");
            _dtbReservaionSearchType.Rows.Add("staff_id", "Staff ID");
            _dtbReservaionSearchType.Rows.Add("staff_name", "Staff Name");
            _dtbReservaionSearchType.Rows.Add("customer_id", "Customer ID");
            _dtbReservaionSearchType.Rows.Add("customer_name", "Customer Name");
            cbbSearchType.DataSource = _dtbReservaionSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            DataTable _dtbReservationStatus = new DataTable();
            _dtbReservationStatus.Columns.Add("value", typeof(string));
            _dtbReservationStatus.Columns.Add("text", typeof(string));
            _dtbReservationStatus.Rows.Add("All", "All");
            _dtbReservationStatus.Rows.Add("PENDING", "Pending");
            _dtbReservationStatus.Rows.Add("CHECKED_IN", "Checked in");
            _dtbReservationStatus.Rows.Add("CHECKED_OUT", "Checked out");
            _dtbReservationStatus.Rows.Add("CANCELLED", "Canceled");
            cbbStatusFilter.DataSource = _dtbReservationStatus;
            cbbStatusFilter.DisplayMember = "text";
            cbbStatusFilter.ValueMember = "value";

            grvReservation.Columns["total_price"].DefaultCellStyle.Format = "##,0 vnd";
            grvReservation.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["arrival_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["departure_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["checked_in_at"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["checked_out_at"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
        }
        private void FormCustomerDetail_Load(object sender, EventArgs e)
        {
        }

        private void LoadCustomerDetailById(string customerId)
        {
            using (var conn = new DbConnectionFactory().CreateConnection())
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from customer where id=@customer_id";
                cmd.Parameters.AddWithValue("@customer_id", customerId);

                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);

                    var cells = dt.Rows[0];
                    lblCustomerId.Text = cells["id"].ToString();
                    lblCustomerPid.Text = cells["pid"].ToString();
                    lblCustomerFirstName.Text = cells["first_name"].ToString();
                    lblCustomerLastName.Text = cells["last_name"].ToString();
                    lblCustomerPhone.Text = cells["phone"].ToString();
                    lblCustomerEmail.Text = cells["email"].ToString();
                    lblCustomerAddress.Text = cells["address"].ToString();
                    lblCustomerCreatedAt.Text = DateTime.Parse(cells["created_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblCustomerUpdatedAt.Text = DateTime.Parse(cells["updated_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                }

                string sql = $"SELECT a.id, STRING_AGG(c.room_code, '\r\n') as rooms, " +
                            " a.created_at, a.updated_at, a.arrival_time, a.departure_time, " +
                            " a.checked_in_at,a.checked_out_at, a.status, a.total_balance FROM dbo.reservation a " +
                        " INNER JOIN dbo.reservation_room b ON a.id = b.reservation_id " +
                        " INNER JOIN dbo.room c ON b.room_id = c.id " +
                        " INNER JOIN dbo.customer d ON a.customer_id = d.id " +
                        " INNER JOIN dbo.staff d ON .customer_id = d.id " +
                        " GROUP BY a.id, a.created_at, a.updated_at, a.arrival_time, a.departure_time, " +
                            " a.checked_in_at,a.checked_out_at, a.status, a.total_balance ";
            }
        }


        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            if (grvReservation.CurrentRow == null) return;
            var f = new ReservationDetailView(grvReservation.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e) => Dispose();

        private void grvReservation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvReservation.Rows)
            {
            }
        }

        public void SetupReservationStatusComboBox(DataTable dtbReservationStatus, string displayMember, string valueMember)
        {
            throw new NotImplementedException();
        }

        public void SetupReservationSearchTypeComboBox(DataTable dtbReservationStatus, string displayMember, string valueMember)
        {
            throw new NotImplementedException();
        }

        public void SetupReservationGridView(BindingSource bindingSource)
        {
            throw new NotImplementedException();
        }
    }
}
