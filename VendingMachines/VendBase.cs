using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachines
{
    class VendBase
    {
        public int Quarters { get; set; }
        public int Dimes { get; set; }
        public int Nickels { get; set; }
        public int Pennies { get; set; }
        public float AmountPaid { get; set; }
                
        public static string DispenseProduct(string drinkOut)
        {
            string dispenseProduct = "Dispensing " + drinkOut + "!";
            return dispenseProduct;
        }

        public static VendBase Reset(VendBase currentTransaction)
        {
            currentTransaction.Quarters = 0;
            currentTransaction.Dimes = 0;
            currentTransaction.Nickels = 0;
            currentTransaction.Pennies = 0;
            currentTransaction.AmountPaid = 0;
            return currentTransaction;
        }
        public static void ChangeMaker(float amount, double cost)
        {
            int dispenseQuarters, dispenseDimes, dispenseNickels, dispensePennies;
            double dblAmount = Math.Round(Convert.ToDouble(amount), 2);
            double change = (dblAmount - cost);

            dispenseQuarters = Convert.ToInt32(Math.Floor(change / 0.25));
            change = change % 0.25;
            dispenseDimes = Convert.ToInt32(Math.Floor(change / 0.1));
            change = change % 0.1;
            dispenseNickels = Convert.ToInt32(Math.Floor(change / 0.05));
            change = change % 0.05;
            dispensePennies = Convert.ToInt32(change / 0.01);
            MessageBox.Show("Your change is " + (dblAmount - cost) + ", which is: " + dispenseQuarters + " quarters, " + dispenseDimes + " dimes, " + dispenseNickels + " nickels, and " + dispensePennies + " useless pennies.  Enjoy your tasty beverage!");

        }
    }
}