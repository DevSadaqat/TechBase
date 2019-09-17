using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;


namespace LapbaseEntityFramework.Repositories
{
    public interface IFoodRepository : IDisposable
    {
        IEnumerable<Food> GetFoods(long PatientID, long OrganizationCode);
        Food GetFoodByID(long id);
        void InsertFood(Food food);
        void DeleteFood(long id);     
        void UpdateFood(Food food);
        void Save();
    }
}
