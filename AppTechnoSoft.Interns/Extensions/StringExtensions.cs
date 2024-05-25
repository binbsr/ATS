using Markdig;
using Markdig.Extensions.MediaLinks;

namespace AppTechnoSoft.Interns.Extensions;
public static class StringExtensions
{
    public static string MakeUnique(this string value)
    {
        Random _rnd = new();
        var guid = _rnd.Next().ToString("x");
        var output = $"{value} ({guid})";
        return output;
    }

    public static string ToHtmlString(this string mdValue)
    {
        var pipeline = new MarkdownPipelineBuilder()
            .UseBootstrap()
            .UsePipeTables()
            .Build();
        var htmlMarkup = Markdown.ToHtml(mdValue, pipeline);
        return htmlMarkup;
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
}
