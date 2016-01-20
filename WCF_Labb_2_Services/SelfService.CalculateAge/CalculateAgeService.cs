using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.CalculateAge
{
    class CalculateAgeService : ICalculateAge
    {
        public int CalculateAge(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            var age = now.Year - dateOfBirth.Year;
            if (now < dateOfBirth.AddYears(age))
                age--;

            return age;
        }
    }
}
