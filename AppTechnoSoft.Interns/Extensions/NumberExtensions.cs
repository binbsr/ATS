﻿using System.Globalization;

namespace AppTechnoSoft.Interns.Extensions;
public static class NumberExtensions
{
    public static string AsCurrency(this float? value) =>
        value?.ToString("C2", new CultureInfo("ne-NP")) ?? 0.ToString("C2", new CultureInfo("ne-NP"));

    public static string AsPercentage(this float? value) =>
        value?.ToString("P2") ?? 0.ToString("P2");
    
    public static string CharactersPassword(this int length)
    {
        const string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
        const string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
        const string Digits = "0123456789";
        const string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
        const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialCharacters;

        Random rnd = new();

        var password = string.Empty;
        for (int i = 0; i < length; i++)
        {
            password += AllChars[rnd.Next(AllChars.Length)];
        }

        return password;
    }
}
