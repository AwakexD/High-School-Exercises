namespace Polymorphism_Task;

public class Dog : Animal
{
    public Dog(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + "DJAFFFF";
    }
}