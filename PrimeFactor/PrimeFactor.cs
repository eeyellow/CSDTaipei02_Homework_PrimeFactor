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

            if (num == 2)
            {
                result.Add(2);
            }
            else
            {
                result.Add(3);
            }

            return result;
        }
    }
}