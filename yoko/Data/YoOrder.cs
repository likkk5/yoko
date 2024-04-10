using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace yoko.Data
{
    //public class YoOrder
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }
    //    public DateTime OrderDate { get; set; }
    //    public int ReservationId { get; set; }
    //    public List<YoService> ServicesInOrder { get; set; }
    //    public string OrderStatus { get; set; }
    //    public int NotificationId { get; set; } 
    //    public int EmployeeId { get; set; }
    //    public double Cost { get; set; }

    //    // Добавьте внешний ключ для связи с соответствующими классами, если это необходимо
    //    [ForeignKey("ReservationId")]
    //    public virtual YoReservation Reservation { get; set; }

    //    [ForeignKey("NotificationId")]
    //    public virtual YoNotification Notification { get; set; }

    //    [ForeignKey("EmployeeId")]
    //    public virtual ApplicationUser Employee { get; set; }
    //}
}
