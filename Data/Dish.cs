namespace Data;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Weight { get; set; }
    public int CategoryId { get; set; } 
    public virtual Category Category { get; set; } = null!;
    
    public ICollection<DailyMenuItem> DailyMenuItems { get; set; } = new List<DailyMenuItem>();
    public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
}