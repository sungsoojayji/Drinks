using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drinks
{   

    public interface IJuice
    { public string Fruit { get; set; } }

    public interface IAlcohol
    {
        public bool IsNonAlcohol { get; set; }
    }

    // Base Class
    public class Drink 
    {
        public string DrinkName { get; set; }
        public bool IsCarbonated { get; set; }        

        public virtual string Description()
        {
            return $"{DrinkName}, {(IsCarbonated ? "carbonated" : "not carbonated")}";
        }        
    }

    // Derived Classes: Juice, Beer, Soda
    public class Juice : Drink, IJuice, IAlcohol
    {
        public string Fruit { get; set; }
        public bool IsNonAlcohol { get; set; }
        //public string IJuice.FruitName { get; set; }

        public override string Description()
        {
            return $"{base.Description()}, made from {Fruit}";            
        }        

    }

    public class Alcohol : Drink
    {
        public double AlcoholContent { get; set; }
        //public bool IsNonAlcohol { get; set; }

        public override string Description()
        {
            return $"{base.Description()}, {AlcoholContent}%";            
        }        
    }

    public class Soda : Drink, IAlcohol
    {
        public bool IsNonAlcohol { get; set; }

        public override string Description()
        {
            return $"{base.Description()}, {(IsNonAlcohol ? "Non-Alcohol" : "Alcohol")}";            
        }
    }

    public class Wine : Alcohol, IJuice, IAlcohol 
    {
        public string wineType { get; set; }
                
        public string Fruit { get; set; }

        public bool IsNonAlcohol { get; set; }


        public override string Description()
        {
            return $"{base.Description()}, {wineType}, made from {Fruit}, {(IsNonAlcohol ? "Non-Alcohol" : "Alcohol")}";
        }
    }

    public class Beer : Alcohol, IAlcohol
    {
        public string beerType { get; set; }
        public bool IsNonAlcohol { get; set; }

        public override string Description()
        {
            return $"{base.Description()}, {beerType}, {(IsNonAlcohol ? "Non-Alcohol" : "Alcohol")}";
        }
    }
}
