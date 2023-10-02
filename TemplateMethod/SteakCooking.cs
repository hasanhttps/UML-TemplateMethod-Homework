using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class SteakCooking : CookingTemplate
    {
        protected override void GatherIngredients()
        {
            Console.WriteLine("Steak ucun erzaqlar toplanir.");
        }

        protected override void CookMeal()
        {
            Console.WriteLine("Steak bisirilir.");
        }

        protected override void ServeMeal()
        {
            Console.WriteLine("Steak servis edilir.");
        }
    }
}
