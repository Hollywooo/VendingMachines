using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachines
{
    class JVend : VendBase //https://msdn.microsoft.com/en-us/library/ms228387(v=vs.90).aspx
    {
        
        public JVend(int Quarters, int Dimes, int Nickels, int Pennies, float AmountPaid)
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickels = 0;
            this.Pennies = 0;
            this.AmountPaid = Convert.ToSingle((Quarters * 0.25) + (Dimes * 0.1) + (Nickels * 0.05) + (Pennies * 0.01));
        }

        //string stringJVendOutput = VendingMachines.VendBase.DispenseProduct();

        public static void TotalUpdate(VendBase transaction)
        {
            transaction.AmountPaid = Convert.ToSingle((transaction.Quarters * 0.25) + (transaction.Dimes * 0.1) + (transaction.Nickels * 0.05) + (transaction.Pennies * 0.01));
        }

       

       

    }
}
