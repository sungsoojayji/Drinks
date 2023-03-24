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
            new Juice { DrinkName = "Orange Juice", IsCarbonated = false, Fruit = "oranges", IsNonAlcohol = true },
            new Beer { DrinkName = "Budweiser", IsCarbonated = true, AlcoholContent = 5.0, beerType ="Larger", IsNonAlcohol = false },            
            new Wine { DrinkName = "Sabinon", IsCarbonated = false, AlcoholContent = 12.0, wineType ="Red", Fruit = "Grape", IsNonAlcohol = false},
            new Beer { DrinkName = "Erdinger", IsCarbonated = true, AlcoholContent = 6.0, beerType ="Hefeweissen", IsNonAlcohol = false},
            new Soda { DrinkName = "Pepsi", IsCarbonated = true, IsNonAlcohol = true }
        };

        foreach (var drink in drinkList)
        {
            Console.WriteLine(drink.Description());
        }
    }
}
