using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Balance
    {
        //Calculate balnce due according member sign up association date
        //Membership 139 for year, divided for 4 quarters. Each gives 34.75 for quarter
        public static int getBalance(DateTime associationDate)
        {
            int month = associationDate.Month;
            int day = associationDate.Day;

            if (month <= 3)
            {
                return 139;
            }
            else if (month <= 6)
            {
                return 104;
            }
            else if (month <= 9)
            {
                return 69;
            }
            else
            {
                return 35;
            }
        }
    }
}
