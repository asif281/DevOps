using DevOps.Models;

namespace DevOps.CalculatorService.BMIService
{
    public class BMIService : IBMIService
    {
        public BMICalculator CalculateBMI(BMICalculator bMICalculator)
        {
            bMICalculator.Bmi = bMICalculator.Weight / (bMICalculator.Height * bMICalculator.Height);
            return bMICalculator;
        }
    }
}
