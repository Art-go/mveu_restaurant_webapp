namespace Data;

public class Booking
{
    public int Id { get; set; }
    public virtual User User { get; set; }
    public DateTime Timestamp { get; set; }
    public DateTime Expiration { get; set; }
    public BookingStatus Status { get; set; }
    public string ConfirmationCode { get; set; }
    public virtual ICollection<BookingItem> Items { get; }
}