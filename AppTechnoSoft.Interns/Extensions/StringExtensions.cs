using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

namespace AppTechnoSoft.Interns.Extensions;

public static class StringExtensions
{
    public static string MakeUnique(this string value)
    {
        Random _rnd = new();
        var guid = _rnd.Next().ToString("x");
        var output = $"{value} {guid}";
        return output;
    }

    public static string ToEmail(this string userName)
    {
        if (userName is null or "")
            return string.Empty;

        var nameParts = userName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var partsLength = nameParts.Length;
        var email = string.Empty;
        var domain = "@appsoft.edu.np";

        if (partsLength == 0)
        {
            email = string.Empty;
        }

        else if (partsLength == 1)
        {
            email = nameParts[0].ToLower() + domain;
        }
        else
        {
            email += $"{nameParts[0].ToLower()}.{nameParts[partsLength - 1].ToLower()}{domain}";
        }

        return email;
    }

    public static string ToDomain(this string value)
    {
        if (value is null or "")
            return string.Empty;

        if (!value.StartsWith("https://"))
        {
            if (value.StartsWith("www."))
            {
                value = value.Replace("www.", "https://");
            }
            else
            {
                value = "https://" + value;
            }
        }

        return value;
    }

    // Generates a URL-friendly slug from a title.
    public static string ToSlug(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return string.Empty;

        value = value.Trim().ToLowerInvariant();

        // remove diacritics
        var normalized = value.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();
        foreach (var ch in normalized)
        {
            var uc = CharUnicodeInfo.GetUnicodeCategory(ch);
            if (uc != UnicodeCategory.NonSpacingMark)
                sb.Append(ch);
        }

        var cleaned = sb.ToString().Normalize(NormalizationForm.FormC);

        // replace non-alphanumeric characters with '-'
        cleaned = Regex.Replace(cleaned, @"[^a-z0-9]+", "-");

        // trim '-' and collapse duplicates
        cleaned = Regex.Replace(cleaned, @"-+", "-").Trim('-');

        return cleaned;
    }

    // Replaces the id attribute of the first <section ...> element with the provided newId.
    // Handles HTML-encoded content (e.g. &lt;section ...&gt;) by decoding before modification
    // and re-encoding to preserve storage format.
    public static string ReplaceSectionId(this string html, string newId)
    {
        if (string.IsNullOrWhiteSpace(html))
            return html;

        if (string.IsNullOrWhiteSpace(newId))
            return html;

        // Detect if content is HTML-encoded (contains &lt; / &gt; but no raw '<')
        var wasEncoded = html.Contains("&lt;") || html.Contains("&gt;");

        // Decode for manipulation if necessary
        var working = wasEncoded ? WebUtility.HtmlDecode(html) : html;

        // Some editors wrap encoded markup in <p>..</p>, unwrap a <p> that directly contains a <section>
        // Example: <p><section ...>...</section></p>  ->  <section ...>...</section>
        var unwrapPattern = new Regex(@"<p\b[^>]*>\s*(<section\b.*?</section>)\s*</p>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        if (unwrapPattern.IsMatch(working))
        {
            working = unwrapPattern.Replace(working, "$1");
        }

        // Pattern to find a <section ... id="..."> (id may use single or double quotes)
        var patternWithId = new Regex(@"<section\b([^>]*)\bid\s*=\s*(['""])(.*?)\2([^>]*)>", RegexOptions.IgnoreCase | RegexOptions.Singleline);

        string replaced;
        if (patternWithId.IsMatch(working))
        {
            replaced = patternWithId.Replace(working, match =>
            {
                // keep surrounding attributes but replace id value
                var before = match.Groups[1].Value; // attributes before id (may be empty)
                var after = match.Groups[4].Value;  // attributes after id (may be empty)
                return $"<section{before} id=\"{newId}\"{after}>";
            }, 1); // only replace first occurrence
        }
        else
        {
            // If no id attribute present, insert id after the 'section' token for the first <section
            var patternSectionOpen = new Regex(@"<section\b", RegexOptions.IgnoreCase);
            if (patternSectionOpen.IsMatch(working))
            {
                replaced = patternSectionOpen.Replace(working, $"<section id=\"{newId}\"", 1);
            }
            else
            {
                // No <section> found, nothing to change
                replaced = working;
            }
        }

        // Re-encode if original content was encoded
        return wasEncoded ? WebUtility.HtmlEncode(replaced) : replaced;
    }
}
