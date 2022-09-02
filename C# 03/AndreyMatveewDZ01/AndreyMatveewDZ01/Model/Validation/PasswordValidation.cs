using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace AndreyMatveewDZ01.Model.Validation
{
    /// <summary>
    ///  Валидация пароля
    /// </summary>
    public class PasswordValidation : ValidationRule
    {
        Regex passRegex = new Regex(@"(?=^.{8,20}$)(?=.*\d)(?=.*[A-Z]*)(?=.*[a-z])(?!.*\s).*$");
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (!passRegex.IsMatch(value.ToString())) return new ValidationResult(false, "От 8 символов до 20 с использованием цифр, спец. символов, латиницы, наличием строчных и прописных символов");
            return new ValidationResult(true,null);
        }
    }
}
