using Task2;

public class Program
{
    public static void Main(string[] args)
    {
        List<Meals> meals = new List<Meals>()
        {
            new Meals {Name= "Grilled Chicken Salad", Energy=350, Weight=250},
            new Meals {Name= "Spaghetti Bolognese", Energy=600, Weight=400},
            new Meals {Name= "Vegetable Stir Fry", Energy=450, Weight=350},
            new Meals {Name= "Beef Stew", Energy=500, Weight=300},
            new Meals {Name= "Salmon with Asparagus", Energy=550, Weight=250},
            new Meals {Name= "Vegan Chili", Energy=400, Weight=350},
            new Meals {Name= "Turkey and Avocado Wrap", Energy=300, Weight=200},
            new Meals {Name= "Quinoa and Roasted Vegetables", Energy=350, Weight=300},
            new Meals {Name= "Egg and Spinach Breakfast Burrito", Energy=350, Weight=200},
            new Meals {Name= "Greek Yogurt with Honey and Nuts", Energy=250, Weight=150}
        };

        Console.ForegroundColor = ConsoleColor.Yellow;
        
        Console.WriteLine("\nList of meals (1, 5, 10):");
        
        Console.ForegroundColor = default;
        
        Console.WriteLine(meals[0]);
        
        Console.WriteLine(meals[4]);
        
        Console.WriteLine(meals[9]);
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        Console.WriteLine("\nSorted list by Name:");
        
        Console.ForegroundColor = default;
        
        meals.Sort((meal1, meal2) => meal1.Name.CompareTo(meal2.Name));
        
        foreach (var meal in meals)
        {
            Console.WriteLine(meal);
        }
    }
}