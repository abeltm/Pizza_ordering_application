using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abel_Pizza
{
    //Abel
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            rbnonveg.Checked = true;
            cmbsize.SelectedIndex = 1;
            txtcouponcode.Text = "";
            txtcusname.Text = "";
            txtphone.Text = "";
            cbcheese.Checked = false;
            cbmas.Checked = false;
            cbolives.Checked = false;
            cboni.Checked = false;
            cbpep.Checked = false;
            cbsau.Checked = false;
            lblqty.Text = "1";
            Pcost.Text = "";
            Ptax.Text = "";
            Ptype.Text = "";
            Psize.Text = "";
            Ptoppings.Text = "";
            Pcusname.Text = "";
            Pphonenum.Text = "";
            Pqty.Text = "";
        }

        private void btnincr_Click(object sender, EventArgs e)
        {
            if (Convert .ToInt32 (lblqty .Text)<5)
            {
                lblqty.Text = (Convert.ToInt32(lblqty.Text) + 1).ToString ();
            }
        }

        private void btndecr_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblqty.Text) > 1)
            {
                lblqty.Text = (Convert.ToInt32(lblqty.Text) - 1).ToString();
            }
        }

        private void btndailyspecial_Click(object sender, EventArgs e)
        {
            cmbsize.SelectedIndex = 2;
            lblqty.Text = "2";
            rbnonveg.Checked = true;
            txtcouponcode.Text = "OFFERSPECIAL";
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            Order obj = new Order();
            Order.customername = txtcusname.Text;
            Order.phonenum = txtphone.Text;
            Order.qty = Convert.ToInt32(lblqty.Text);
            Order.size = cmbsize.Text;
            Order.toppings = new List<string>();
            if (cbcheese .Checked)
            {
                Order.toppings.Add(cbcheese.Text);
            }
            if (cbmas .Checked)
            {
                Order.toppings.Add(cbmas.Text);
            }
            if (cbolives .Checked)
            {
                Order.toppings.Add(cbolives.Text);
            }
            if (cboni .Checked)
            {
                Order.toppings.Add(cboni.Text);

            }
            if (cbpep .Checked)
            {
                Order.toppings.Add(cbpep.Text);
            }
            if (cbsau .Checked)
            {
                Order.toppings.Add(cbsau.Text);
            }
            if (rbnonveg .Checked)
            {
                Order.type = rbnonveg.Text;
            }
            if (rbveg.Checked)
            {
                Order.type = rbveg.Text;
            }
            obj.CalculateCost();
            Pcusname.Text = Order.customername;
            Pphonenum.Text = Order.phonenum;
            Pqty.Text = Order.qty.ToString();
            foreach (var item in Order .toppings)
            {
                Ptoppings.Text = Ptoppings.Text +" "+ item;
            }
            Ptax.Text = Order.TAX.ToString ();
            Ptype.Text = Order.type;
            Psize.Text = Order.size;
            Pcost.Text = Order.totalcost.ToString();
        }
    }
}
