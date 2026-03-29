namespace Data;

public class Favorite
{
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    public int DishId { get; set; }
    public virtual Dish Dish { get; set; } = null!;
}