﻿using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Interns.Data.Models;
public class Widget
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; }= string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string HtmlContent { get; set; } = string.Empty;
    public WidgetType Type { get; set; } = WidgetType.CourseModule;
}
