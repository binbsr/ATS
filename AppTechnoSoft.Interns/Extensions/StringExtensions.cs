using Markdig;
using Microsoft.AspNetCore.Components;

namespace AppTechnoSoft.Interns.Extensions;
public static class StringExtensions
{
    public static string MakeUnique(this string value)
    {
        var guid = Guid.NewGuid();
        var identifier = Convert.ToBase64String(guid.ToByteArray())[0..^2]
            .Replace('+', '-')
            .Replace('/', '_');
        var output = $"{value} ({identifier})";
        return output;
    }

    public static string GetHtmlString(this string mdValue)
    {
        var pipeline = new MarkdownPipelineBuilder()
               .UseAdvancedExtensions()
               .Build();
        var htmlMarkup = Markdown.ToHtml(mdValue, pipeline);
        return htmlMarkup;
    }
}
