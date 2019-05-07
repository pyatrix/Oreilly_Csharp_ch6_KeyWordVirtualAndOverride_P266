﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_KeyWordVirtualAndOverride_P266
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";
        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
                return contents;
            else
                return null;
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
        
    }
}