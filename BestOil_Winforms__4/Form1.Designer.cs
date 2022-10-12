namespace BestOil_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_auto = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox_choice = new System.Windows.Forms.GroupBox();
            this.rbtn_cash = new System.Windows.Forms.RadioButton();
            this.rbtn_liter = new System.Windows.Forms.RadioButton();
            this.tbox_cash = new System.Windows.Forms.TextBox();
            this.tbox_liter = new System.Windows.Forms.TextBox();
            this.gbox_resultAuto = new System.Windows.Forms.GroupBox();
            this.lbl_resultAuto = new System.Windows.Forms.Label();
            this.tbox_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.cbox_fuels = new System.Windows.Forms.ComboBox();
            this.lbl_fuel = new System.Windows.Forms.Label();
            this.gbox_minibar = new System.Windows.Forms.GroupBox();
            this.tbox_cokePrice = new System.Windows.Forms.TextBox();
            this.tbox_friesPrice = new System.Windows.Forms.TextBox();
            this.tbox_hamPrice = new System.Windows.Forms.TextBox();
            this.tbox_hdPrice = new System.Windows.Forms.TextBox();
            this.tbox_coke = new System.Windows.Forms.TextBox();
            this.tbox_fries = new System.Windows.Forms.TextBox();
            this.tbox_ham = new System.Windows.Forms.TextBox();
            this.tbox_hd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_coke = new System.Windows.Forms.CheckBox();
            this.cbox_frenchFries = new System.Windows.Forms.CheckBox();
            this.gbox_resultBar = new System.Windows.Forms.GroupBox();
            this.lbl_resultBar = new System.Windows.Forms.Label();
            this.cbox_hamburger = new System.Windows.Forms.CheckBox();
            this.cbox_hotdog = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.gbox_auto.SuspendLayout();
            this.gbox_choice.SuspendLayout();
            this.gbox_resultAuto.SuspendLayout();
            this.gbox_minibar.SuspendLayout();
            this.gbox_resultBar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_auto
            // 
            this.gbox_auto.Controls.Add(this.label3);
            this.gbox_auto.Controls.Add(this.label2);
            this.gbox_auto.Controls.Add(this.label1);
            this.gbox_auto.Controls.Add(this.gbox_choice);
            this.gbox_auto.Controls.Add(this.tbox_cash);
            this.gbox_auto.Controls.Add(this.tbox_liter);
            this.gbox_auto.Controls.Add(this.gbox_resultAuto);
            this.gbox_auto.Controls.Add(this.tbox_price);
            this.gbox_auto.Controls.Add(this.lbl_price);
            this.gbox_auto.Controls.Add(this.cbox_fuels);
            this.gbox_auto.Controls.Add(this.lbl_fuel);
            this.gbox_auto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbox_auto.Location = new System.Drawing.Point(60, 49);
            this.gbox_auto.Name = "gbox_auto";
            this.gbox_auto.Size = new System.Drawing.Size(303, 392);
            this.gbox_auto.TabIndex = 0;
            this.gbox_auto.TabStop = false;
            this.gbox_auto.Text = "Auto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(283, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(283, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "$";
            // 
            // gbox_choice
            // 
            this.gbox_choice.Controls.Add(this.rbtn_cash);
            this.gbox_choice.Controls.Add(this.rbtn_liter);
            this.gbox_choice.Location = new System.Drawing.Point(6, 152);
            this.gbox_choice.Name = "gbox_choice";
            this.gbox_choice.Size = new System.Drawing.Size(146, 83);
            this.gbox_choice.TabIndex = 6;
            this.gbox_choice.TabStop = false;
            // 
            // rbtn_cash
            // 
            this.rbtn_cash.AutoSize = true;
            this.rbtn_cash.Enabled = false;
            this.rbtn_cash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_cash.Location = new System.Drawing.Point(6, 54);
            this.rbtn_cash.Name = "rbtn_cash";
            this.rbtn_cash.Size = new System.Drawing.Size(62, 25);
            this.rbtn_cash.TabIndex = 1;
            this.rbtn_cash.TabStop = true;
            this.rbtn_cash.Text = "Cash";
            this.rbtn_cash.UseVisualStyleBackColor = true;
            this.rbtn_cash.CheckedChanged += new System.EventHandler(this.rbtn_cash_CheckedChanged);
            // 
            // rbtn_liter
            // 
            this.rbtn_liter.AutoSize = true;
            this.rbtn_liter.Enabled = false;
            this.rbtn_liter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_liter.Location = new System.Drawing.Point(6, 18);
            this.rbtn_liter.Name = "rbtn_liter";
            this.rbtn_liter.Size = new System.Drawing.Size(59, 25);
            this.rbtn_liter.TabIndex = 0;
            this.rbtn_liter.TabStop = true;
            this.rbtn_liter.Text = "Liter";
            this.rbtn_liter.UseVisualStyleBackColor = true;
            this.rbtn_liter.CheckedChanged += new System.EventHandler(this.rbtn_liter_CheckedChanged);
            // 
            // tbox_cash
            // 
            this.tbox_cash.Enabled = false;
            this.tbox_cash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_cash.Location = new System.Drawing.Point(169, 206);
            this.tbox_cash.Name = "tbox_cash";
            this.tbox_cash.Size = new System.Drawing.Size(108, 29);
            this.tbox_cash.TabIndex = 7;
            this.tbox_cash.Text = "0";
            this.tbox_cash.TextChanged += new System.EventHandler(this.tbox_cash_TextChanged);
            // 
            // tbox_liter
            // 
            this.tbox_liter.Enabled = false;
            this.tbox_liter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_liter.Location = new System.Drawing.Point(169, 166);
            this.tbox_liter.Name = "tbox_liter";
            this.tbox_liter.Size = new System.Drawing.Size(108, 29);
            this.tbox_liter.TabIndex = 6;
            this.tbox_liter.Text = "0";
            this.tbox_liter.TextChanged += new System.EventHandler(this.tbox_liter_TextChanged);
            // 
            // gbox_resultAuto
            // 
            this.gbox_resultAuto.Controls.Add(this.lbl_resultAuto);
            this.gbox_resultAuto.Location = new System.Drawing.Point(6, 241);
            this.gbox_resultAuto.Name = "gbox_resultAuto";
            this.gbox_resultAuto.Size = new System.Drawing.Size(271, 145);
            this.gbox_resultAuto.TabIndex = 5;
            this.gbox_resultAuto.TabStop = false;
            this.gbox_resultAuto.Text = "Result";
            // 
            // lbl_resultAuto
            // 
            this.lbl_resultAuto.AutoSize = true;
            this.lbl_resultAuto.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultAuto.Location = new System.Drawing.Point(97, 66);
            this.lbl_resultAuto.Name = "lbl_resultAuto";
            this.lbl_resultAuto.Size = new System.Drawing.Size(83, 59);
            this.lbl_resultAuto.TabIndex = 0;
            this.lbl_resultAuto.Text = "0 $";
            this.lbl_resultAuto.Visible = false;
            // 
            // tbox_price
            // 
            this.tbox_price.Enabled = false;
            this.tbox_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_price.Location = new System.Drawing.Point(103, 105);
            this.tbox_price.Name = "tbox_price";
            this.tbox_price.Size = new System.Drawing.Size(174, 29);
            this.tbox_price.TabIndex = 3;
            this.tbox_price.Text = "0";
            this.tbox_price.TextChanged += new System.EventHandler(this.tbox_price_TextChanged);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(6, 105);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(60, 30);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Price";
            // 
            // cbox_fuels
            // 
            this.cbox_fuels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_fuels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_fuels.FormattingEnabled = true;
            this.cbox_fuels.Location = new System.Drawing.Point(103, 54);
            this.cbox_fuels.Name = "cbox_fuels";
            this.cbox_fuels.Size = new System.Drawing.Size(174, 29);
            this.cbox_fuels.TabIndex = 1;
            this.cbox_fuels.SelectedIndexChanged += new System.EventHandler(this.cbox_fuels_SelectedIndexChanged);
            // 
            // lbl_fuel
            // 
            this.lbl_fuel.AutoSize = true;
            this.lbl_fuel.Location = new System.Drawing.Point(6, 50);
            this.lbl_fuel.Name = "lbl_fuel";
            this.lbl_fuel.Size = new System.Drawing.Size(53, 30);
            this.lbl_fuel.TabIndex = 0;
            this.lbl_fuel.Text = "Fuel";
            // 
            // gbox_minibar
            // 
            this.gbox_minibar.Controls.Add(this.tbox_cokePrice);
            this.gbox_minibar.Controls.Add(this.tbox_friesPrice);
            this.gbox_minibar.Controls.Add(this.tbox_hamPrice);
            this.gbox_minibar.Controls.Add(this.tbox_hdPrice);
            this.gbox_minibar.Controls.Add(this.tbox_coke);
            this.gbox_minibar.Controls.Add(this.tbox_fries);
            this.gbox_minibar.Controls.Add(this.tbox_ham);
            this.gbox_minibar.Controls.Add(this.tbox_hd);
            this.gbox_minibar.Controls.Add(this.label6);
            this.gbox_minibar.Controls.Add(this.label5);
            this.gbox_minibar.Controls.Add(this.cbox_coke);
            this.gbox_minibar.Controls.Add(this.cbox_frenchFries);
            this.gbox_minibar.Controls.Add(this.gbox_resultBar);
            this.gbox_minibar.Controls.Add(this.cbox_hamburger);
            this.gbox_minibar.Controls.Add(this.cbox_hotdog);
            this.gbox_minibar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbox_minibar.Location = new System.Drawing.Point(400, 49);
            this.gbox_minibar.Name = "gbox_minibar";
            this.gbox_minibar.Size = new System.Drawing.Size(303, 392);
            this.gbox_minibar.TabIndex = 1;
            this.gbox_minibar.TabStop = false;
            this.gbox_minibar.Text = "Mini Bar";
            // 
            // tbox_cokePrice
            // 
            this.tbox_cokePrice.Enabled = false;
            this.tbox_cokePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_cokePrice.Location = new System.Drawing.Point(247, 174);
            this.tbox_cokePrice.Name = "tbox_cokePrice";
            this.tbox_cokePrice.Size = new System.Drawing.Size(50, 29);
            this.tbox_cokePrice.TabIndex = 18;
            this.tbox_cokePrice.Text = "0";
            this.tbox_cokePrice.TextChanged += new System.EventHandler(this.tbox_cokePrice_TextChanged);
            // 
            // tbox_friesPrice
            // 
            this.tbox_friesPrice.Enabled = false;
            this.tbox_friesPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_friesPrice.Location = new System.Drawing.Point(247, 134);
            this.tbox_friesPrice.Name = "tbox_friesPrice";
            this.tbox_friesPrice.Size = new System.Drawing.Size(50, 29);
            this.tbox_friesPrice.TabIndex = 17;
            this.tbox_friesPrice.Text = "0";
            this.tbox_friesPrice.TextChanged += new System.EventHandler(this.tbox_friesPrice_TextChanged);
            // 
            // tbox_hamPrice
            // 
            this.tbox_hamPrice.Enabled = false;
            this.tbox_hamPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_hamPrice.Location = new System.Drawing.Point(245, 94);
            this.tbox_hamPrice.Name = "tbox_hamPrice";
            this.tbox_hamPrice.Size = new System.Drawing.Size(50, 29);
            this.tbox_hamPrice.TabIndex = 16;
            this.tbox_hamPrice.Text = "0";
            this.tbox_hamPrice.TextChanged += new System.EventHandler(this.tbox_hamPrice_TextChanged);
            // 
            // tbox_hdPrice
            // 
            this.tbox_hdPrice.Enabled = false;
            this.tbox_hdPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_hdPrice.Location = new System.Drawing.Point(245, 54);
            this.tbox_hdPrice.Name = "tbox_hdPrice";
            this.tbox_hdPrice.Size = new System.Drawing.Size(50, 29);
            this.tbox_hdPrice.TabIndex = 15;
            this.tbox_hdPrice.Text = "0";
            this.tbox_hdPrice.TextChanged += new System.EventHandler(this.tbox_hdPrice_TextChanged);
            // 
            // tbox_coke
            // 
            this.tbox_coke.Enabled = false;
            this.tbox_coke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_coke.Location = new System.Drawing.Point(167, 174);
            this.tbox_coke.Name = "tbox_coke";
            this.tbox_coke.Size = new System.Drawing.Size(52, 29);
            this.tbox_coke.TabIndex = 14;
            this.tbox_coke.Text = "4,40";
            // 
            // tbox_fries
            // 
            this.tbox_fries.Enabled = false;
            this.tbox_fries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_fries.Location = new System.Drawing.Point(167, 134);
            this.tbox_fries.Name = "tbox_fries";
            this.tbox_fries.Size = new System.Drawing.Size(52, 29);
            this.tbox_fries.TabIndex = 13;
            this.tbox_fries.Text = "7,20";
            // 
            // tbox_ham
            // 
            this.tbox_ham.Enabled = false;
            this.tbox_ham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_ham.Location = new System.Drawing.Point(167, 94);
            this.tbox_ham.Name = "tbox_ham";
            this.tbox_ham.Size = new System.Drawing.Size(52, 29);
            this.tbox_ham.TabIndex = 12;
            this.tbox_ham.Text = "5,40";
            // 
            // tbox_hd
            // 
            this.tbox_hd.Enabled = false;
            this.tbox_hd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_hd.Location = new System.Drawing.Point(167, 54);
            this.tbox_hd.Name = "tbox_hd";
            this.tbox_hd.Size = new System.Drawing.Size(52, 29);
            this.tbox_hd.TabIndex = 11;
            this.tbox_hd.Text = "4,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(245, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(167, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // cbox_coke
            // 
            this.cbox_coke.AutoSize = true;
            this.cbox_coke.Location = new System.Drawing.Point(6, 169);
            this.cbox_coke.Name = "cbox_coke";
            this.cbox_coke.Size = new System.Drawing.Size(82, 34);
            this.cbox_coke.TabIndex = 8;
            this.cbox_coke.Text = "Pepsi";
            this.cbox_coke.UseVisualStyleBackColor = true;
            this.cbox_coke.CheckedChanged += new System.EventHandler(this.cbox_coke_CheckedChanged);
            // 
            // cbox_frenchFries
            // 
            this.cbox_frenchFries.AutoSize = true;
            this.cbox_frenchFries.Location = new System.Drawing.Point(6, 129);
            this.cbox_frenchFries.Name = "cbox_frenchFries";
            this.cbox_frenchFries.Size = new System.Drawing.Size(148, 34);
            this.cbox_frenchFries.TabIndex = 7;
            this.cbox_frenchFries.Text = "French Fries";
            this.cbox_frenchFries.UseVisualStyleBackColor = true;
            this.cbox_frenchFries.CheckedChanged += new System.EventHandler(this.cbox_frenchFries_CheckedChanged);
            // 
            // gbox_resultBar
            // 
            this.gbox_resultBar.Controls.Add(this.lbl_resultBar);
            this.gbox_resultBar.Location = new System.Drawing.Point(6, 241);
            this.gbox_resultBar.Name = "gbox_resultBar";
            this.gbox_resultBar.Size = new System.Drawing.Size(271, 145);
            this.gbox_resultBar.TabIndex = 6;
            this.gbox_resultBar.TabStop = false;
            this.gbox_resultBar.Text = "Result";
            // 
            // lbl_resultBar
            // 
            this.lbl_resultBar.AutoSize = true;
            this.lbl_resultBar.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultBar.Location = new System.Drawing.Point(97, 66);
            this.lbl_resultBar.Name = "lbl_resultBar";
            this.lbl_resultBar.Size = new System.Drawing.Size(83, 59);
            this.lbl_resultBar.TabIndex = 0;
            this.lbl_resultBar.Text = "0 $";
            this.lbl_resultBar.Visible = false;
            // 
            // cbox_hamburger
            // 
            this.cbox_hamburger.AutoSize = true;
            this.cbox_hamburger.Location = new System.Drawing.Point(6, 89);
            this.cbox_hamburger.Name = "cbox_hamburger";
            this.cbox_hamburger.Size = new System.Drawing.Size(144, 34);
            this.cbox_hamburger.TabIndex = 1;
            this.cbox_hamburger.Text = "Hamburger";
            this.cbox_hamburger.UseVisualStyleBackColor = true;
            this.cbox_hamburger.CheckedChanged += new System.EventHandler(this.cbox_hamburger_CheckedChanged);
            // 
            // cbox_hotdog
            // 
            this.cbox_hotdog.AutoSize = true;
            this.cbox_hotdog.Location = new System.Drawing.Point(6, 49);
            this.cbox_hotdog.Name = "cbox_hotdog";
            this.cbox_hotdog.Size = new System.Drawing.Size(118, 34);
            this.cbox_hotdog.TabIndex = 0;
            this.cbox_hotdog.Text = "Hot-Dog";
            this.cbox_hotdog.UseVisualStyleBackColor = true;
            this.cbox_hotdog.CheckedChanged += new System.EventHandler(this.cbox_hotdog_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_totalPrice);
            this.groupBox3.Controls.Add(this.btn_check);
            this.groupBox3.Location = new System.Drawing.Point(60, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 170);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalPrice.Location = new System.Drawing.Point(414, 94);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(0, 59);
            this.lbl_totalPrice.TabIndex = 1;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(103, 84);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(174, 69);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(764, 677);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbox_minibar);
            this.Controls.Add(this.gbox_auto);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 716);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_auto.ResumeLayout(false);
            this.gbox_auto.PerformLayout();
            this.gbox_choice.ResumeLayout(false);
            this.gbox_choice.PerformLayout();
            this.gbox_resultAuto.ResumeLayout(false);
            this.gbox_resultAuto.PerformLayout();
            this.gbox_minibar.ResumeLayout(false);
            this.gbox_minibar.PerformLayout();
            this.gbox_resultBar.ResumeLayout(false);
            this.gbox_resultBar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbox_auto;
        private Label lbl_fuel;
        private GroupBox gbox_minibar;
        private GroupBox groupBox3;
        private ComboBox cbox_fuels;
        private TextBox tbox_price;
        private Label lbl_price;
        private TextBox tbox_cash;
        private TextBox tbox_liter;
        private GroupBox gbox_resultAuto;
        private GroupBox gbox_choice;
        private RadioButton rbtn_liter;
        private RadioButton rbtn_cash;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lbl_resultAuto;
        private TextBox tbox_coke;
        private TextBox tbox_fries;
        private TextBox tbox_ham;
        private TextBox tbox_hd;
        private Label label6;
        private Label label5;
        private CheckBox cbox_coke;
        private CheckBox cbox_frenchFries;
        private GroupBox gbox_resultBar;
        private Label lbl_resultBar;
        private CheckBox cbox_hamburger;
        private CheckBox cbox_hotdog;
        private TextBox tbox_cokePrice;
        private TextBox tbox_friesPrice;
        private TextBox tbox_hamPrice;
        private TextBox tbox_hdPrice;
        private Label lbl_totalPrice;
        private Button btn_check;
    }
}