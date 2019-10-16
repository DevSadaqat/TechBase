using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LapbaseEntityFramework.ViewModel;
using System.Threading.Tasks;
using LapbaseEntityFramework.LbDemo;
using LapbaseEntityFramework.DemoRepositories;

namespace LapbaseEntityFramework.Repositories
{
    public class BMICalculatorRepository: IBMICalculatorRepository
    {
        private LbDemoContext Lbd;
        private readonly IPatientDemographicRepository patientDemographicRepository = new PatientDemographicRepository();

        public BMICalculatorRepository()
        {
            Lbd = new LbDemoContext();
        }
        public BMICalculatorViewModel calculateBMI(long patientID, long orgCode, decimal weight)
        {
            string message = "";
            var patient = patientDemographicRepository.GetPatient(patientID, orgCode).First();
            decimal? bmi1 = weight/ (patient.Height * patient.Height);
           
            double? bmi = (double?)Convert.ChangeType(bmi1, typeof(double));
            bmi = Math.Round((double)bmi, 1);
            
            if (bmi < 18.5)
            {
                message = "Underweight";
    }
            else if (bmi >= 18.5 && bmi < 25)
            {
                message = "Healthy";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                message = "Overweight";
            }
            else
            {
                message = "Obese";
            }
            BMICalculatorViewModel bmiModel = new BMICalculatorViewModel();
            bmiModel.BMI = bmi;
            bmiModel.message = message;
            return bmiModel;
        }
    }
}
