using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.Util
{
    class RepairTable
    {
        public const int ENGINE_OIL = 0;
        public const int AIRCON_FILTER = 1;
        public const int TIRE = 2;
        public const int WIPER = 3;
        public const int WHEEL_BALANCE = 4;
        public const int BREAK_OIL = 5;
        public const int AIRCON_GAS = 6;
        public const int NORMAL_CHECK = 7;
        public const int ANTIFREEZE = 8;
        public const int ETC_COST = 9;

        public static int[] fixMoney =
        {
            50000, 30000, 80000, 20000, 70000,
            50000, 40000, 40000, 50000, 40000
        };
    }
}
