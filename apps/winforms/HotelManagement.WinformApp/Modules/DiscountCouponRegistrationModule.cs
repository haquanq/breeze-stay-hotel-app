using Autofac;
using HotelManagement.Domain.Repositories.DiscountCoupon;
using HotelManagement.Domain.Services.DiscountCoupon;
using HotelManagement.WinformApp.Presenters.DiscountCoupon;
using HotelManagement.WinformApp.Views.DiscountCoupon;

namespace HotelManagement.Modules
{
    public class DiscountCouponRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DiscountCouponRepository>().As<IDiscountCouponRepository>().SingleInstance();
            builder.RegisterType<DiscountCouponService>().As<IDiscountCouponService>().SingleInstance();

            builder.RegisterType<DiscountCouponPresenter>();
            builder.RegisterType<DiscountCouponAddPresenter>();
            builder.RegisterType<DiscountCouponUpdatePresenter>();

            builder.RegisterType<DiscountCouponView>().As<IDiscountCouponView>();
            builder.RegisterType<DiscountCouponAddView>().As<IDiscountCouponAddView>();
            builder.RegisterType<DiscountCouponUpdateView>().As<IDiscountCouponUpdateView>();
        }
    }
}
