namespace Problem_5._Restaurant;

public class Prodcuct
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Prodcuct(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

public class Beverage : Prodcuct
{
    public double Milliliters { get; set; }
    
    public Beverage(string name, decimal price, double milliliters) : base(name, price)
    {
        Milliliters = milliliters;
    }
}

public class HotBeverage : Beverage
{
    public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
    {
    }
}

public class ColdBeverage : Beverage
{
    public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
    {
    }
}

public class Coffee : HotBeverage
{
    public double CoffeeMilliliters = 50;
    public decimal CoffeePrice = (decimal)3.5;
    public double Caffeine { get; set; }

    public Coffee(string name, decimal price, double milliliters, double coffeeMilliliters, decimal coffeePrice, double caffeine) : base(name, price, milliliters)
    {
        Caffeine = caffeine;
    }

    public Coffee(string name, decimal price, double milliliters, double caffeine) : base(name, price, milliliters)
    {
        Caffeine = caffeine;
    }
}

public class Tea : HotBeverage
{
    public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters)
    {
    }
}

public class Food : Prodcuct
{
    public double Grams { get; set; }

    public Food(string name, decimal price, double grams) : base(name, price)
    {
        Grams = grams;
    }
}

public class MainDish : Food
{
    public MainDish(string name, decimal price, double grams) : base(name, price, grams)
    {
    }
}

public class Dessert : Food
{
    public double Calories { get; set; }

    public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
    {
        Calories = calories;
    }
}

public class Starter : Food
{
    public Starter(string name, decimal price, double grams) : base(name, price, grams)
    {
        
        
    }
}

public class Fish : MainDish
{
    public new static double Grams;
    public Fish(string name, decimal price) : base(name, price, Grams)
    {
    }
}

public class Soup : MainDish
{
    public Soup(string name, decimal price, double grams) : base(name, price, grams)
    {
    }
}

public class Cake : Dessert
{
    public new static double Grams = 250;
    public new static double Calories = 1000;
    public static double CakePrice = 5;

    public Cake(string name) : base(name, (decimal)CakePrice, Grams, Calories)
    {
    }

    public override string ToString() => $"Name: {this.Name}" +
                                         $"\nPrice: {CakePrice}" +
                                         $"\nGrams: {Grams}" +
                                         $"\nCalories: {Calories}";
}

