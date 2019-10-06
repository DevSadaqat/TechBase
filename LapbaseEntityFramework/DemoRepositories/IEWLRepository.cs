using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL.LbDemo.SPClasses;
using LapbaseEntityFramework.ViewModel;

namespace LapbaseEntityFramework.DemoRepositories
{
    public interface IEWLRepository : IDisposable
    {
        IEnumerable<EWLViewModel> GetEWLData(long id, long organizationCode);
    }
}
