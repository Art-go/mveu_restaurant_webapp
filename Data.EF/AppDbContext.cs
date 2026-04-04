using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.EF;

public class AppDbContext: IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) { }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<DailyMenu> DailyMenus { get; set; }
    public DbSet<DailyMenuItem> DailyMenuItems { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<BookingItem> BookingItems { get; set; }
    public DbSet<Feedback>  Feedbacks { get; set; }
    public DbSet<Favorite> Favorites { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<Category>()
            .Property(c => c.Name)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Entity<Dish>()
            .Property(d => d.Name)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Entity<Dish>()
            .Property(d => d.Description)
            .HasMaxLength(100)
            .IsRequired();

        builder.Entity<Dish>()
            .Property(d => d.Price)
            .HasPrecision(10, 2)
            .IsRequired();

        builder.Entity<DailyMenu>()
            .HasIndex(dm => dm.Date)
            .IsUnique();
        
        builder.Entity<DailyMenuItem>()
            .HasIndex(dmi => new { dmi.DailyMenuId, dmi.DishId })
            .IsUnique();
        
        builder.Entity<Booking>()
            .Property(b => b.Date)
            .HasComputedColumnSql("CAST(BookingDateTime AS DATE)");
        
        builder.Entity<Booking>()
            .HasIndex(b => new { b.ConfirmationCode, b.Date })
            .IsUnique();
        
        builder.Entity<Favorite>()
            .HasKey(f => new {f.UserId, f.DishId});
        
        
        
        builder.Entity<DailyMenuItem>()
            .HasOne(dmi => dmi.Menu)
            .WithMany(dm => dm.Items)
            .HasForeignKey(dmi => dmi.DailyMenuId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Entity<DailyMenuItem>()
            .HasOne(dmi => dmi.Dish)
            .WithMany(d => d.DailyMenuItems)
            .HasForeignKey(dmi => dmi.DishId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.Entity<BookingItem>()
            .HasOne(bi => bi.Booking)
            .WithMany(b => b.Items)
            .HasForeignKey(bi => bi.BookingId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}