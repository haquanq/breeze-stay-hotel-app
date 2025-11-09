using HotelManagement.Domain.Dtos.Auth;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Main
{
    public partial class LoginView : Form, ILoginView
    {

        public static CurrentUserDto currentUser = new CurrentUserDto();

        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public event EventHandler OnLogin;
        public event EventHandler OnExit;

        public LoginView()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 30;

            btnLogin.Click += delegate { OnLogin?.Invoke(this, EventArgs.Empty); };
            btnExit.Click += delegate { OnExit?.Invoke(this, EventArgs.Empty); };
        }
    }
}
