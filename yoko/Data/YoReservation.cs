using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yoko.Data
{
    public class YoReservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string RoomNumber { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public double Cost { get; set; }
        public int GuestId { get; set; }

        [ForeignKey("GuestId")]
        public virtual YoGuest Guest { get; set; }

    }
    public enum ReservationStatus
    {
        Unpaid,
        Paid,
        Canceled
    }
}
