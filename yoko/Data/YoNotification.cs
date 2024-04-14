using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yoko.Data
{
    public class YoNotification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime NotificationDateTime { get; set; }
        //public TimeSpan NotificationTime { get; set; }
        public string NotificationText { get; set; }

        [ForeignKey("OrderId")]
        public virtual YoOrder Order { get; set; }
    }
}
