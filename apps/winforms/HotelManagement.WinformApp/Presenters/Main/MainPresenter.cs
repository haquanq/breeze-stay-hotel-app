using HotelManagement.Domain.Dtos.Auth;
using HotelManagement.WinformApp.Enums;
using HotelManagement.WinformApp.Presenters.Customer;
using HotelManagement.WinformApp.Presenters.DiscountCoupon;
using HotelManagement.WinformApp.Views.Main;
using System;

namespace HotelManagement.Presenters.Main
{
    public class MainPresenter
    {
        public static MainPresenter Instance;
        public CurrentUserDto CurrentUser;

        private readonly IMainView _mainView;
        private readonly Func<DiscountCouponPresenter> _discountCouponPresenterFactory;
        private readonly Func<CustomerPresenter> _customerPresenterFactory;

        public MainPresenter(
            IMainView mainView,
            Func<DiscountCouponPresenter> discountCouponPresenterFactory,
            Func<CustomerPresenter> customerPresenterFactory
            )
        {
            Instance = this;

            /// injected
            _mainView = mainView;
            _discountCouponPresenterFactory = discountCouponPresenterFactory;
            _customerPresenterFactory = customerPresenterFactory;

            /// events
            _mainView.OnDiscountCouponViewOpen += HandleDiscountCouponViewOpen;
            _mainView.OnCustomerViewOpen += HandleCustomerViewOpen;
        }

        private void HandleDiscountCouponViewOpen(object sender, EventArgs e)
        {
            var p = _discountCouponPresenterFactory();
            _mainView.CurrentView = p.GetViewInstance();
        }

        private void HandleCustomerViewOpen(object sender, EventArgs e)
        {
            var p = _customerPresenterFactory();
            _mainView.CurrentView = p.GetView();
        }

        public void ShowView()
        {
            _mainView.Show();
        }

        public IMainView GetView() { return _mainView; }

        public bool ShowMessage(MessageType type, string content, string title = null)
        {
            return _mainView.ShowMessage(type, content, title);
        }
    }
}
