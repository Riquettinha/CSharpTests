using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CSharpTests
{
    public static class ExtensionMethods
    {
        public static Decimal ConvertToDecimal(string value, bool returnZeroOnError = false)
        {
            value = value.Trim();

            if (value == null)
                return 0;
            if (value.Contains(".") && value.Contains(","))
                value = value.Replace(".", string.Empty);
            else
                value = value.Replace(".", ",");

            value = value.Trim().Replace("R$", string.Empty).Replace("$", string.Empty);

            if (value.Equals("#Error"))
                return 0;

            if (Regex.Matches(value, @"[a-zA-Z]").Count > 0)
                throw new ArgumentException(@"Impossível converter string para decimal.", nameof(value), new Exception(@"ConvertToDecimal"));

            Decimal outDecimal = 0;
            if (Decimal.TryParse(value, NumberStyles.Currency, new CultureInfo("pt-BR"), out outDecimal))
                return outDecimal;

            if (returnZeroOnError)
                return 0;

            throw new ArgumentException(@"Impossível converter string para decimal.", nameof(value), new Exception(@"ConvertToDecimal"));
        }

        public static Decimal ConvertToDecimal(this string value)
        {
            if (value == null)
                return 0;
            if (value.Contains(".") && value.Contains(","))
                value = value.Replace(".", string.Empty);
            else
                value = value.Replace(".", ",");

            value = value.Trim().Replace("R$", string.Empty).Replace("$", string.Empty);

            if (value.Equals("#Error"))
                return 0;

            if (Regex.Matches(value, @"[a-zA-Z]").Count > 0)
                throw new ArgumentException(@"Impossível converter string para decimal.", nameof(value), new Exception(@"ConvertToDecimal"));

            return Convert.ToDecimal(value, new CultureInfo("pt-BR"));
        }
    }
}

