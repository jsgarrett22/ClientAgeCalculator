using System;
using System.Windows.Forms;

namespace ClientAgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime DOB = datePicker.Value;

            int age = today.Year - DOB.Year;

            if (DOB.Date > today.AddYears(-age))
                age--;

            displayAge.Text = age.ToString();
            displayName.Text = $"{txtFirstName.Text} {txtLastName.Text}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
