using System;
using System.Windows.Forms;

namespace Lab9_database
{
    public partial class formHousehold_user : Form
    {
        public formHousehold_user()
        {
            InitializeComponent();
        }

        private void formHousehold_user_Load(object sender, EventArgs e)
        {
            this.householdTableAdapter.Fill(this.zooDataSet.Household);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Zoo_main_user form = new Zoo_main_user();
            form.Show();
            this.Hide();
        }
    }
}