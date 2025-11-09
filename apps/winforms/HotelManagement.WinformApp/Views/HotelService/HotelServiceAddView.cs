using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.HotelService
{
    public partial class HotelServiceAddView : Form, IHotelServiceAddView
    {
        public string HotelServiceTitle
        {
            get => txtHotelServiceTitle.Text;
            set => txtHotelServiceTitle.Text = value;
        }
        public string HotelServiceDetail
        {
            get => txtHotelServiceDetail.Text;
            set => txtHotelServiceDetail.Text = value;
        }

        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public event EventHandler OnCancel;
        public event EventHandler OnHotelServiceAdd;

        public HotelServiceAddView()
        {
            InitializeComponent();

            Load += delegate { OnAmenityViewLoad?.Invoke(this, EventArgs.Empty); };
            btnHotelServiceAdd.Click += delegate { OnHotelServiceAdd?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };

        }
    }
}
