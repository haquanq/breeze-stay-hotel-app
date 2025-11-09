using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Constants;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Room
{
    public partial class RoomView : Form, IRoomView
    {

        public StaffRole CurrentUserRole { get; set; }

        public string SelectedRoomId
        {
            get
            {
                if (grvRoom.CurrentRow == null) return null;
                return grvRoom.CurrentRow.Cells["id"].Value.ToString();
            }
        }
        public string SelectedRoomTypeId { get => (string)cbbRoomTypeFilter.SelectedValue; }
        public bool UsingFilterRoomType { get => cbbRoomTypeFilter.SelectedIndex != 0; }
        public RoomStatus SelectedRoomStatus { get => (RoomStatus)cbbRoomStatusFilter.SelectedValue; }
        public bool UsingFilterRoomStatus { get => cbbRoomStatusFilter.SelectedIndex != 0; }
        public string SelectedRoomSearchField { get => (string)cbbRoomSearchField.SelectedValue; }
        public bool UsingFilterRoomSearchField { get => cbbRoomSearchField.SelectedIndex != 0; }
        public string RoomSearchText { get => txtRoomSearch.Text; }
        public int RoomPageCount { get => pgnRoomView.TotalPages; set => pgnRoomView.TotalPages = value; }
        public int RoomPageSize { get => (int)cbbRoomPageSize.SelectedValue; set => cbbRoomPageSize.SelectedValue = value; }
        public int RoomPageNumber { get => pgnRoomView.CurrentPage; set => pgnRoomView.CurrentPage = value; }

        public event EventHandler OnRoomUpdateViewOpen;
        public event EventHandler OnRoomAddViewOpen;
        public event EventHandler OnRoomPaginationChange;
        public event EventHandler OnRoomFilterChange;
        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;

        public RoomView()
        {
            InitializeComponent();

            /// ui
            grvRoom.Columns["PricePerNight"].DefaultCellStyle.Format = "##,0 vnd";
            grvRoom.Columns["CreatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvRoom.Columns["UpdatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            DisableSearchBar();

            /// events
            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnRoomUpdate.Click += delegate { OnRoomUpdateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnRoomAdd.Click += delegate { OnRoomAddViewOpen?.Invoke(this, EventArgs.Empty); };
            btnRoomSearch.Click += delegate { OnRoomFilterChange?.Invoke(this, EventArgs.Empty); };

            cbbRoomTypeFilter.SelectionChangeCommitted += delegate { OnRoomFilterChange?.Invoke(this, EventArgs.Empty); };
            cbbRoomStatusFilter.SelectionChangeCommitted += delegate { OnRoomFilterChange?.Invoke(this, EventArgs.Empty); };
            cbbRoomSearchField.SelectionChangeCommitted += delegate { HandleSelectedSearchFieldChange(); };

            grvRoom.CellPainting += delegate { PaintRoomStatusColor(); };
            pgnRoomView.OnPaginationChange += delegate { OnRoomPaginationChange?.Invoke(this, EventArgs.Empty); };

        }

        private void PaintRoomStatusColor()
        {
            foreach (DataGridViewRow row in grvRoom.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out RoomStatus status))
                {
                    Color lightColor = ColorTranslator.FromHtml(RoomViewConfig.StatusColor[status].LightHex);
                    row.Cells["status"].Style.BackColor = lightColor;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }
        }

        private void HandleSelectedSearchFieldChange()
        {
            if (UsingFilterRoomSearchField)
            {
                txtRoomSearch.Enabled = true;
                txtRoomSearch.Text = "";
                txtRoomSearch.BackColor = SystemColors.Window;
                return;
            };
            DisableSearchBar();

            OnRoomFilterChange?.Invoke(this, EventArgs.Empty);
        }

        private void DisableSearchBar()
        {
            txtRoomSearch.Text = "Search...";
            txtRoomSearch.Enabled = false;
            txtRoomSearch.BackColor = SystemColors.Window;
        }

        private void HandleUserPermission()
        {
            if (CurrentUserRole == StaffRole.MANAGER)
            {
                btnRoomAdd.Visible = true;
                btnRoomUpdate.Visible = true;
            }
            if (CurrentUserRole == StaffRole.RECEPTIONIST)
            {
                btnRoomAdd.Visible = true;
                btnRoomUpdate.Visible = true;
            }
            if (CurrentUserRole == StaffRole.HOUSEKEEPER)
            {
                btnRoomAdd.Visible = false;
                btnRoomUpdate.Visible = false;
            }
            if (CurrentUserRole == StaffRole.ADMIN)
            {
                btnRoomAdd.Visible = false;
                btnRoomUpdate.Visible = false;
            }
        }

        public void SetupRoomGridView(BindingSource bindingSource)
        {
            grvRoom.DataSource = bindingSource;
        }

        public void SetupRoomTypeFilterComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbRoomTypeFilter.DataSource = bindingSource;
            cbbRoomTypeFilter.DisplayMember = displayMember;
            cbbRoomTypeFilter.ValueMember = valueMember;
        }

        public void SetupRoomStatusFilterComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbRoomStatusFilter.DataSource = bindingSource;
            cbbRoomStatusFilter.DisplayMember = displayMember;
            cbbRoomStatusFilter.ValueMember = valueMember;
        }

        public void SetupRoomSearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {

            cbbRoomSearchField.DataSource = bindingSource;
            cbbRoomSearchField.DisplayMember = displayMember; ;
            cbbRoomSearchField.ValueMember = valueMember;
        }

        public void SetupRoomPageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbRoomPageSize.DataSource = bindingSource;
            cbbRoomPageSize.DisplayMember = displayMember;
            cbbRoomPageSize.ValueMember = valueMember;
        }
    }
}
