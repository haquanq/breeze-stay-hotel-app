namespace HotelManagement.Domain.Models
{
    public class ReservationRoomModel
    {
        public string ReservationRoomId { get; set; }
        public ReservationModel Reservation { get; set; }
        public RoomModel Room { get; set; }
        public decimal PricePerNight { get; set; }
    }
}
