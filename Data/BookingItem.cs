namespace Data;

public class BookingItem
{
    public int Id { get; set; }
    public int BookingId { get; set; }
    public virtual Booking Booking { get; set; } = null!;
    public int DailyMenuItemId { get; set; }
    public virtual DailyMenuItem DailyMenuItem { get; set; } = null!;
    public int Quantity { get; set; }
}