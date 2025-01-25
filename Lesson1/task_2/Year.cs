using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsYear
{
    public class Year : IEnumerable<Month>
    {
        private List<Month> months = new List<Month>
    {
        new Month("January", 1, 31),
        new Month("February", 2, 28),
        new Month("March", 3, 31),
        new Month("April", 4, 30),
        new Month("May", 5, 31),
        new Month("June", 6, 30),
        new Month("July", 7, 31),
        new Month("August", 8, 31),
        new Month("September", 9, 30),
        new Month("October", 10, 31),
        new Month("November", 11, 30),
        new Month("December", 12, 31)
    };

        public IEnumerator<Month> GetEnumerator()
        {
            return months.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<Month> GetMonthsByNumber(int number)
        {
            foreach (var month in months)
            {
                if (month.Number == number)
                {
                    yield return month;
                }
            }
        }

        public IEnumerable<Month> GetMonthsByDays(int days)
        {
            foreach (var month in months)
            {
                if (month.Days == days)
                {
                    yield return month;
                }
            }
        }
    }

}
