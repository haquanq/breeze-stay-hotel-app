using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.RoomType
{
    public partial class RoomTypeAddView : Form, IRoomTypeAddView
    {
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

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnRoomTypeAdd;
        public event EventHandler OnCancel;

        public RoomTypeAddView()
        {
            InitializeComponent();
            numPricePerNight.Maximum = 99999999;
            numPricePerNight.Increment = 100000;

            btnAdd.Click += delegate { OnRoomTypeAdd?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
        }
    }
}
