namespace Data;

public class DailyMenuItem
{
    public int Id { get; set; }
    public virtual DailyMenu Menu { get; set; }
    public virtual Dish Dish { get; set; }
    public int Quantity { get; set; }
    public int Shortage { get; set; }
}