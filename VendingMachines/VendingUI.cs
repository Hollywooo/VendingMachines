using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachines
{

    public partial class VendingUI : Form
    {

        JVend jTransaction = new JVend(0,0,0,0,0);
        CVend cTransaction = new CVend(0);
        double drinkCost = 0;
        string drinkChoice = "No drink selected!";
        double waterCost = 1.00;
        double sodaCost = 1.50;
        double lemonAdeCost = 2.13;

        public VendingUI()
        {
            InitializeComponent();
        }

        private void Quarters_Click(object sender, EventArgs e)
        {
            jTransaction.Quarters++;
            JVend.TotalUpdate(jTransaction);
            cTransaction.AmountPaid = cTransaction.AmountPaid + Convert.ToSingle(0.25);
            tb_QuarterCount.Text = Convert.ToString(jTransaction.Quarters);
            tb_JVend.Text = Convert.ToString(jTransaction.AmountPaid);
            tbCVend.Text = Convert.ToString(cTransaction.AmountPaid);
        }

        private void Dimes_Click(object sender, EventArgs e)
        {
            jTransaction.Dimes++;
            JVend.TotalUpdate(jTransaction);
            cTransaction.AmountPaid = cTransaction.AmountPaid + Convert.ToSingle(0.10);
            tb_DimeCount.Text = Convert.ToString(jTransaction.Dimes);            
            tb_JVend.Text = Convert.ToString(jTransaction.AmountPaid);
            tbCVend.Text = Convert.ToString(cTransaction.AmountPaid);
        }

        private void Nickels_Click(object sender, EventArgs e)
        {
            jTransaction.Nickels++;
            JVend.TotalUpdate(jTransaction);
            cTransaction.AmountPaid = cTransaction.AmountPaid + Convert.ToSingle(0.05);
            tb_NickelCount.Text = Convert.ToString(jTransaction.Nickels);
            tb_JVend.Text = Convert.ToString(jTransaction.AmountPaid);
            tbCVend.Text = Convert.ToString(cTransaction.AmountPaid);
        }

        private void Pennies_Click(object sender, EventArgs e)
        {
            jTransaction.Pennies++;
            JVend.TotalUpdate(jTransaction);
            cTransaction.AmountPaid = cTransaction.AmountPaid + Convert.ToSingle(0.01);
            tb_PennyCount.Text = Convert.ToString(jTransaction.Pennies);
            tb_JVend.Text = Convert.ToString(jTransaction.AmountPaid);
            tbCVend.Text = Convert.ToString(cTransaction.AmountPaid);

            if (jTransaction.Pennies == 1) 
            {
                MessageBox.Show("NO ONE USES PENNIES IN A VENDING MACHINE WHAT IS WRONG WITH YOU???");
            }
            else if (jTransaction.Pennies == 2)
            {
                MessageBox.Show("Fine...I guess you have to get rid of them somehow...");
            }          
            else { }

        }

        private void btnRealPennies_Click(object sender, EventArgs e)
        {
          
        }

        private void tb_Inputs_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCVend_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_JVend_TextChanged(object sender, EventArgs e)
        {

        }

        private void lable_CVend_Click(object sender, EventArgs e)
        {

        }

        private void label_JVend_Click(object sender, EventArgs e)
        {

        }

        private void label_Inputs_Click(object sender, EventArgs e)
        {

        }

        private void tb_QuarterCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_DimeCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_NickelCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_PennyCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_FreshWater_Click(object sender, EventArgs e)
        {
            drinkChoice = "Fresh Water";
            drinkCost = waterCost;
            tb_DrinkDisp.Text = drinkChoice + " $" + drinkCost;
        }

        private void label_QuarterCount_Click(object sender, EventArgs e)
        {

        }

        private void label_DimeCount_Click(object sender, EventArgs e)
        {

        }

        private void label_NickelCount_Click(object sender, EventArgs e)
        {

        }

        private void label_PennyCount_Click(object sender, EventArgs e)
        {

        }

        private void btn_SodaPop_Click(object sender, EventArgs e)
        {
            drinkChoice = "Soda Pop";
            drinkCost = sodaCost;
            tb_DrinkDisp.Text = drinkChoice + " $" + drinkCost;
        }

        private void btn_Lemonade_Click(object sender, EventArgs e)
        {
            drinkChoice = "LemonAde";
            drinkCost = lemonAdeCost;
            tb_DrinkDisp.Text = drinkChoice + " $" + drinkCost;        }

        private void label_Drinks_Click(object sender, EventArgs e)
        {

        }

        private void btn_CoinReturn_Click(object sender, EventArgs e)
        {
            JVend.Reset(jTransaction);
            CVend.Reset(cTransaction);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Vend_Click(object sender, EventArgs e)
        {
            if (jTransaction.AmountPaid >= drinkCost)
            {
                VendBase.DispenseProduct(drinkChoice);
                JVend.ChangeMaker(jTransaction.AmountPaid, drinkCost);
                CVend.ChangeMaker(cTransaction.AmountPaid, drinkCost);
                tb_QuarterCount.Text = "0";
                tb_DimeCount.Text = "0";
                tb_NickelCount.Text = "0";
                tb_PennyCount.Text = "0";
                tb_JVend.Text = "0.00";
                tbCVend.Text = "0.00";
                JVend.Reset(jTransaction);
                CVend.Reset(cTransaction);
                tb_DrinkDisp.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
