using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace AndreyMatveewDZ01.Model.Validation
{
    /// <summary>
    ///  Валидация логина
    /// </summary>
    public class LoginValidation : ValidationRule
    {
        Regex loginRegex = new Regex(@"^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$");
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (!loginRegex.IsMatch(value.ToString())) return new ValidationResult(false, "Ограничение 2-20 символов, которыми могут быть буквы и цифры, первый символ обязательно буква");
            return new ValidationResult(true, null);
        }
    }
}
