## Widget Title
1. Text **module** will be used to get all training modules.
1. Text **HomeIntro** will be used render items on home page (bottom part)
1. Text **CarouselItem** will be used render carouselitems on home page (top part)

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