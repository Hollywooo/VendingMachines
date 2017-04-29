using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines
{
    class CVend  : VendBase
    {

        public CVend(float AmountPaid)
        {
            this.AmountPaid = AmountPaid;
        }

        public static void TotalUpdate(CVend transaction)
        {

        }
    }
}
