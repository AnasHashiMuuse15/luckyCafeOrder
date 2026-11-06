using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LuckyCafeOrder
{
    public partial class LuckyCafeOrder: Form
    {
        public LuckyCafeOrder()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text.Trim();

            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            if (!customerName.All(char.IsLetter))
            {
                MessageBox.Show("Name must contain letters only.");
                return;
            }
            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

           
            decimal price = 0;
            string drink = "";

            if (rbTea.Checked)
            {
                price = 1;
                drink = "Tea";
            }
            else if (rbCoffee.Checked)
            {
                price = 2;
                drink = "Coffee";
            }
            else if (rbJuice.Checked)
            {
                price = 3;
                drink = "Juice";
            }
            else
            {
                MessageBox.Show("Please select a drink.");
                return;
            }




            lstOrders.Items.Clear();


            Random random = new Random();
            bool hasPrize = false;

            for (int i = 1; i <= quantity; i++)
            {
                int luckynumb = random.Next(1, 51);

                if (luckynumb == 7 || luckynumb == 17)
                {
                    hasPrize = true;
                }

                string order = i + ") " + customerName +
                               " - " + drink +
                               " - Lucky: " + luckynumb +
                               " - $" + price.ToString("0.00");

                lstOrders.Items.Add(order);
            }

            if (hasPrize)
            {
                lblLucky.Text = "You got a Free Cookie!";
                lstOrders.Items.Add("");
                lstOrders.Items.Add("");
                lstOrders.Items.Add("");
                lstOrders.Items.Add("Congratulations! You got a Free Cookie!");
            }
            else
            {
                lblLucky.Text = "No prize this time.";
            }
            decimal beforeDiscount = price * quantity;
            decimal discountAmount = 0;
            decimal discountPercentage = 0;

            if (chkStudent.Checked)
            {
                discountPercentage = 10;
                discountAmount = beforeDiscount * 0.10m;
            }

            decimal afterDiscount = beforeDiscount - discountAmount;

            lstOrders.Items.Add("");
            lstOrders.Items.Add("");


            lstOrders.Items.Add("Before Discount: $" + beforeDiscount.ToString("0.00"));
            lstOrders.Items.Add("Discount: " + discountPercentage + "%");
            lstOrders.Items.Add("Discount Amount: $" + discountAmount.ToString("0.00"));
            lstOrders.Items.Add("After Discount: $" + afterDiscount.ToString("0.00"));

            lblTotal.Text = "Total Price: $" + afterDiscount.ToString("0.00");

        }
        

        private void lblLucky_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            StreamWriter writer = File.AppendText("orders.txt");

            
            for (int i = 0; i < lstOrders.Items.Count; i++)
            {
                writer.WriteLine(lstOrders.Items[i].ToString());
            }

            
            writer.WriteLine(lblTotal.Text);
            writer.WriteLine(lblLucky.Text);
            writer.WriteLine("");

            
            writer.Close();

            MessageBox.Show("Order saved.");

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("No file found.");
                return;
            }

            lstOrders.Items.Clear();

            StreamReader reader = File.OpenText("orders.txt");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                lstOrders.Items.Add(line);
            }

            reader.Close();

            MessageBox.Show("Orders loaded successfully.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtQuantity.Clear();

            lstOrders.Items.Clear();

            lblTotal.Text = "Total Price: $0.00";
            lblLucky.Text = "No prize this time.";

            chkStudent.Checked = false;

            rbTea.Checked = false;
            rbCoffee.Checked = false;
            rbJuice.Checked = false;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void LuckyCafeOrder_Load(object sender, EventArgs e)
        {

        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
