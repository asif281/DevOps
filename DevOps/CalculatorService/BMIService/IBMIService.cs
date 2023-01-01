using DevOps.Models;

namespace DevOps.CalculatorService.BMIService
{
    public interface IBMIService
    {
        BMICalculator CalculateBMI(BMICalculator bMICalculator);
    }
}
