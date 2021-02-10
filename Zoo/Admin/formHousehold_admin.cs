using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Lab9_database.Admin
{
    public partial class formHousehold_admin : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RV4PASN;Initial Catalog=Zoo;Integrated Security=True");
        public formHousehold_admin()
        {
            InitializeComponent();
        }

        private void formHousehold_admin_Load(object sender, EventArgs e)
        {
            this.householdTableAdapter.Fill(this.zooDataSet.Household);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (connection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Відсутнє з'єднання!");
                }

                if (txtId.Text == "" ||
                    txtAdress.Text == "" ||
                    txtPhone.Text == "" ||
                    txtEmail.Text == "" ||
                    txtName.Text == "")
                {
                    MessageBox.Show("Є незаповнені поля!");
                }

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Household] (Id, Id_animal, Adress, Phone, Email, Name_household) VALUES (@id, @id_animal, @adress, @phone, @email, @name_household)";

                cmd.Parameters.Add("@id", SqlDbType.Int, 2);
                cmd.Parameters["@id"].Value = Convert.ToInt32(txtId.Text);

                cmd.Parameters.Add("@id_animal", SqlDbType.Int, 3);
                cmd.Parameters["@id_animal"].Value = Convert.ToInt32(txtId_animal.Text);

                cmd.Parameters.Add("@adress", SqlDbType.VarChar, 35);
                cmd.Parameters["@adress"].Value = Convert.ToString(txtAdress.Text);

                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 15);
                cmd.Parameters["@phone"].Value = Convert.ToString(txtPhone.Text);

                cmd.Parameters.Add("@email", SqlDbType.VarChar, 35);
                cmd.Parameters["@email"].Value = Convert.ToString(txtEmail.Text);

                cmd.Parameters.Add("@name_household", SqlDbType.VarChar, 25);
                cmd.Parameters["@name_household"].Value = Convert.ToString(txtName.Text);

                cmd.ExecuteNonQuery();

                txtId.Text = "";
                txtId_animal.Text = "";
                txtAdress.Text = "";
                txtPhone.Text = ""; 
                txtEmail.Text = "";
                txtName.Text = "";

                MessageBox.Show("Data inserted Successfully");

                this.householdTableAdapter.Fill(this.zooDataSet.Household);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (connection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Відсутнє з'єднання!");
                }

                if (txtId_update.Text == "" ||
                    txtAdress_update.Text == "" ||
                    txtPhone_update.Text == "" ||
                    txtEmail_update.Text == "" ||
                    txtName_update.Text == "")
                {
                    MessageBox.Show("Є незаповнені поля!");
                }

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [Household] SET Id=@id, Id_animal=@id_animal, Adress=@adress, Phone=@phone, Email=@email, Name_household=@name_household WHERE Id = @id";

                cmd.Parameters.Add("@id", SqlDbType.Int, 2);
                cmd.Parameters["@id"].Value = Convert.ToInt32(txtId_update.Text);

                cmd.Parameters.Add("@id_animal", SqlDbType.Int, 3);
                cmd.Parameters["@id_animal"].Value = Convert.ToInt32(txtId_animal_update.Text);

                cmd.Parameters.Add("@adress", SqlDbType.VarChar, 35);
                cmd.Parameters["@adress"].Value = Convert.ToString(txtAdress_update.Text);

                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 15);
                cmd.Parameters["@phone"].Value = Convert.ToString(txtPhone_update.Text);

                cmd.Parameters.Add("@email", SqlDbType.VarChar, 35);
                cmd.Parameters["@email"].Value = Convert.ToString(txtEmail_update.Text);

                cmd.Parameters.Add("@name_household", SqlDbType.VarChar, 25);
                cmd.Parameters["@name_household"].Value = Convert.ToString(txtName_update.Text);

                cmd.ExecuteNonQuery();

                txtId_update.Text = "";
                txtId_animal_update.Text = "";
                txtAdress_update.Text = "";
                txtPhone_update.Text = "";
                txtEmail_update.Text = "";
                txtName_update.Text = "";

                MessageBox.Show("Data updated Successfully");

                this.householdTableAdapter.Fill(this.zooDataSet.Household);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (connection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Відсутнє з'єднання!");
                }

                if (txtDelete.Text == "")
                    MessageBox.Show("Введіть ID!");

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM [Household] WHERE Id= @id";

                cmd.Parameters.Add("@id", SqlDbType.Int, 2);
                cmd.Parameters["@id"].Value = Convert.ToInt32(txtDelete.Text);
                cmd.ExecuteNonQuery();

                txtDelete.Text = "";
                MessageBox.Show("Data deleted Successfully");

                this.householdTableAdapter.Fill(this.zooDataSet.Household);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Zoo_main_admin form = new Zoo_main_admin();
            form.Show();
            this.Hide();
        }
    }
}