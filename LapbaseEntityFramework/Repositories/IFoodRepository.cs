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
        IEnumerable<Food> FilterBreakfast(long PatientID, long OrganizationCode);
        IEnumerable<Food> FilterLunch(long PatientID, long OrganizationCode);
        IEnumerable<Food> FilterDinner(long PatientID, long OrganizationCode);
        IEnumerable<Food> FilterSmall(long PatientID, long OrganizationCode);
        IEnumerable<Food> FilterMedium(long PatientID, long OrganizationCode);
        IEnumerable<Food> FilterLarge(long PatientID, long OrganizationCode);
        IEnumerable<Food> FilterFoodName(long PatientID, long OrganizationCode, string foodName);
        void Save();
    }
}
