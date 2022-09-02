using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace AndreyMatveewDZ01.Model.Validation
{
    /// <summary>
    ///  Валидация емейла
    /// </summary>
    public class EmailValidation : ValidationRule
    {
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (!emailRegex.IsMatch(value.ToString())) return new ValidationResult(false, "Некорректный Email");
            return new ValidationResult(true, null);
        }
    }
}
