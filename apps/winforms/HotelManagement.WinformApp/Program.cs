using Autofac;
using Bogus;
using HotelManagement.Domain.Dtos.Amenity;
using HotelManagement.Domain.Dtos.Customer;
using HotelManagement.Domain.Enums;
using HotelManagement.Domain.Repositories.Amenity;
using HotelManagement.Domain.Repositories.Customer;
using HotelManagement.Infrastructure.Database;
using HotelManagement.Infrastructure.Extentions;
using HotelManagement.Modules;
using HotelManagement.Presenters.Main;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.WinformApp
{
    public static class Program
    {
        private static IContainer _contextContainer;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegisterDependencies();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            using (var scope = _contextContainer.BeginLifetimeScope())
            {
                var p = scope.Resolve<MainPresenter>();
                Application.Run((Form)p.GetView());
            }
        }

        /// <summary>
        /// Perform dependencies registration (IoC) using AutoFac.
        /// </summary>
        private static void RegisterDependencies()
        {

            var builder = new ContainerBuilder();

            builder.RegisterType<DbConnectionFactory>().As<IDbConnectionFactory>().SingleInstance();
            builder.RegisterType<DbParameterFactory>().As<IDbParameterFactory>().SingleInstance();

            builder.RegisterModule(new MainRegistrationModule());
            builder.RegisterModule(new AmenityRegistrationModule());
            builder.RegisterModule(new HotelServiceRegistrationModule());
            builder.RegisterModule(new CustomerRegistrationModule());
            builder.RegisterModule(new RoomTypeRegistrationModule());
            builder.RegisterModule(new DiscountCouponRegistrationModule());
            builder.RegisterModule(new EmployeeRegistrationModule());

            _contextContainer = builder.Build();
        }

        private async static void SeedAmenity()
        {
            var repo = _contextContainer.Resolve<IAmenityRepository>();

            var data = new List<AmenityCreateDto>();

            var fakeAmenity = new Faker<AmenityCreateDto>()
                    .RuleFor(u => u.Title, (f) => f.Commerce.Product() + f.Commerce.ProductName())
                    .RuleFor(u => u.Detail, (f) => f.Lorem.Paragraph())
                    .RuleFor(u => u.Price, (f) => f.Random.Number())
                    .RuleFor(u => u.Status, (f) => f.PickRandom<AmenityStatus>());

            9999.Repeat(() =>
            {
                data.Add(fakeAmenity.Generate());
            });

            await repo.InsertMany(data);
        }

        private async static void SeedCustomer()
        {
            var repo = _contextContainer.Resolve<ICustomerRepository>();

            var data = new List<CustomerCreateDto>();

            var fakeAmenity = new Faker<CustomerCreateDto>(locale: "vi")
                    .RuleFor(u => u.FirstName, (f) => f.Person.FirstName)
                    .RuleFor(u => u.LastName, (f) => f.Person.LastName)
                    .RuleFor(u => u.CitizenIdNumber, (f) => f.Random.Guid().ToString())
                    .RuleFor(u => u.Phone, (f) => f.Person.Phone.Replace(" ", ""))
                    .RuleFor(u => u.Email, (f) => f.Person.Email)
                    .RuleFor(u => u.Address1, (f) => f.Person.Address.Street)
                    .RuleFor(u => u.Address2, (f) => f.Person.Address.Street)
                    .RuleFor(u => u.Status, (f) => f.PickRandom<CustomerStatus>());

            9999.Repeat(() =>
            {
                data.Add(fakeAmenity.Generate());
            });

            await repo.InsertMany(data);
        }
    }
}
