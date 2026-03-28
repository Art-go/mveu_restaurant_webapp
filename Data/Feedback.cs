namespace Data;

public class Feedback
{
    public int Id { get; set; }
    public virtual User? User { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }
}