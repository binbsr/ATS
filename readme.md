## CLI Commands
```
dotnet tool install -g dotnet-ef
dotnet ef migrations script ApplicantDetails -o .\Data\Scripts\StudentTableChanges.sql
```

## Widget Title
1. Text **module** will be used to get all training modules.
1. Text **HomeIntro** will be used render items on home page (bottom part)
1. Text **CarouselItem** will be used render carouselitems on home page (top part)

```csharp
public class WidgetFilter
{
    public const string Module = "Course Module";
    public const string CarouselItem = "Home Carousel Item";
    public const string HomeIntro = "Home Card";
}

Note: nameof(Module) etc.
```

## Tag Filters on modules/instructors page
```csharp
public static class RootFilter
{
    public const string All = "All Modules";
    public const string Internship = "Internship";
    public const string Professional = "Professional Training";
    public const string Corporate = "Corporate Training";
}

public static class ModuleSection
{
    public const string Common = "Common";
    public const string Sdk = "SDK";
    public const string DataAccess = "Data Access";
    public const string Web = "Web";
    public const string Security = "Security";
    public const string Devops = "DevOps";
    public const string Networking = "Networking";
    public const string Ml = "ML";
    public const string DataScience = "Data Science";
    public const string UseCase = "Use Case";
    public const string ProjectWork = "Project Work";
}

```

## HTML Content parts
> Example on text editor:
We guide you on software R&D and SDLC to kickstart your career! (Will be used as text title, can be any number of lines withour line breaks)
homeitems/software_life_cycle.png (Will be used as image graphics display)


## Description parts - HomeIntro items
> Example: 
Experienced Intructors (Having 10+ years industry experience) - Splitted into two parts with ['(' ')'] separator. First used as title and second as description.

## Archived
 
 ```
 record Filter(string Category, string Title, string Tag, string Details);
    List<Filter> Filters => [
        new("Interns", "For Interns", "Internship", "Suitable for students aiming to know basics of software development and get their academic internship credits done."),
        new("Training", "Tech Training", "Training", "Suitable for fresh graduates and students aiming to pursue software development career in Nepal and abroad."),
        new("Pro", "Advanced Training", "Training Pro", "Suitable for software professionals aiming to enhance their knowledge horizon and for better career growth.")
    ];
```

## Tags

Tag description is used to fetch filters, so please describe your tag accordigly

> Modules - **module**
> Instrcutors - **tech**



## Some todo features for this portal

1. Automate punch in functionality and role based worklog views
1. Configurable module sections (Hardcoded now)



## Trainee Status
Appllied => Enrolled (Assigned to Batch) => 



## Professional Training

1. CourseQuate contains number of modules and pricing info
1. Training contains a quote, beneficiary, assignments and project info