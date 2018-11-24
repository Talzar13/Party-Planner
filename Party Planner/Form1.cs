using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = (int)nudPeople.Value }; //Create new dinnerparty with people equal to default.
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(chbFancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            dinnerParty.NumberOfPeople = (int)nudPeople.Value;
            dinnerParty.CalculateCostOfDecorations(chbFancyDecorations.Checked);
            dinnerParty.SetHealthyOption(chbHealthyOption.Checked);
            decimal Cost = dinnerParty.CalculateCost(chbHealthyOption.Checked);
            lblCost.Text = Cost.ToString("c");

           // TestData();
        }

        private void nudPeople_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void chbFancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void chbHealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void TestData()
        {
            TestBox.Items.Add(dinnerParty.CostOfDecorations);

        }
    }
}
