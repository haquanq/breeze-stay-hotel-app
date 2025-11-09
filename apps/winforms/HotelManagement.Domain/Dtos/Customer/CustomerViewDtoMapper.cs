using HotelManagement.Domain.Models;
using System;

namespace HotelManagement.Domain.Dtos.Customer
{
    public class CustomerViewDtoMapper
    {
        public static Converter<CustomerModel, CustomerViewDto> Map = (model) =>
        {
            return new CustomerViewDto
            {
                CustomerId = model.CustomerId,
                CitizenIdNumber = model.CitizenIdNumber,
                FullName = model.FirstName + " " + model.LastName,
                Phone = model.Phone,
                Email = model.Email,
                Address1 = model.Address1,
                Address2 = model.Address2,
                Status = model.Status,
                CreatedAt = model.CreatedAt,
                UpdatedAt = model.UpdatedAt
            };
        };

    }
}
