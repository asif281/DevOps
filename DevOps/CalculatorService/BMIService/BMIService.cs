using DevOps.Models;

namespace DevOps.CalculatorService.BMIService
{
    public class BMIService : IBMIService
    {
        public BMICalculator CalculateBMI(BMICalculator bMICalculator)
        {
            var meter = bMICalculator.Height/100;
            var sqOfHieght = meter * meter;
            bMICalculator.Bmi = bMICalculator.Weight / (sqOfHieght);
            return bMICalculator;
        }
    }
}
