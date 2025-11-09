using System;

namespace HotelManagement.WinformApp.Views.Main
{
    public interface ILoginView
    {
        string Email { get; set; }
        string Password { get; set; }

        event EventHandler OnLogin;
        event EventHandler OnExit;
    }
}
