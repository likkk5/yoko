using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yoko.Data
{
    public class YoGuest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PassportNumber { get; set; }
        public string Residence { get; set; }
        public List<YoReservation> ReservationList { get; set; }
        //public List<YoOrder> OrderList { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}
