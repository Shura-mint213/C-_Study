using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    static class StringExtensions
    {
        public static int ToInt(this String str)
        {
            return int.Parse(str);
        }
    }
}
