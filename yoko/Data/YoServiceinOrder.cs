using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace yoko.Data
{
    public class YoServiceinOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int OrderId { get; set; }
        public string? EmployeeId { get; set; }
        public int Amount { get; set; }

        [ForeignKey("ServiceId")]
        public virtual YoService YoService { get; set; }

        [ForeignKey("OrderId")]
        public virtual YoOrder Order { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual ApplicationUser Employee { get; set; }
    }
}
