using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyManiaManager.Utils
{
    class DateTimeUtils
    {
        public static int GetDifferenceInDays(DateTime startDate, DateTime endDate)
        {
            return (int)(endDate - startDate).Duration().TotalDays;
        }

        public static double GetDifferenceInSeconds(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Duration().TotalSeconds;
        }

        public static double GetDifferenceInMinutes(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Duration().TotalMinutes;
        }

        public static double GetDifferenceInHours(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Duration().TotalHours;
        }
    }
}
