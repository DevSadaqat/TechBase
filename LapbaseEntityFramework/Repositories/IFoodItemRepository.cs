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
        IEnumerable<FoodItem> GetBreakfast();
        IEnumerable<FoodItem> GetDinner();
        IEnumerable<FoodItem> GetLunch();
        void Save();
    }
}
