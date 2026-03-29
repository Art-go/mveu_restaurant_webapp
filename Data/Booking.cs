namespace Data;

public class Booking
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    public DateTime Timestamp { get; set; }
    public DateOnly Date { get; set; }
    public DateTime Expiration { get; set; }
    public BookingStatus Status { get; set; } = BookingStatus.Pending;
    public string ConfirmationCode { get; set; } = string.Empty;
    public virtual ICollection<BookingItem> Items { get; } =  new List<BookingItem>();
}