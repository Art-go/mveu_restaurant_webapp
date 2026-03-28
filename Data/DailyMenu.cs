namespace Data;

public class DailyMenu
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public virtual ICollection<DailyMenuItem> Items { get; }
}