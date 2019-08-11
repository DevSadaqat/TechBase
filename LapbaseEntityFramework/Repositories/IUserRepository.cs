using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;

namespace LapbaseEntityFramework.Repositories
{
    public interface IUserRepository : IDisposable
    {

        User GetUserByID(string username);

        void Save();
    }
}
