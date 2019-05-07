using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_KeyWordVirtualAndOverride_P266
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReceviceContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thank you for returning my jewels!" + safeContents.Sparkle());
        }
    }
}
