namespace Polymorphism_Task;

public class Cat : Animal
{
    public Cat(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + "MEOWWW";
    }
}