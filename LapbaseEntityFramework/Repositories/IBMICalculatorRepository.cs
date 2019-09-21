using LapbaseEntityFramework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapbaseEntityFramework.Repositories
{
    public interface IBMICalculatorRepository 
    {
        BMICalculatorViewModel calculateBMI(long patientID, long orgCode, decimal weight);
    }
}
