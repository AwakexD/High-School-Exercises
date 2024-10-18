namespace Polymorphism_Task;

public class Animal
{

    public string Name { get; set; }

    public string FavoriteFood { get; set; }

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my favorite food is {this.FavoriteFood} ";
    }
}