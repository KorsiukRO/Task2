namespace Task2;

public class Meals
{
    public string Name { get; set; }
    public int Energy { get; set; }
    public int Weight { get; set; }

    public Meals() { }

    public Meals(string name, int energy, int weight)
    {
        Name = name;
        Energy = energy;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Weight: {Weight} g, Energy: {Energy} kcal.";
    }
}