using System.ComponentModel.DataAnnotations;

namespace BmiCalculatorApp.Models
{
    public class BmiViewModel
    {
        [Required(ErrorMessage = "Please enter a height in metres.")]
        [Range(0.01, 3, ErrorMessage = "Height must be greater than 0 and less than or equal to 3.")]

        public double? Height { get; set; }

        [Required(ErrorMessage = "Please enter a weight in kg.")]
        [Range(0.01, 500, ErrorMessage = "Weight must be greater than 0 and less than or equal to 500.")]
        public double? Weight { get; set; }

        public double? BmiValue { get; set; }
        public string? BmiSummary { get; set; }

        // A static method that does our BMI calc'n:
        // https://www.wikihow.com/Calculate-Your-Body-Mass-Index-%28BMI%29
        public static double? CalculateBmi(double? weight, double? height)
        {
            if (weight == null || height == null)
                return null;

            return weight / (height * height);
        }

        public static string GetBmiResultSummary(double? bmi)
        {
            if (bmi == null)
                return "unknown";
            if (bmi > 0.0 && bmi < 18.5)
                return "underweight";
            else if (bmi >= 18.5 && bmi < 25.0)
                return "normal";
            else if (bmi >= 25.0 && bmi < 30.0)
                return "overweight";
            else if (bmi >= 30.0)
                return "obese";
            else
                return "unknown";
        }
    }
}
