using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningInheritance
{
    //now program looks way better then previous one. Now i am satisfied!
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)numericBirthday.Value, fancyBirthday.Checked, cakeWritting.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {       
            decimal Cost = dinnerParty.Cost;
            totalCostLabel.Text = Cost.ToString("c");
        }
        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWrittingTooLong;
            decimal Cost = birthdayParty.Cost;
            birthdayCostLabel.Text = Cost.ToString("c");
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //TODO!
            //How to delete method w/o making problems(??)        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWritting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWritting = cakeWritting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
