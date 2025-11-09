using Autofac;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Views.Main;

namespace HotelManagement.Modules
{
    public class MainRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<MainPresenter>();

            builder.RegisterType<MainView>().As<IMainView>();
        }
    }
}
