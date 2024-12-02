using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_25_SQLite.Models
{
    public class AmountByDayOfWeek
    {
        public DayOfWeek DayOfWeek { get; set; }
        public double? Amount { get; set; }

        public AmountByDayOfWeek (DayOfWeek dayOfWeek, double amount)
        {
            this.DayOfWeek = dayOfWeek;
            this.Amount = amount;
        }
    }
}
