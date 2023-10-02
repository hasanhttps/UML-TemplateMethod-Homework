using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class CookingTemplate
    {
        public void Cook()
        {
            GatherIngredients();
            CookMeal();
            ServeMeal();
        }

        protected abstract void GatherIngredients();
        protected abstract void CookMeal();
        protected abstract void ServeMeal();
    }

}
