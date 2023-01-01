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

            if (bMICalculator.Bmi >= 18.5 && bMICalculator.Bmi <= 24.9 && (bMICalculator.Gender == Gender.Male || bMICalculator.Gender == Gender.Female))
            {
                bMICalculator.Range = "WithIn Range";
            }
            else
            {
                bMICalculator.Range = "OutOf Range! It should be in b/w 18.5 to 24.9";
            }
            return bMICalculator;
        }
    }
}
