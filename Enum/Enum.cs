using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Enum
    {
        public enum MonthDay : byte
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            Decembe
        }
        public enum DayOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Sartudaty,
            Sunday
        }
        public enum EstimationStudent : byte
        {
            Badly = 2,
            Satisfactory,
            Good,
            Great
        }
    }
}
