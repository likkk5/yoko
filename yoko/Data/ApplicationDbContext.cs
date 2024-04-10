using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace yoko.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<YoService> YoServices { get; set; }
        public DbSet<YoRoom> YoRooms { get; set; }
        public DbSet<YoGuest> YoGuests { get; set; }
        public DbSet<YoReservation> YoReservations { get; set; }
    }
}
