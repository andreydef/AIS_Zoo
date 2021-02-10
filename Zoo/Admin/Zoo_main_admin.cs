using System;
using System.Windows.Forms;
using Lab9_database.Admin;

namespace Lab9_database
{
    public partial class Zoo_main_admin : Form
    {
        public Zoo_main_admin()
        {
            InitializeComponent();
        }

        private void Zoo_main_admin_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Users.status;
        }

        private void labelHousehold_Click(object sender, EventArgs e)
        {
            formHousehold_admin form = new formHousehold_admin();
            form.Show();
            this.Hide();
        }

        private void labelZooAnimal_Click(object sender, EventArgs e)
        {
            formAnimals_admin form = new formAnimals_admin();
            form.Show();
            this.Hide();
        }

        private void labelOrderTicket_Click(object sender, EventArgs e)
        {
            formOrderTickets_admin form = new formOrderTickets_admin();
            form.Show();
            this.Hide();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Users.username = "";
            Users.userpassword = "";
            Users.status = "";

            formLogin form = new formLogin();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}