using AppTechnoSoft.Interns.Extensions;
using AppTechnoSoft.Interns.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace AppTechnoSoft.Interns.Components.TimeZone;

public sealed class LocalTime : ComponentBase, IDisposable
{
    [Inject]
    public TimeProvider TimeProvider { get; set; } = default!;

    [Parameter]
    public DateTime? DateTime { get; set; }

    protected override void OnInitialized()
    {
        if (TimeProvider is BrowserTimeProvider browserTimeProvider)
        {
            browserTimeProvider.LocalTimeZoneChanged += LocalTimeZoneChanged;
        }
    }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        if (DateTime != null)
        {
            builder.AddContent(0, TimeProvider.ToLocalDateTime(DateTime.Value));
        }
    }

    public void Dispose()
    {
        if (TimeProvider is BrowserTimeProvider browserTimeProvider)
        {
            browserTimeProvider.LocalTimeZoneChanged -= LocalTimeZoneChanged;
        }
    }

    private void LocalTimeZoneChanged(object? sender, EventArgs e)
    {
        _ = InvokeAsync(StateHasChanged);
    }
}
