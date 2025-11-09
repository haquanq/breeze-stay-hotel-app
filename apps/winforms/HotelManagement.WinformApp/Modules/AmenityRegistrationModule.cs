using Autofac;
using HotelManagement.Domain.Repositories.Amenity;
using HotelManagement.Domain.Services.Amenity;
using HotelManagement.WinformApp.Presenters.Amenity;
using HotelManagement.WinformApp.Views.Amenity;

namespace HotelManagement.Modules
{
    public class AmenityRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AmenityRepository>().As<IAmenityRepository>().SingleInstance();
            builder.RegisterType<AmenityService>().As<IAmenityService>().SingleInstance();

            builder.RegisterType<AmenityView>().As<IAmenityView>();
            builder.RegisterType<AmenityAddView>().As<IAmenityAddView>();
            builder.RegisterType<AmenityUpdateView>().As<IAmenityUpdateView>();

            builder.RegisterType<AmenityPresenter>();
            builder.RegisterType<AmenityAddPresenter>();
            builder.RegisterType<AmenityUpdatePresenter>();
        }
    }
}
