using HotelManagement.WinformApp.Views.Main;
using HotelManagement.Domain.Services.Auth;
using System;
using System.Windows.Forms;
using HotelManagement.Domain.Dtos.Auth;

namespace HotelManagement.Presenters.Main
{
    public class LoginPresenter
    {
        private readonly ILoginView _loginView;
        private readonly IAuthService _authService;

        public LoginPresenter(ILoginView loginView, IAuthService authService)
        {
            /// injected
            _loginView = loginView;
            _authService = authService;

            /// events
            _loginView.OnLogin += HandleLogin;
            _loginView.OnExit += HandleExit;
        }

        /// <summary>
        /// Private method for handling LoginView events
        /// </summary>
        private void HandleExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HandleLogin(object sender, EventArgs e)
        {
            ProcessLogin();
        }

        /// <summary>
        /// Public method for handling LoginView logic
        /// </summary>
        public async void ProcessLogin()
        {
            var payload = new UserLoginDto()
            {
                Email = _loginView.Email,
                Password = _loginView.Password,
            };
            var currentUser = await _authService.Login(payload);
        }
    }
}
