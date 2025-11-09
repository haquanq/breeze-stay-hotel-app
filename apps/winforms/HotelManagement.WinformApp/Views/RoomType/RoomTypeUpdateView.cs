using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.RoomType
{
    public partial class RoomTypeUpdateView : Form, IRoomTypeUpdateView
    {
        public string RoomTypeId { get; set; }
        public string RoomTypeTitle
        {
            get => txtTitle.Text;
            set => txtTitle.Text = value;
        }
        public string RoomTypeDetail
        {
            get => txtDetail.Text;
            set => txtDetail.Text = value;
        }
        public decimal RoomTypePricePerNight
        {
            get => numPricePerNight.Value; set =>
                numPricePerNight.Value = value;
        }

        private DateTime _roomTypeCreatedAt;
        public DateTime RoomTypeCreatedAt
        {
            get => _roomTypeCreatedAt;
            set
            {
                _roomTypeCreatedAt = value;
                lblCreatedAt.Text = $"Created at: {value:dd-MM-yyyy hh:mm tt}";
            }
        }
        private DateTime _roomTypeUpdatedAt;
        public DateTime RoomTypeUpdatedAt
        {
            get => _roomTypeUpdatedAt;
            set
            {
                _roomTypeUpdatedAt = value;
                lblUpdatedAt.Text = $"Created at: {value:dd-MM-yyyy hh:mm tt}";
            }
        }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnRoomTypeSave;
        public event EventHandler OnRoomTypeDelete;
        public event EventHandler OnCancel;

        public RoomTypeUpdateView()
        {
            InitializeComponent();
            numPricePerNight.Maximum = 99999999;
            numPricePerNight.Increment = 100000;

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnRoomTypeSave.Click += delegate { OnRoomTypeSave?.Invoke(this, EventArgs.Empty); };
            btnRoomTypeDelete.Click += delegate { OnRoomTypeDelete?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
        }
    }
}
