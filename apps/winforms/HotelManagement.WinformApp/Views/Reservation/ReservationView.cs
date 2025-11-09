using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Views.Main;
using HotelManagement.Views.Reservation;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Reservation
{
    public partial class ReservationView : Form, IReservationView
    {
        public static DataTable dtbReservation = new DataTable();

        public StaffRole CurrentUserRole { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SelectedReservationId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnReservationCreateViewOpen;
        public event EventHandler OnReservationUpdateViewOpen;
        public event EventHandler OnReservationDetailViewOpen;

        public ReservationView()
        {
            InitializeComponent();

            grvReservation.Columns["total_price"].DefaultCellStyle.Format = "##,0 vnd";
            grvReservation.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["arrival_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["departure_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
        }
        private void FormRerservation_Load(object sender, EventArgs e)
        {
        }

        private void HandleUserPermission()
        {
            if (Enum.TryParse(LoginView.currentUser.Role.ToString(), out StaffRole role))
            {
                if (role == StaffRole.MANAGER)
                {
                    btnCreate.Visible = true;
                    btnReservationUpdate.Visible = true;
                }
                else if (role == StaffRole.RECEPTIONIST)
                {
                    btnCreate.Visible = true;
                    btnReservationUpdate.Visible = true;
                }
                else if (role == StaffRole.HOUSEKEEPER)
                {
                    btnCreate.Visible = false;
                    btnReservationUpdate.Visible = false;
                }
                else if (role == StaffRole.ADMIN)
                {
                    btnCreate.Visible = false;
                    btnReservationUpdate.Visible = false;
                }
            }
        }


        private void HandleReservationSelectionChange()
        {
            if (grvReservation.CurrentRow == null) return;

            if (Enum.TryParse(grvReservation.CurrentRow.Cells["status"].Value.ToString(), out ReservationStatus status))
            {
                if (status == ReservationStatus.CHECKED_OUT || status == ReservationStatus.CANCELLED)
                {
                    btnReservationUpdate.Visible = false;
                }
                else
                {
                    HandleUserPermission();
                    btnReservationUpdate.Visible = btnReservationUpdate.Visible;
                }
            }
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            var f = new ReservationCreateView();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbReservation);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvReservation.DataSource = dv;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvReservation.CurrentRow == null) return;
            var f = new ReservationUpdateView(grvReservation.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void cbbStatusFitler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbReservation);
            int x = cbbStatusFilter.SelectedIndex;

            if (x == 0)
            {
                grvReservation.DataSource = dtbReservation;
            }
            else
            {
                dv.RowFilter = $"status = '{cbbStatusFilter.SelectedValue}'";
                grvReservation.DataSource = dv;
            }
        }

        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            if (grvReservation.CurrentRow == null) return;
            var f = new ReservationDetailView(grvReservation.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void grvReservation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvReservation.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out ReservationStatus status))
                {
                }
            }
        }

        public void SetupReservationGridView()
        {
            throw new NotImplementedException();
        }

        public void SetupReservationStatusComboBox()
        {
            throw new NotImplementedException();
        }
    }
}
