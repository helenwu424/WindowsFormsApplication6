using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shippingnamespace;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
   { private shipping s;
        public Form1()
            
        {
           
           InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = new shipping();

            decimal price = 0.0m;
            label3.Text += "Item:  " + listBox1.Text + "\r\n";

            label3.Text += "Quantity:  " + comboBox1.Text;

            if (listBox1.Text == "Placemats $10")
            {
                price = 10.00m;
                price = price * Convert.ToDecimal(comboBox1.Text);

                if (radioButton1.Checked)
                {
                    price = s.Total_Charges(price);
                    label3.Text += " \r\n" + "Total Price:  " + price.ToString();
                }
                else if (radioButton2.Checked)
                {
                    price = s.Add_Overnight(price);
                    label3.Text += " \r\n" + "Total Price:  " + price.ToString();
                }

                }
            }

        }
    }

