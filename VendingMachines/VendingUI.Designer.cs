namespace VendingMachines
{
    partial class VendingUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuarters = new System.Windows.Forms.Button();
            this.Dimes = new System.Windows.Forms.Button();
            this.Nickels = new System.Windows.Forms.Button();
            this.Pennies = new System.Windows.Forms.Button();
            this.tbCVend = new System.Windows.Forms.TextBox();
            this.tb_JVend = new System.Windows.Forms.TextBox();
            this.lable_CVend = new System.Windows.Forms.Label();
            this.label_JVend = new System.Windows.Forms.Label();
            this.label_Inputs = new System.Windows.Forms.Label();
            this.tb_QuarterCount = new System.Windows.Forms.TextBox();
            this.tb_DimeCount = new System.Windows.Forms.TextBox();
            this.tb_NickelCount = new System.Windows.Forms.TextBox();
            this.tb_PennyCount = new System.Windows.Forms.TextBox();
            this.label_QuarterCount = new System.Windows.Forms.Label();
            this.label_DimeCount = new System.Windows.Forms.Label();
            this.label_NickelCount = new System.Windows.Forms.Label();
            this.label_PennyCount = new System.Windows.Forms.Label();
            this.btn_FreshWater = new System.Windows.Forms.Button();
            this.btn_SodaPop = new System.Windows.Forms.Button();
            this.btn_Lemonade = new System.Windows.Forms.Button();
            this.label_Drinks = new System.Windows.Forms.Label();
            this.btn_CoinReturn = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Vend = new System.Windows.Forms.Button();
            this.tb_DrinkDisp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnQuarters
            // 
            this.btnQuarters.Location = new System.Drawing.Point(625, 321);
            this.btnQuarters.Name = "btnQuarters";
            this.btnQuarters.Size = new System.Drawing.Size(74, 96);
            this.btnQuarters.TabIndex = 0;
            this.btnQuarters.Text = "Quarters";
            this.btnQuarters.UseVisualStyleBackColor = true;
            this.btnQuarters.Click += new System.EventHandler(this.Quarters_Click);
            // 
            // Dimes
            // 
            this.Dimes.Location = new System.Drawing.Point(730, 321);
            this.Dimes.Name = "Dimes";
            this.Dimes.Size = new System.Drawing.Size(74, 96);
            this.Dimes.TabIndex = 1;
            this.Dimes.Text = "Dimes";
            this.Dimes.UseVisualStyleBackColor = true;
            this.Dimes.Click += new System.EventHandler(this.Dimes_Click);
            // 
            // Nickels
            // 
            this.Nickels.Location = new System.Drawing.Point(834, 321);
            this.Nickels.Name = "Nickels";
            this.Nickels.Size = new System.Drawing.Size(74, 96);
            this.Nickels.TabIndex = 2;
            this.Nickels.Text = "Nickels";
            this.Nickels.UseVisualStyleBackColor = true;
            this.Nickels.Click += new System.EventHandler(this.Nickels_Click);
            // 
            // Pennies
            // 
            this.Pennies.Location = new System.Drawing.Point(939, 321);
            this.Pennies.Name = "Pennies";
            this.Pennies.Size = new System.Drawing.Size(74, 96);
            this.Pennies.TabIndex = 3;
            this.Pennies.Text = "Pennies";
            this.Pennies.UseVisualStyleBackColor = true;
            this.Pennies.Click += new System.EventHandler(this.Pennies_Click);
            // 
            // tbCVend
            // 
            this.tbCVend.Location = new System.Drawing.Point(58, 74);
            this.tbCVend.Name = "tbCVend";
            this.tbCVend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCVend.Size = new System.Drawing.Size(419, 22);
            this.tbCVend.TabIndex = 5;
            this.tbCVend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCVend.TextChanged += new System.EventHandler(this.tbCVend_TextChanged);
            // 
            // tb_JVend
            // 
            this.tb_JVend.Location = new System.Drawing.Point(1103, 74);
            this.tb_JVend.Name = "tb_JVend";
            this.tb_JVend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_JVend.Size = new System.Drawing.Size(419, 22);
            this.tb_JVend.TabIndex = 6;
            this.tb_JVend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_JVend.TextChanged += new System.EventHandler(this.tb_JVend_TextChanged);
            // 
            // lable_CVend
            // 
            this.lable_CVend.AutoSize = true;
            this.lable_CVend.Location = new System.Drawing.Point(55, 54);
            this.lable_CVend.Name = "lable_CVend";
            this.lable_CVend.Size = new System.Drawing.Size(50, 17);
            this.lable_CVend.TabIndex = 7;
            this.lable_CVend.Text = "CVend";
            this.lable_CVend.Click += new System.EventHandler(this.lable_CVend_Click);
            // 
            // label_JVend
            // 
            this.label_JVend.AutoSize = true;
            this.label_JVend.Location = new System.Drawing.Point(1100, 54);
            this.label_JVend.Name = "label_JVend";
            this.label_JVend.Size = new System.Drawing.Size(48, 17);
            this.label_JVend.TabIndex = 8;
            this.label_JVend.Text = "JVend";
            this.label_JVend.Click += new System.EventHandler(this.label_JVend_Click);
            // 
            // label_Inputs
            // 
            this.label_Inputs.AutoSize = true;
            this.label_Inputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Inputs.Location = new System.Drawing.Point(745, 276);
            this.label_Inputs.Name = "label_Inputs";
            this.label_Inputs.Size = new System.Drawing.Size(143, 29);
            this.label_Inputs.TabIndex = 9;
            this.label_Inputs.Text = "I N P U T S";
            this.label_Inputs.Click += new System.EventHandler(this.label_Inputs_Click);
            // 
            // tb_QuarterCount
            // 
            this.tb_QuarterCount.Location = new System.Drawing.Point(1433, 102);
            this.tb_QuarterCount.Name = "tb_QuarterCount";
            this.tb_QuarterCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_QuarterCount.Size = new System.Drawing.Size(89, 22);
            this.tb_QuarterCount.TabIndex = 10;
            this.tb_QuarterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_QuarterCount.TextChanged += new System.EventHandler(this.tb_QuarterCount_TextChanged);
            // 
            // tb_DimeCount
            // 
            this.tb_DimeCount.Location = new System.Drawing.Point(1433, 130);
            this.tb_DimeCount.Name = "tb_DimeCount";
            this.tb_DimeCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_DimeCount.Size = new System.Drawing.Size(89, 22);
            this.tb_DimeCount.TabIndex = 11;
            this.tb_DimeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_DimeCount.TextChanged += new System.EventHandler(this.tb_DimeCount_TextChanged);
            // 
            // tb_NickelCount
            // 
            this.tb_NickelCount.Location = new System.Drawing.Point(1433, 158);
            this.tb_NickelCount.Name = "tb_NickelCount";
            this.tb_NickelCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_NickelCount.Size = new System.Drawing.Size(89, 22);
            this.tb_NickelCount.TabIndex = 12;
            this.tb_NickelCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_NickelCount.TextChanged += new System.EventHandler(this.tb_NickelCount_TextChanged);
            // 
            // tb_PennyCount
            // 
            this.tb_PennyCount.Location = new System.Drawing.Point(1433, 186);
            this.tb_PennyCount.Name = "tb_PennyCount";
            this.tb_PennyCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_PennyCount.Size = new System.Drawing.Size(89, 22);
            this.tb_PennyCount.TabIndex = 13;
            this.tb_PennyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_PennyCount.TextChanged += new System.EventHandler(this.tb_PennyCount_TextChanged);
            // 
            // label_QuarterCount
            // 
            this.label_QuarterCount.AutoSize = true;
            this.label_QuarterCount.Location = new System.Drawing.Point(1329, 102);
            this.label_QuarterCount.Name = "label_QuarterCount";
            this.label_QuarterCount.Size = new System.Drawing.Size(98, 17);
            this.label_QuarterCount.TabIndex = 14;
            this.label_QuarterCount.Text = "Quarter Count";
            this.label_QuarterCount.Click += new System.EventHandler(this.label_QuarterCount_Click);
            // 
            // label_DimeCount
            // 
            this.label_DimeCount.AutoSize = true;
            this.label_DimeCount.Location = new System.Drawing.Point(1329, 130);
            this.label_DimeCount.Name = "label_DimeCount";
            this.label_DimeCount.Size = new System.Drawing.Size(81, 17);
            this.label_DimeCount.TabIndex = 15;
            this.label_DimeCount.Text = "Dime Count";
            this.label_DimeCount.Click += new System.EventHandler(this.label_DimeCount_Click);
            // 
            // label_NickelCount
            // 
            this.label_NickelCount.AutoSize = true;
            this.label_NickelCount.Location = new System.Drawing.Point(1329, 158);
            this.label_NickelCount.Name = "label_NickelCount";
            this.label_NickelCount.Size = new System.Drawing.Size(87, 17);
            this.label_NickelCount.TabIndex = 16;
            this.label_NickelCount.Text = "Nickel Count";
            this.label_NickelCount.Click += new System.EventHandler(this.label_NickelCount_Click);
            // 
            // label_PennyCount
            // 
            this.label_PennyCount.AutoSize = true;
            this.label_PennyCount.Location = new System.Drawing.Point(1329, 186);
            this.label_PennyCount.Name = "label_PennyCount";
            this.label_PennyCount.Size = new System.Drawing.Size(89, 17);
            this.label_PennyCount.TabIndex = 17;
            this.label_PennyCount.Text = "Penny Count";
            this.label_PennyCount.Click += new System.EventHandler(this.label_PennyCount_Click);
            // 
            // btn_FreshWater
            // 
            this.btn_FreshWater.Location = new System.Drawing.Point(497, 545);
            this.btn_FreshWater.Name = "btn_FreshWater";
            this.btn_FreshWater.Size = new System.Drawing.Size(182, 92);
            this.btn_FreshWater.TabIndex = 18;
            this.btn_FreshWater.Text = "Fresh Water";
            this.btn_FreshWater.UseVisualStyleBackColor = true;
            this.btn_FreshWater.Click += new System.EventHandler(this.btn_FreshWater_Click);
            // 
            // btn_SodaPop
            // 
            this.btn_SodaPop.Location = new System.Drawing.Point(730, 545);
            this.btn_SodaPop.Name = "btn_SodaPop";
            this.btn_SodaPop.Size = new System.Drawing.Size(182, 92);
            this.btn_SodaPop.TabIndex = 19;
            this.btn_SodaPop.Text = "Soda Pop";
            this.btn_SodaPop.UseVisualStyleBackColor = true;
            this.btn_SodaPop.Click += new System.EventHandler(this.btn_SodaPop_Click);
            // 
            // btn_Lemonade
            // 
            this.btn_Lemonade.Location = new System.Drawing.Point(963, 545);
            this.btn_Lemonade.Name = "btn_Lemonade";
            this.btn_Lemonade.Size = new System.Drawing.Size(182, 92);
            this.btn_Lemonade.TabIndex = 20;
            this.btn_Lemonade.Text = "Lemonade";
            this.btn_Lemonade.UseVisualStyleBackColor = true;
            this.btn_Lemonade.Click += new System.EventHandler(this.btn_Lemonade_Click);
            // 
            // label_Drinks
            // 
            this.label_Drinks.AutoSize = true;
            this.label_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Drinks.Location = new System.Drawing.Point(745, 471);
            this.label_Drinks.Name = "label_Drinks";
            this.label_Drinks.Size = new System.Drawing.Size(144, 29);
            this.label_Drinks.TabIndex = 21;
            this.label_Drinks.Text = "D R I N K S";
            this.label_Drinks.Click += new System.EventHandler(this.label_Drinks_Click);
            // 
            // btn_CoinReturn
            // 
            this.btn_CoinReturn.Location = new System.Drawing.Point(1407, 462);
            this.btn_CoinReturn.Name = "btn_CoinReturn";
            this.btn_CoinReturn.Size = new System.Drawing.Size(115, 175);
            this.btn_CoinReturn.TabIndex = 22;
            this.btn_CoinReturn.Text = "Coin\r\nReturn";
            this.btn_CoinReturn.UseVisualStyleBackColor = true;
            this.btn_CoinReturn.Click += new System.EventHandler(this.btn_CoinReturn_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(86, 336);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(99, 98);
            this.btn_Start.TabIndex = 23;
            this.btn_Start.Text = "start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Vend
            // 
            this.btn_Vend.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vend.Location = new System.Drawing.Point(497, 662);
            this.btn_Vend.Name = "btn_Vend";
            this.btn_Vend.Size = new System.Drawing.Size(648, 103);
            this.btn_Vend.TabIndex = 24;
            this.btn_Vend.Text = "VEND";
            this.btn_Vend.UseVisualStyleBackColor = true;
            this.btn_Vend.Click += new System.EventHandler(this.btn_Vend_Click);
            // 
            // tb_DrinkDisp
            // 
            this.tb_DrinkDisp.Location = new System.Drawing.Point(730, 503);
            this.tb_DrinkDisp.Name = "tb_DrinkDisp";
            this.tb_DrinkDisp.Size = new System.Drawing.Size(182, 22);
            this.tb_DrinkDisp.TabIndex = 25;
            this.tb_DrinkDisp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VendingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 777);
            this.Controls.Add(this.tb_DrinkDisp);
            this.Controls.Add(this.btn_Vend);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_CoinReturn);
            this.Controls.Add(this.label_Drinks);
            this.Controls.Add(this.btn_Lemonade);
            this.Controls.Add(this.btn_SodaPop);
            this.Controls.Add(this.btn_FreshWater);
            this.Controls.Add(this.label_PennyCount);
            this.Controls.Add(this.label_NickelCount);
            this.Controls.Add(this.label_DimeCount);
            this.Controls.Add(this.label_QuarterCount);
            this.Controls.Add(this.tb_PennyCount);
            this.Controls.Add(this.tb_NickelCount);
            this.Controls.Add(this.tb_DimeCount);
            this.Controls.Add(this.tb_QuarterCount);
            this.Controls.Add(this.label_Inputs);
            this.Controls.Add(this.label_JVend);
            this.Controls.Add(this.lable_CVend);
            this.Controls.Add(this.tb_JVend);
            this.Controls.Add(this.tbCVend);
            this.Controls.Add(this.Pennies);
            this.Controls.Add(this.Nickels);
            this.Controls.Add(this.Dimes);
            this.Controls.Add(this.btnQuarters);
            this.Name = "VendingUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuarters;
        private System.Windows.Forms.Button Dimes;
        private System.Windows.Forms.Button Nickels;
        private System.Windows.Forms.Button Pennies;
        private System.Windows.Forms.TextBox tbCVend;
        private System.Windows.Forms.TextBox tb_JVend;
        private System.Windows.Forms.Label lable_CVend;
        private System.Windows.Forms.Label label_JVend;
        private System.Windows.Forms.Label label_Inputs;
        private System.Windows.Forms.TextBox tb_QuarterCount;
        private System.Windows.Forms.TextBox tb_DimeCount;
        private System.Windows.Forms.TextBox tb_NickelCount;
        private System.Windows.Forms.TextBox tb_PennyCount;
        private System.Windows.Forms.Label label_QuarterCount;
        private System.Windows.Forms.Label label_DimeCount;
        private System.Windows.Forms.Label label_NickelCount;
        private System.Windows.Forms.Label label_PennyCount;
        private System.Windows.Forms.Button btn_FreshWater;
        private System.Windows.Forms.Button btn_SodaPop;
        private System.Windows.Forms.Button btn_Lemonade;
        private System.Windows.Forms.Label label_Drinks;
        private System.Windows.Forms.Button btn_CoinReturn;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Vend;
        private System.Windows.Forms.TextBox tb_DrinkDisp;
    }
}

