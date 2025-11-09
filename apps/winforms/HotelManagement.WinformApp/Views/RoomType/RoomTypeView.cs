using HotelManagement.Domain.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.RoomType
{
    public partial class RoomTypeView : Form, IRoomTypeView
    {
        public StaffRole CurrentUserRole { get; set; }

        public string SelectedRoomTypeId
        {
            get
            {
                if (grvRoomType.CurrentRow == null) return null;
                return (string)grvRoomType.CurrentRow.Cells["RoomTypeId"].Value;
            }
        }
        public string SelectedRoomTypeSearchField { get => (string)cbbRoomTypeSearchField.SelectedValue; }
        public bool UsingFilterRoomTypeSearchField { get => cbbRoomTypeSearchField.SelectedIndex != 0; }
        public string RoomTypeSearchText { get => txtRoomTypeSearch.Text; }
        public int RoomTypePageCount { get => pgnRoomType.TotalPages; set => pgnRoomType.TotalPages = value; }
        public int RoomTypePageSize { get => (int)cbbRoomTypePageSize.SelectedValue; set => cbbRoomTypePageSize.SelectedValue = value; }
        public int RoomTypePageNumber { get => pgnRoomType.CurrentPage; set => pgnRoomType.CurrentPage = value; }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnRoomTypeAddViewOpen;
        public event EventHandler OnRoomTypeUpdateViewOpen;
        public event EventHandler OnRoomTypePaginationChange;
        public event EventHandler OnRoomTypeFilterChange;

        public RoomTypeView()
        {
            InitializeComponent();

            /// ui
            grvRoomType.Columns["PricePerNight"].DefaultCellStyle.Format = "##,0";
            grvRoomType.Columns["CreatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy hh:mm tt";
            grvRoomType.Columns["UpdatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy hh:mm tt";

            DisableSearchBox();

            /// events
            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnRoomTypeCreateViewOpen.Click += delegate { OnRoomTypeAddViewOpen?.Invoke(this, EventArgs.Empty); };
            btnRoomTypeUpdateViewOpen.Click += delegate { OnRoomTypeUpdateViewOpen?.Invoke(this, EventArgs.Empty); };

            btnRoomTypeSearch.Click += delegate { OnRoomTypeFilterChange?.Invoke(this, EventArgs.Empty); };
            cbbRoomTypeSearchField.SelectionChangeCommitted += delegate { HandleSelectedSearchFieldChange(); };
            pgnRoomType.OnPaginationChange += delegate { OnRoomTypePaginationChange?.Invoke(this, EventArgs.Empty); };
        }

        private void HandleSelectedSearchFieldChange()
        {
            if (UsingFilterRoomTypeSearchField)
            {
                txtRoomTypeSearch.Enabled = true;
                txtRoomTypeSearch.Text = "";
                txtRoomTypeSearch.BackColor = SystemColors.Window;
                return;
            };
            DisableSearchBox();
            OnRoomTypeFilterChange?.Invoke(this, EventArgs.Empty);
        }

        private void DisableSearchBox()
        {
            txtRoomTypeSearch.Text = "Search...";
            txtRoomTypeSearch.Enabled = false;
            txtRoomTypeSearch.BackColor = SystemColors.Window;
        }

        private void HandleCurrentUserPermisstion()
        {
            if (CurrentUserRole == StaffRole.MANAGER)
            {
                btnRoomTypeCreateViewOpen.Visible = true;
                btnRoomTypeUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.RECEPTIONIST)
            {
                btnRoomTypeCreateViewOpen.Visible = true;
                btnRoomTypeUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.HOUSEKEEPER)
            {
                btnRoomTypeCreateViewOpen.Visible = false;
                btnRoomTypeUpdateViewOpen.Visible = false;
            }
            if (CurrentUserRole == StaffRole.ADMIN)
            {
                btnRoomTypeCreateViewOpen.Visible = false;
                btnRoomTypeUpdateViewOpen.Visible = false;
            }
        }

        public void SetupRoomTypeGridView(BindingSource bindingSource)
        {
            grvRoomType.DataSource = bindingSource;
        }

        public void SetupRoomTypeSearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbRoomTypeSearchField.DataSource = bindingSource;
            cbbRoomTypeSearchField.DisplayMember = displayMember;
            cbbRoomTypeSearchField.ValueMember = valueMember;
        }

        public void SetupRoomTypePageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbRoomTypePageSize.DataSource = bindingSource;
            cbbRoomTypePageSize.DisplayMember = displayMember;
            cbbRoomTypePageSize.ValueMember = valueMember;
        }
    }
}
