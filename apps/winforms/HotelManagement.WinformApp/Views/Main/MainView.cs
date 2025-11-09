using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using HotelManagement.WinformApp.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Main
{
    public partial class MainView : Form, IMainView
    {
        private IView _currentView;
        public IView CurrentView
        {
            get => _currentView; set
            {
                _currentView?.Close();
                _currentView = value;
                LoadView(value);
            }
        }
        public StaffRole CurrentUserRole { get; set; }


        public event EventHandler OnAmenityViewOpen;
        public event EventHandler OnCustomerViewOpen;
        public event EventHandler OnStaffViewOpen;
        public event EventHandler OnDiscountCouponViewOpen;
        public event EventHandler OnAmenityViewLoad;
        public event EventHandler OnAmenityViewDisposed;
        public MainView()
        {
            InitializeComponent();

            DoubleBuffered = true;


            btnDiscountCoupon.Click += delegate { OnDiscountCouponViewOpen?.Invoke(this, EventArgs.Empty); HandleButtonSelectionChange(btnDiscountCoupon); };
            btnCustomer.Click += delegate { OnCustomerViewOpen?.Invoke(this, EventArgs.Empty); HandleButtonSelectionChange(btnCustomer); };
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            string name = LoginView.currentUser.FullName;
            string role = LoginView.currentUser.Role.ToString();
            string de = LoginView.currentUser.Phone;
            lblAccount.Text = $"{name}\n{role}\n{de}";
        }

        private void HandlePermission()
        {
            if (CurrentUserRole == StaffRole.MANAGER)
            {
                btnReport.Visible = true;
                btnStaff.Visible = true;
            }
            if (CurrentUserRole == StaffRole.RECEPTIONIST)
            {
                btnReport.Visible = true;
                btnStaff.Visible = true;
            }
            if (CurrentUserRole == StaffRole.HOUSEKEEPER)
            {
                btnReport.Visible = false;
                btnStaff.Visible = false;
            }

            if (CurrentUserRole == StaffRole.ADMIN)
            {
                btnReport.Visible = false;
                btnStaff.Visible = true;
            }
        }

        private void LoadView(IView nextView)
        {
            Container.Controls.Clear();
            var f = (Form)nextView;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;

            nextView.Show();
            Container.Controls.Add(f);
        }

        private void HandleButtonSelectionChange(Button btn)
        {
            foreach (Control c in pnHomeMenu.Controls)
            {
                c.BackColor = Color.SteelBlue;
                c.Enabled = true;
            }
            btn.BackColor = SystemColors.Control;
            btn.Enabled = false;
        }

        public bool ShowMessage(MessageType type, string content, string title = null)
        {
            var icon = MessageBoxIcon.None;
            var button = MessageBoxButtons.OK;
            if (type == MessageType.INFO) { icon = MessageBoxIcon.Information; if (title == null) title = "Informatin"; }
            if (type == MessageType.ERROR) { icon = MessageBoxIcon.Error; if (title == null) title = "Error"; }
            if (type == MessageType.WARN) { icon = MessageBoxIcon.Warning; if (title == null) title = "Warning"; }
            if (type == MessageType.ASK) { icon = MessageBoxIcon.Question; button = MessageBoxButtons.YesNo; if (title == null) title = "Question"; }
            var res = MessageBox.Show(content, title, button, icon);
            if (res == DialogResult.Yes) return true;
            if (res == DialogResult.No) return false;
            return false;
        }
    }
}
