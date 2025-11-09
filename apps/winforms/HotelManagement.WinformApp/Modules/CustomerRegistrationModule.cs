using Autofac;
using FluentValidation;
using HotelManagement.Domain.Dtos.Customer;
using HotelManagement.Domain.Repositories.Customer;
using HotelManagement.Domain.Services.Customer;
using HotelManagement.Domain.Validators.Customer;
using HotelManagement.WinformApp.Presenters.Customer;
using HotelManagement.WinformApp.Views.Customer;

namespace HotelManagement.Modules
{
    public class CustomerRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerUpdateDtoValidator>().As<IValidator<CustomerUpdateDto>>();
            builder.RegisterType<CustomerCreateDtoValidator>().As<IValidator<CustomerCreateDto>>();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().SingleInstance();
            builder.RegisterType<CustomerService>().As<ICustomerService>().SingleInstance();

            builder.RegisterType<CustomerPresenter>();
            builder.RegisterType<CustomerAddPresenter>();
            builder.RegisterType<CustomerUpdatePresenter>();

            builder.RegisterType<CustomerView>().As<ICustomerView>();
            builder.RegisterType<CustomerAddView>().As<ICustomerAddView>();
            builder.RegisterType<CustomerUpdateView>().As<ICustomerUpdateView>();
        }
    }
}
