using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab9_database
{
    public partial class formRegister :  MaterialSkin.Controls.MaterialForm
    {
        public formRegister()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void formRegister_Load(object sender, EventArgs e)
        {
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            form.Show();
            this.Hide();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RV4PASN;Initial Catalog=Zoo;Integrated Security=True"))
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (checkBox1.Checked == false)
                    {
                        con.Open();

                        SqlCommand command = new SqlCommand("INSERT INTO userdata (username, userpassword, status) " +
                            "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', 'user')", con);
                        command.ExecuteReader();

                        MessageBox.Show("Користувача '" + textBox1.Text + "'  зареєстровано як user!");

                        con.Close();
                    }

                    if (checkBox1.Checked == true)
                    {
                        con.Open();

                        SqlCommand command = new SqlCommand("INSERT INTO userdata (username, userpassword, status) " +
                            "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', 'admin')", con);
                        command.ExecuteReader();

                        MessageBox.Show("Користувача '" + textBox1.Text + "'  зареєстровано як admin!");

                        con.Close();
                    }

                    formLogin form = new formLogin();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Паролі не співпадають!");
                }
            }
        }
    }
}