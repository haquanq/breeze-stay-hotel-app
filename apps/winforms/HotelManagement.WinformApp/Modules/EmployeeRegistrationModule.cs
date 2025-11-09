using Autofac;
using HotelManagement.Domain.Repositories.Staff;
using HotelManagement.Domain.Services.Staff;
using HotelManagement.WinformApp.Presenters.Staff;
using HotelManagement.WinformApp.Views.Staff;

namespace HotelManagement.Modules
{
    public class EmployeeRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>().SingleInstance();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>().SingleInstance();

            builder.RegisterType<EmployeePresenter>();
            builder.RegisterType<EmployeeAddPresenter>();
            builder.RegisterType<EmployeeUpdatePresenter>();

            builder.RegisterType<EmployeeView>().As<IEmployeeView>();
            builder.RegisterType<EmployeeAddView>().As<IEmployeeAddView>();
            builder.RegisterType<EmployeeUpdateView>().As<IEmployeeUpdateView>();
        }
    }
}
