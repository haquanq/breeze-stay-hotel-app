using Autofac;
using HotelManagement.Domain.Repositories.RoomType;
using HotelManagement.Domain.Services.RoomType;
using HotelManagement.WinformApp.Presenters.RoomType;
using HotelManagement.WinformApp.Views.RoomType;

namespace HotelManagement.Modules
{
    public class RoomTypeRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RoomTypeRepository>().As<IRoomTypeRepository>().SingleInstance();
            builder.RegisterType<RoomTypeService>().As<IRoomTypeService>().SingleInstance();

            builder.RegisterType<RoomTypePresenter>();
            builder.RegisterType<RoomTypeCreatePresenter>();
            builder.RegisterType<RoomTypeUpdatePresenter>();

            builder.RegisterType<RoomTypeView>().As<IRoomTypeView>();
            builder.RegisterType<RoomTypeAddView>().As<IRoomTypeAddView>();
            builder.RegisterType<RoomTypeUpdateView>().As<IRoomTypeUpdateView>();
        }
    }
}
