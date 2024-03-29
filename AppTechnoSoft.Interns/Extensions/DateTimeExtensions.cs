namespace AppTechnoSoft.Interns.Extensions;
public static class DateTimeExtensions
{
    public static DateTime ToNepalTime(this DateTime dateTime)
    {
        TimeZoneInfo nepalZone = TimeZoneInfo.FindSystemTimeZoneById("Nepal Standard Time");
        DateTime nepalTime = TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.Utc, nepalZone);

        return nepalTime;
    }

    public static TimeOnly ToNepalTime(this TimeOnly? time, DateOnly date)
    {
        var dateTime = new DateTime(date, time!.Value, DateTimeKind.Utc);        
        DateTime nepalTime = dateTime.ToNepalTime();
        var timeStampNepal = TimeOnly.FromDateTime(nepalTime);

        return timeStampNepal;
    }
}
