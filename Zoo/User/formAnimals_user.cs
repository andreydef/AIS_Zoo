using System;
using System.Windows.Forms;

namespace Lab9_database.User
{
    public partial class formAnimals_user : Form
    {
        public formAnimals_user()
        {
            InitializeComponent();
        }

        private void formAnimals_user_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet1.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.zooDataSet1.Animal);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Zoo_main_user form = new Zoo_main_user();
            form.Show();
            this.Hide();
        }
    }
}