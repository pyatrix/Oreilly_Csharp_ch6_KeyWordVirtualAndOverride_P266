using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch6_KeyWordVirtualAndOverride_P266
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDoenCombination);
        }

        private string writtenDoenCombination = null;
        public void WriteDownCombination(string combinatoin)
        {
            writtenDoenCombination = combinatoin;
        }

        public void ReturnContents(Jewels safeConstent, Owner owner)
        {
            owner.ReceviceContents(safeConstent);
        }
    }
}
