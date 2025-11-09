using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Room
{
    public partial class RoomAddView : Form, IRoomAddView
    {
        public string RoomCode { get => txtRoomCode.Text; set => txtRoomCode.Text = value; }
        public string RoomTypeId { get => (string)cbbRoomType.SelectedValue; set => cbbRoomType.SelectedValue = value; }
        public int FloorNumber { get => (int)txtRoomFloorNumber.Value; set => txtRoomFloorNumber.Value = value; }
        public string SelectedAmenityId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler OnAmenitySearchChange;
        public event EventHandler OnRoomAmenityAdd;
        public event EventHandler OnRoomAmenityRemove;
        public event EventHandler OnRoomAdd;
        public event EventHandler OnCancel;
        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnViewShown;
        public event EventHandler OnAmenityViewDisposed;

        public void SetupRoomAmenityGridView(BindingSource bindingSource)
        {
            grvRoomAmenity.DataSource = bindingSource;
        }

        public void SetupRoomTypeComboBox(BindingSource bindingSource, string displayMember, string valueMember)
        {
            cbbRoomType.DataSource = bindingSource;
            cbbRoomType.DisplayMember = displayMember;
            cbbRoomType.ValueMember = valueMember;
        }

        public RoomAddView()
        {
            InitializeComponent();

            btnCancel.Click += delegate { OnCancel?.Invoke(this, EventArgs.Empty); };
            btnRoomAdd.Click += delegate { OnRoomAdd?.Invoke(this, EventArgs.Empty); };
            btnRoomAmenityAdd.Click += delegate { OnRoomAmenityAdd?.Invoke(this, EventArgs.Empty); };
            btnRoomAmenityRemove.Click += delegate { OnRoomAmenityRemove?.Invoke(this, EventArgs.Empty); };
        }

    }
}
