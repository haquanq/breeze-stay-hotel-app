using HotelManagement.Domain.Models;
using System;

namespace HotelManagement.Domain.Dtos
{
    public static class StaffViewDtoMapper
    {
        public static Converter<StaffModel, StaffViewDto> Map = (model) =>
        {
            return new StaffViewDto
            {
                StaffId = model.StaffId,
                Dob = model.Dob,
                Email = model.Email,
                FullName = model.FirstName + " " + model.LastName,
                Phone = model.Phone,
                Role = model.Role,
                AccountStatus = model.AccountStatus,
                CreatedAt = model.CreatedAt,
                UpdatedAt = model.UpdatedAt
            };
        };
    }
}
