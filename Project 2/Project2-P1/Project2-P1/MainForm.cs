using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_P1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dlUnits.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Assure a valid value
            string value = tbKilometers.Text;
            try
            {
                double.Parse(value);
            }
            catch
            {
                tbConvertedLength.Text = string.Empty;
                MessageBox.Show("Please enter a valid length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Get the units to convert to
            Length.Units newUnit;
            switch (dlUnits.Text.ToLower())
            {
                case "miles":   newUnit = Length.Units.Miles;   break;
                case "yards":   newUnit = Length.Units.Yards;   break;
                case "feet":    newUnit = Length.Units.Feet;    break;
                default:        newUnit = Length.Units.None;    break;
            }

            // Setup the Chain of Responsibility
            Miles miles = new Miles(value);
            Yards yards = new Yards(value);
            Feet feet = new Feet(value);
            miles.SetSuccessor(yards);
            yards.SetSuccessor(feet);

            // Convert kilometers to new units
            value = miles.HandleRequest(newUnit);

            // Display the converted value
            tbConvertedLength.Text = value;
        }
    }
}
