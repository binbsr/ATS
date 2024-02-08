using System.Globalization;

namespace AppTechnoSoft.Interns.Extensions;
public static class NumberExtensions
{
    public static string AsCurrency(this float? value) =>
        value?.ToString("C2", new CultureInfo("ne-NP")) ?? 0.ToString("C2", new CultureInfo("ne-NP"));

    public static string AsPercentage(this float? value) =>
        value?.ToString("P2") ?? 0.ToString("P2");
}
