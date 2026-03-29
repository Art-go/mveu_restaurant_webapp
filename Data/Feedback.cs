namespace Data;

public class Feedback
{
    public int Id { get; set; }
    public Guid? UserId { get; set; }
    public virtual User? User { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.Now;
}