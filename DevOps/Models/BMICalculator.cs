using DevOps.CalculatorService.BMIService;

namespace DevOps.Models
{
    public class BMICalculator
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Bmi { get; set; }
        public Gender Gender { get; set; }
        public string Range { get; set; }
    }

}
