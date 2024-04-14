using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace yoko.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<YoService> YoServices { get; set; }
        public DbSet<YoRoom> YoRooms { get; set; }
        public DbSet<YoGuest> YoGuests { get; set; }
        public DbSet<YoReservation> YoReservations { get; set; }
        public DbSet<YoFeedback> YoFeedbacks { get; set; }
        public DbSet<YoOrder> YoOrders { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<YoOrder>().HasOne(p => p.Id).WithMany(b => b.ServiceId)
        //   .HasForeignKey(p => p.EmployeeId)
        //   .OnDelete(DeleteBehavior.Cascade);
        //}
        public DbSet<YoNotification> YoNotifications { get; set; }
        public DbSet<YoServiceinOrder> YoServiceinOrders { get; set; }

    }
}
