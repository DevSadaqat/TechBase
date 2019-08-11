using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;

namespace LapbaseEntityFramework.Repositories
{
    public class UserRepository : IUserRepository, IDisposable
    {
        private LapbaseContext Lb;
        public UserRepository()
        {
            Lb = new LapbaseContext();
        }


        public User GetUserByID(string username)
        {
            var user = Lb.Users.Where(a => a.ID.Equals(username)).FirstOrDefault();
            return user;
        }


        public void Save()
        {
            Lb.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Lb.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
