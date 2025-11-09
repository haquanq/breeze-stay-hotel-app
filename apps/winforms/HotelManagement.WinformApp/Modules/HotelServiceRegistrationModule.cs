using Autofac;
using HotelManagement.Domain.Repositories.HotelService;
using HotelManagement.Domain.Services.HotelService;
using HotelManagement.Infrastructure.Repositories.HotelService;
using HotelManagement.WinformApp.Presenters.HotelService;
using HotelManagement.WinformApp.Views.HotelService;

namespace HotelManagement.Modules
{
    public class HotelServiceRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HotelServiceRepository>().As<IHotelServiceRepository>().SingleInstance();
            builder.RegisterType<HotelServiceService>().As<IHotelServiceService>().SingleInstance();

            builder.RegisterType<HotelServiceView>().As<IHotelServiceView>();
            builder.RegisterType<HotelServiceAddView>().As<IHotelServiceAddView>();
            builder.RegisterType<HotelServiceUpdateView>().As<IHotelServiceUpdateView>();

            builder.RegisterType<HotelServicePresenter>();
            builder.RegisterType<HotelServiceCreatePresenter>();
            builder.RegisterType<HotelServiceUpdatePresenter>();
        }
    }
}
