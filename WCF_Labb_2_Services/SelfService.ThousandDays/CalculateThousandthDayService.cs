using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.ThousandDays
{
    class CalculateThousandthDayService : ICalculateThousandthDay
    {
        public DateTime CalculateThousandthDayOfLife(DateTime dateOfBirth)
        {
            var daysOld = DateTime.Now.Subtract(dateOfBirth).Days;
            var differenceModuloThousand = daysOld % 1000;
            var actualDaysLeft = 1000 - differenceModuloThousand;

            return DateTime.Now.AddDays(actualDaysLeft);
        }
    }
}
