using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;

namespace LapbaseEntityFramework.Repositories
{
    public interface IFoodItemRepository : IDisposable
    {
        FoodItem GetFoodItem(String name);
        IEnumerable<FoodItem> GetFoodItems();
        IEnumerable<FoodItem> GetDrinks();
        void Save();
    }
}
