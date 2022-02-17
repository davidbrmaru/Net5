using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Examen.Infrastructure.CrossCutting.Helpers
{
    public static class DateTimeOffsetExtensions
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffset)
        {
            var dateToCalculateTo = DateTime.UtcNow;
            int age = dateToCalculateTo.Year - dateTimeOffset.Year;

            if(dateToCalculateTo < dateTimeOffset.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
