using System;

namespace HotelManagement.Views.Abstracts
{
    public interface IView : IDisposable
    {
        event EventHandler OnAmenityViewLoad;
        event EventHandler OnAmenityViewDisposed;
        void Show();
        void Hide();
        void Close();
    }
}
