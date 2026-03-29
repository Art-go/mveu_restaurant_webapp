namespace Data;

public class DailyMenuItem
{
    public int Id { get; set; }
    public int DailyMenuId { get; set; }
    public virtual DailyMenu Menu { get; set; } = null!;
    public int DishId { get; set; }
    public virtual Dish Dish { get; set; } = null!;
    public int Quantity { get; set; }
    public int Shortage { get; set; }
}