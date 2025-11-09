using HotelManagement.Domain.Enums;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Amenity
{
    public partial class AmenityUpdateView : Form, IAmenityUpdateView
    {
        private string _amenityId;
        public string AmenityId { get => _amenityId; set { lblAmenityId.Text = value; _amenityId = value; } }
        public string AmenityTitle { get => txtAmenityTitle.Text; set => txtAmenityTitle.Text = value; }
        public string AmenityDetail { get => txtAmenityDetail.Text; set => txtAmenityDetail.Text = value; }
        public decimal AmenityPrice { get => numAmenityPrice.Value; set => numAmenityPrice.Value = value; }
        public AmenityStatus AmenityStatus { get => (AmenityStatus)cbbAmenityStatus.SelectedValue; set => cbbAmenityStatus.SelectedValue = value; }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnAmenitySave;
        public event EventHandler OnAmenityDelete;
        public event EventHandler OnCancel;

        public AmenityUpdateView()
        {
            InitializeComponent();

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnAmenitySave.Click += delegate { OnAmenitySave?.Invoke(this, EventArgs.Empty); };
            btnAmenityDelete.Click += delegate { OnAmenityDelete?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
        }

        public void SetupAmenityStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbAmenityStatus.DataSource = bindingSource;
            cbbAmenityStatus.DisplayMember = displayMember;
            cbbAmenityStatus.ValueMember = valueMember;
        }
    }
}
