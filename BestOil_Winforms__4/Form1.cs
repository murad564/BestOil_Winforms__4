namespace BestOil_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> fuels = new()
            {
                "A-92",
                "A-95",
                "A-98",
                "Dizel"
            };
            cbox_fuels.Items.AddRange(fuels.ToArray());


        }

        void lbl_resultBar_ChangeValue()
        {
            if (!(lbl_resultBar.Visible))
                lbl_resultBar.Visible = true;
            lbl_resultBar.Text = (double.Parse(tbox_hd.Text) * double.Parse(tbox_hdPrice.Text)
                + double.Parse(tbox_ham.Text) * double.Parse(tbox_hamPrice.Text)
                + double.Parse(tbox_fries.Text) * double.Parse(tbox_friesPrice.Text)
                + double.Parse(tbox_coke.Text) * double.Parse(tbox_cokePrice.Text)
                ).ToString() + " $";
        }

        private void cbox_fuels_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtn_cash.Enabled = true;
            rbtn_liter.Enabled = true;

            if (cbox_fuels.SelectedItem == cbox_fuels.Items[0])
                tbox_price.Text = "0,60";
            else if (cbox_fuels.SelectedItem == cbox_fuels.Items[1])
                tbox_price.Text = "1,20";
            else if (cbox_fuels.SelectedItem == cbox_fuels.Items[2])
                tbox_price.Text = "1,35";
            else if (cbox_fuels.SelectedItem == cbox_fuels.Items[3])
                tbox_price.Text = "0,50";

        }

        private void rbtn_liter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_liter.Checked)
                tbox_liter.Enabled = true;
            else
            {
                tbox_liter.Enabled = false;
                tbox_liter.Text = "0";
            }
        }

        private void rbtn_cash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_cash.Checked)
                tbox_cash.Enabled = true;
            else
            {
                tbox_cash.Enabled = false;
                tbox_cash.Text = "0";
            }
        }

        private void tbox_liter_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(tbox_liter.Text, out _)) && !(tbox_liter.Text == string.Empty) || tbox_liter.Text.Contains("."))
            {
                MessageBox.Show("Liter must be number and correctly spelled, avoid . (dot)");
                tbox_liter.Text = tbox_liter.Text.Remove(tbox_liter.Text.Length - 1, 1);
            }
            if (!(string.IsNullOrEmpty(tbox_liter.Text)))
            {
                lbl_resultAuto.Visible = true;
                lbl_resultAuto.Text = (double.Parse(tbox_liter.Text) * double.Parse(tbox_price.Text)).ToString() + " $";
            }
        }

        private void tbox_cash_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(tbox_cash.Text, out _)) && !(tbox_cash.Text == string.Empty) || tbox_cash.Text.Contains("."))
            {
                MessageBox.Show("Cash must be number and correctly spelled, avoid . (dot)");
                tbox_cash.Text = tbox_cash.Text.Remove(tbox_cash.Text.Length - 1, 1);
            }
            if (!(string.IsNullOrEmpty(tbox_cash.Text)))
            {
                lbl_resultAuto.Text = (double.Parse(tbox_cash.Text) / double.Parse(tbox_price.Text)).ToString() + " Liter";
                lbl_resultAuto.Visible = true;
            }
        }

        private void tbox_price_TextChanged(object sender, EventArgs e)
        {
            if (tbox_liter.Enabled)
                tbox_liter_TextChanged(sender, e);
            else if (tbox_cash.Enabled)
                tbox_cash_TextChanged(sender, e);
        }

        private void cbox_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_hotdog.Checked)
                tbox_hdPrice.Enabled = true;
            else
            {
                tbox_hdPrice.Enabled = false;
                tbox_hdPrice.Text = "0";
            }
        }

        private void cbox_hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_hamburger.Checked)
                tbox_hamPrice.Enabled = true;
            else
            {
                tbox_hamPrice.Enabled = false;
                tbox_hamPrice.Text = "0";
            }
        }

        private void cbox_frenchFries_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_frenchFries.Checked)
                tbox_friesPrice.Enabled = true;
            else
            {
                tbox_friesPrice.Enabled = false;
                tbox_friesPrice.Text = "0";
            }
        }

        private void cbox_coke_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_coke.Checked)
                tbox_cokePrice.Enabled = true;
            else
            {
                tbox_cokePrice.Enabled = false;
                tbox_cokePrice.Text = "0";
            }
        }

        private void tbox_hdPrice_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(tbox_hdPrice.Text, out _)) && !(tbox_hdPrice.Text == string.Empty) || tbox_hdPrice.Text.Contains(".") || tbox_hdPrice.Text.Contains(","))
            {
                MessageBox.Show("Count must be number and correctly spelled, avoid . (dot) and , (comma)");
                tbox_hdPrice.Text = tbox_hdPrice.Text.Remove(tbox_hdPrice.Text.Length - 1, 1);
            }
            else if (string.IsNullOrEmpty(tbox_hdPrice.Text))
            {
                tbox_hdPrice.Text = "0";
            }
            else lbl_resultBar_ChangeValue();

        }

        private void tbox_hamPrice_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(tbox_hamPrice.Text, out _)) && !(tbox_hamPrice.Text == string.Empty) || tbox_hamPrice.Text.Contains(".") || tbox_hamPrice.Text.Contains(","))
            {
                MessageBox.Show("Count must be number and correctly spelled, avoid . (dot) and , (comma)");
                tbox_hamPrice.Text = tbox_hamPrice.Text.Remove(tbox_hamPrice.Text.Length - 1, 1);
            }
            else if (string.IsNullOrEmpty(tbox_hamPrice.Text))
            {
                tbox_hamPrice.Text = "0";
            }
            else lbl_resultBar_ChangeValue();

        }

        private void tbox_friesPrice_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(tbox_friesPrice.Text, out _)) && !(tbox_friesPrice.Text == string.Empty) || tbox_friesPrice.Text.Contains(".") || tbox_friesPrice.Text.Contains(","))
            {
                MessageBox.Show("Count must be number and correctly spelled, avoid . (dot) and , (comma)");
                tbox_friesPrice.Text = tbox_friesPrice.Text.Remove(tbox_friesPrice.Text.Length - 1, 1);
            }
            else if (string.IsNullOrEmpty(tbox_friesPrice.Text))
            {
                tbox_friesPrice.Text = "0";
            }
            else lbl_resultBar_ChangeValue();

        }

        private void tbox_cokePrice_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(tbox_cokePrice.Text, out _)) && !(tbox_cokePrice.Text == string.Empty) || tbox_cokePrice.Text.Contains(".") || tbox_cokePrice.Text.Contains(","))
            {
                MessageBox.Show("Count must be number and correctly spelled, avoid . (dot) and , (comma)");
                tbox_cokePrice.Text = tbox_cokePrice.Text.Remove(tbox_cokePrice.Text.Length - 1, 1);
            }
            else if (string.IsNullOrEmpty(tbox_cokePrice.Text))
            {
                tbox_cokePrice.Text = "0";
            }
            else lbl_resultBar_ChangeValue();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (rbtn_liter.Checked && (lbl_resultAuto.Visible || lbl_resultBar.Visible))
                lbl_totalPrice.Text = (double.Parse(lbl_resultBar.Text.Remove(lbl_resultBar.Text.Length - 1, 1)) + double.Parse(lbl_resultAuto.Text.Remove(lbl_resultAuto.Text.Length - 1, 1))).ToString() + " $";
            else lbl_totalPrice.Text = (double.Parse(lbl_resultBar.Text.Remove(lbl_resultBar.Text.Length - 1, 1)) + double.Parse(tbox_cash.Text)).ToString() + " $";
        }
    }
}