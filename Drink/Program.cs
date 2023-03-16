using System;
using System.Collections.Generic;
using Drinks;

// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        var drinkList = new List<Drink>
        {
            new Juice { DrinkName = "Orange Juice", IsCarbonated = false, Fruit = "oranges" },
            new Beer { DrinkName = "Budweiser", IsCarbonated = true, AlcoholContent = 5.0 },
            new Soda { DrinkName = "Pepsi", IsCarbonated = true }
        };

        foreach (var drink in drinkList)
        {
            Console.WriteLine(drink.Description());
        }
    }
}
