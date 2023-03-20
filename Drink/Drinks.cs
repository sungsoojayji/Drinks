using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drinks
{   
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
    public class Juice : Drink
    {
        public string Fruit { get; set; }

        public override string Description()
        {
            return $"{base.Description()}, made from {Fruit}";            
        }        

    }

    public class Beer : Drink
    {
        public double AlcoholContent { get; set; }

        public override string Description()
        {
            return $"{base.Description()}, {AlcoholContent}%";            
        }        
    }

    public class Soda : Drink
    {
        public override string Description()
        {
            return $"{base.Description()}";            
        }
    }
}
