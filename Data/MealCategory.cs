namespace Data;

public class MealCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Dish> Dishes { get; }
}