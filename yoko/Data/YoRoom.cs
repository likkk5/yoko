using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace yoko.Data
{
    public class YoRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public double CostForNight { get; set; }
        public RoomType RoomType { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public byte[]? Photo { get; set; }
    }
    public enum RoomType
    {
        Standart,
        Superior,
        Bedroom,
        Apartment,
        Studio,
        Suite
    }
    public enum RoomStatus
    {
        Free,
        InUse,
        OnCleaning
    }
}
