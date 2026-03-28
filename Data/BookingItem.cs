namespace Data;

public class BookingItem
{
    public int Id { get; set; }
    public virtual Booking Booking { get; set; }
    public virtual DailyMenuItem DailyMenuItem { get; set; }
    // public int Quantity { get; set; }
}