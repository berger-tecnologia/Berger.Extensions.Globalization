namespace Berger.Extensions.Globalization
{
    public static class CurrencyHelper
    {
        public static string Format(this double value)
        {
            return string.Format(value.ToString("N2"));
        }
    }
}