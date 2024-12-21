using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI___Body_mass_index___calculator
{
    public partial class Form1 : Form
    {
        decimal weight, height;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void checkW_Click(object sender, EventArgs e)
        {
            weight = decimal.Parse(weightBox.Text);
            height = decimal.Parse(heightBox.Text);
            if (weight < 0)
            {
                MessageBox.Show("Value entered cannot be negative", "Result");
                weightBox.Clear();
            }
            else
            {
                MessageBox.Show("Value entered is valid", "Result");
            }
        }

        private void BMIbtn_Click(object sender, EventArgs e)
        {
            decimal bmi;
            DialogResult buttonchoice;
            buttonchoice = MessageBox.Show("ARE THE VALUES CORRECT?", "Confirmation", MessageBoxButtons.YesNo);

            if(buttonchoice==DialogResult.No)
            {
                weightBox.Text = " ";
                heightBox.Text = " ";
            }
            else
            {
                bmi = weight / (height * height);
                BMIBox.Text = bmi.ToString("N2");
            }
        }
    }
}
