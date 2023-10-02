using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class PastaCooking : CookingTemplate
    {
        protected override void GatherIngredients()
        {
            Console.WriteLine("Toplanilir");
        }

        protected override void CookMeal()
        {
            Console.WriteLine("Qaynadilir.");
        }

        protected override void ServeMeal()
        {
            Console.WriteLine("Servis edilir.");
        }
    }
}
