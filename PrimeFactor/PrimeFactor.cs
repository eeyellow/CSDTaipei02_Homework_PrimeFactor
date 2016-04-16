using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIVALACODE
{
    /// <summary>
    /// 質因數分解
    /// </summary>
    public static class PrimeFactor
    {
        public static List<int> breakdown(int num)
        {
            List<int> result = new List<int>();

            while (num % 2 == 0 && num != 1)
            {
                result.Add(2);
                num = num / 2;
            }
            while (num % 3 == 0 && num != 1)
            {
                result.Add(3);
                num = num / 3;
            }
            while (num % 5 == 0 && num != 1)
            {
                result.Add(5);
                num = num / 5;
            }

            while (num % 7 == 0 && num != 1)
            {
                result.Add(7);
                num = num / 7;
            }

            return result;
        }
    }
}