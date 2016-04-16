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
        public static int breakdown(int num)
        {
            if (num == 2)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
    }
}