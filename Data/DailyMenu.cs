namespace Data;

public class DailyMenu
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public virtual ICollection<DailyMenuItem> Items { get; } =  new List<DailyMenuItem>();
}