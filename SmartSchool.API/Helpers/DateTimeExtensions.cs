using System;

namespace SmartSchool.API.Helpers
{
    public static class DateTimeExtensions
    {
        public static int GetCurrentAge(this DateTime dateTime)
        {
            var currentDate = DateTime.UtcNow;
            int age = currentDate.Year - dateTime.Year;

            if (dateTime < currentDate.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
