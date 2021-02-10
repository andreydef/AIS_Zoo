using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab9_database
{
    public partial class formLogin :  MaterialSkin.Controls.MaterialForm
    {
        public SqlConnection con;
        public SqlCommand command;
        public SqlDataReader reader;

        string constring = @"Data Source=DESKTOP-RV4PASN;Initial Catalog=Zoo;Integrated Security=True";

        public formLogin()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            formRegister form = new formRegister();
            form.Show();
            this.Hide();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constring);
            con.Open();

            command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from userdata where username=@username and userpassword=@userpassword";

            command.Parameters.AddWithValue("@username", textBox1.Text.ToString());
            command.Parameters.AddWithValue("@userpassword", textBox2.Text.ToString());

            reader = command.ExecuteReader();

            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                int i = 0;
                while (reader.Read())
                {
                    i++;
                    Users.username = reader[0].ToString();
                    Users.userpassword = reader[1].ToString();
                    Users.status = reader[2].ToString();
                }

                if (i != 1)
                {
                    MessageBox.Show("Перевірте коректність логіна та пароля", "Такого користувача не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                }

                if (i == 1 && Users.status == "user")
                {
                    Zoo_main_user form = new Zoo_main_user();
                    form.Show();
                    this.Hide();
                }

                if (i == 1 && Users.status == "admin")
                {
                    Zoo_main_admin form = new Zoo_main_admin();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля!", "Ідентифікація неможлива", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
            command.Dispose();
            con.Close();
        }
    }
}