
namespace HotelManagement.Domain.Dtos.Reservation
{
    public class ReservationSearchDto
    {
        public string ReservationId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string StaffId { get; set; }
        public string StaffName { get; set; }
    }
}
