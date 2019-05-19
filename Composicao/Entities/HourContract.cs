using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract(HourContract)
        {

        }
        public HourContract(int hoursJob)
        {
            Hours = hoursJob;
        }

        public HourContract(DateTime date, double valuePerHour, int hours) : this(hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return "Income For "
                + Date
                + TotalValue();

        }
    }
}
