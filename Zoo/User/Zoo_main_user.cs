using System;
using System.Windows.Forms;
using Lab9_database.User;

namespace Lab9_database
{
    public partial class Zoo_main_user : Form
    {
        public Zoo_main_user()
        {
            InitializeComponent();
        }

        private void labelHousehold_Click(object sender, EventArgs e)
        {
            formHousehold_user form = new formHousehold_user();
            form.Show();
            this.Hide();
        }

        private void labelZooAnimal_Click(object sender, EventArgs e)
        {
            formAnimals_user form = new formAnimals_user();
            form.Show();
            this.Hide();
        }

        private void labelOrderTicket_Click(object sender, EventArgs e)
        {
            formOrderTicket_user form = new formOrderTicket_user();
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

        private void Zoo_main_user_Load(object sender, EventArgs e)
        {
            label2.Text = label2.Text + Users.status;
        }
    }
}