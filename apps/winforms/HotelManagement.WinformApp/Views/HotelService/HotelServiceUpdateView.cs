using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.HotelService
{
    public partial class HotelServiceUpdateView : Form, IHotelServiceUpdateView
    {
        private string _hotelServiceId;
        public string HotelServiceId { get => _hotelServiceId; set { lblHotelServiceId.Text = value; _hotelServiceId = value; } }
        public string HotelServiceTitle { get => txtHotelServiceTitle.Text; set => txtHotelServiceTitle.Text = value; }
        public string HotelServiceDetail { get => txtHotelServiceDetail.Text; set => txtHotelServiceDetail.Text = value; }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnHotelServiceSave;
        public event EventHandler OnHotelServiceDelete;
        public event EventHandler OnCancel;

        public HotelServiceUpdateView()
        {
            InitializeComponent();

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnHotelServiceSave.Click += delegate { OnHotelServiceSave?.Invoke(this, EventArgs.Empty); };
            btnHotelServiceDelete.Click += delegate { OnHotelServiceDelete?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
        }
    }
}
