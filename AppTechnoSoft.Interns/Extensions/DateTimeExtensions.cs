namespace AppTechnoSoft.Interns.Extensions;
public static class DateTimeExtensions
{
    public static DateTime ToNepalTime(this DateTime dateTime)
    {
        TimeZoneInfo nepalZone = TimeZoneInfo.FindSystemTimeZoneById("Nepal Standard Time");
        DateTime nepalTime = TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.Utc, nepalZone);

        return nepalTime;
    }

    public static DateTime ToNepalTime(this DateTime? dateTime)
    {
        if (dateTime is null)
            return DateTime.MinValue;

        return dateTime.ToNepalTime();
    }

    public static TimeOnly ToNepalTime(this TimeOnly? time, DateOnly date)
    {
        var dateTime = new DateTime(date, time!.Value, DateTimeKind.Utc);        
        DateTime nepalTime = dateTime.ToNepalTime();
        var timeStampNepal = TimeOnly.FromDateTime(nepalTime);

        return timeStampNepal;
    }

    public static DateTime[] Until(this DateTime start, DateTime end)
    {
        List<DateTime> dates = [];

        for(var counter = start; counter <= end; counter = counter.AddDays(1))
        {
            dates.Add(counter);
        }

        return [.. dates];
    }

    public static bool IsOfficeDay(this DateTime date)
    {
        var isWeekend = date.DayOfWeek == DayOfWeek.Saturday;
        return !isWeekend;
    }
}
