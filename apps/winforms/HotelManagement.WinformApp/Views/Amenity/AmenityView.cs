using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Configs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Amenity
{
    public partial class AmenityView : Form, IAmenityView

    {
        public StaffRole CurrentUserRole { get; set; }
        public string SelectedAmenityId
        {
            get
            {
                if (grvAmenity.CurrentRow == null) return null;
                return grvAmenity.CurrentRow.Cells["AmenityId"].Value.ToString();
            }
        }
        public AmenityStatus SelectedAmenityStatus { get => (AmenityStatus)cbbAmenityStatus.SelectedValue; }
        public string SelectedAmenitySearchField { get => (string)cbbAmenitySearchField.SelectedValue; }
        public bool UsingFilterAmenityStatus { get => cbbAmenityStatus.SelectedIndex > 0; }
        public bool UsingFilterAmenitySearchField { get => cbbAmenitySearchField.SelectedIndex > 0; }
        public string AmenitySearchText { get => txtAmenitySearch.Text; }
        public int AmenityPageCount { get => pgnAmenityView.TotalPages; set => pgnAmenityView.TotalPages = value; }
        public int AmenityPageNumber { get => pgnAmenityView.CurrentPage; set => pgnAmenityView.CurrentPage = value; }
        public int AmenityPageSize { get => pgnAmenityView.TotalPages; set => pgnAmenityView.TotalPages = value; }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnAmenityFilterChange;
        public event EventHandler OnAmenitySearchFieldChange;
        public event EventHandler OnAmenityPaginationChange;
        public event EventHandler OnAmenityCreateViewOpen;
        public event EventHandler OnAmenityUpdateViewOpen;

        public void SetupAmenityGridView(BindingSource bindingSource)
        {
            grvAmenity.DataSource = bindingSource;
        }

        public void SetupAmenitySearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbAmenitySearchField.DataSource = bindingSource;
            cbbAmenitySearchField.DisplayMember = displayMember;
            cbbAmenitySearchField.ValueMember = valueMember;
        }

        public void SetupAmenityStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbAmenityStatus.DataSource = bindingSource;
            cbbAmenityStatus.DisplayMember = displayMember;
            cbbAmenityStatus.ValueMember = valueMember;
        }

        public void SetupAmenityPageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbAmenityPageSize.DataSource = bindingSource;
            cbbAmenityPageSize.DisplayMember = displayMember;
            cbbAmenityPageSize.ValueMember = valueMember;
        }

        public void SetupAmenitySearchTextBox(Binding binding)
        {
            txtAmenitySearch.DataBindings.Clear();
            txtAmenitySearch.DataBindings.Add(binding);
        }


        public AmenityView()
        {
            InitializeComponent();
            DisableSearchBox();

            grvAmenity.Columns["Price"].DefaultCellStyle.Format = "##,0";
            grvAmenity.Columns["CreatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvAmenity.Columns["UpdatedAt"].DefaultCellStyle.Format = "dd-MM-yyyy";

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnAmenityCreateViewOpen.Click += delegate { OnAmenityCreateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnAmenityUpdateViewOpen.Click += delegate { OnAmenityUpdateViewOpen?.Invoke(this, EventArgs.Empty); };
            btnAmenitySearch.Click += delegate { OnAmenityFilterChange?.Invoke(this, EventArgs.Empty); };

            cbbAmenitySearchField.SelectionChangeCommitted += delegate { HandleSelectedSearchFieldSelectionChange(); };
            cbbAmenityStatus.SelectionChangeCommitted += delegate { OnAmenityFilterChange?.Invoke(this, EventArgs.Empty); };

            pgnAmenityView.OnPaginationChange += delegate { OnAmenityPaginationChange?.Invoke(this, EventArgs.Empty); };
            grvAmenity.CellPainting += delegate { PaintAmenityStatusColor(); };

        }

        private void HandleSelectedSearchFieldSelectionChange()
        {
            if (UsingFilterAmenitySearchField)
            {
                txtAmenitySearch.Enabled = true;
                txtAmenitySearch.Text = "";
                txtAmenitySearch.BackColor = SystemColors.Window;
                return;
            };
            DisableSearchBox();
            OnAmenitySearchFieldChange?.Invoke(this, EventArgs.Empty);
        }

        private void DisableSearchBox()
        {
            txtAmenitySearch.Text = "Search...";
            txtAmenitySearch.Enabled = false;
            txtAmenitySearch.BackColor = SystemColors.Window;
            txtAmenitySearch.DataBindings.Clear();
        }

        private void PaintAmenityStatusColor()
        {
            foreach (DataGridViewRow row in grvAmenity.Rows)
            {
                bool isValid = Enum.TryParse(row.Cells["status"].Value.ToString(), out AmenityStatus status);
                if (!isValid) return;

                row.Cells["Status"].Style.BackColor = ColorTranslator.FromHtml(AmenityViewConfig.StatusColor[status].DarkHex);
                row.Cells["Status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
            }
        }

        private void HandleCurrentUserPermission()
        {
            if (CurrentUserRole == StaffRole.MANAGER)
            {
                btnAmenityCreateViewOpen.Visible = true;
                btnAmenityUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.RECEPTIONIST)
            {
                btnAmenityCreateViewOpen.Visible = true;
                btnAmenityUpdateViewOpen.Visible = true;
            }
            if (CurrentUserRole == StaffRole.HOUSEKEEPER)
            {
                btnAmenityCreateViewOpen.Visible = false;
                btnAmenityUpdateViewOpen.Visible = false;
            }
            if (CurrentUserRole == StaffRole.ADMIN)
            {
                btnAmenityCreateViewOpen.Visible = false;
                btnAmenityUpdateViewOpen.Visible = false;
            }
        }

    }
}
