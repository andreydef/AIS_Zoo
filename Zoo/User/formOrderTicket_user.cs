using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Lab9_database.User
{
    public partial class formOrderTicket_user : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RV4PASN;Initial Catalog=Zoo;Integrated Security=True");
        public formOrderTicket_user()
        {
            InitializeComponent();
        }

        private void formOrderTicket_user_Load(object sender, EventArgs e)
        {
            this.animalTableAdapter.Fill(this.zooDataSet1.Animal);
            this.householdTableAdapter.Fill(this.zooDataSet.Household);

            Date_birthTimePicker.Value = DateTime.Now;
            Date_order_ticketTimePicker.Value = DateTime.Now;
            Date_visitingTimePicker.Value = DateTime.Now;

            #region Household

            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Household]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            cboHousehold.DataSource = dt;
            cboHousehold.DisplayMember = "Name_household";

            #endregion

            #region Animal

            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from [Animal]";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            sda1.Fill(dt1);
            cboAnimal.DataSource = dt1;
            cboAnimal.DisplayMember = "Nazva";

            connection.Close();

            #endregion
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Zoo_main_user form = new Zoo_main_user();
            form.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand()
                {
                    Connection = connection
                };

                if (txtId.Text == "" ||
                    txtSurname.Text == "" ||
                    txtName.Text == "" ||
                    txtPhone.Text == "" ||
                    txtAdress.Text == "" ||
                    txtPrice.Text == "" ||
                    txtCount.Text == "")
                {
                    MessageBox.Show("Є незаповнені поля!");
                }

                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.Add("@Surname", SqlDbType.NChar);
                command.Parameters.Add("@Name", SqlDbType.NChar);
                command.Parameters.Add("@Phone", SqlDbType.NChar);
                command.Parameters.Add("@Adress", SqlDbType.NChar);
                command.Parameters.Add("@Date_birth", SqlDbType.Date);
                command.Parameters.Add("@Date_order_ticket", SqlDbType.Date);
                command.Parameters.Add("@Date_visiting", SqlDbType.Date);
                command.Parameters.Add("@Price", SqlDbType.Float);
                command.Parameters.Add("@Count", SqlDbType.Int);
                command.Parameters.Add("@Household", SqlDbType.NChar);
                command.Parameters.Add("@Animal", SqlDbType.NChar);

                command.Parameters["@Id"].Value = Convert.ToInt32(txtId.Text);
                command.Parameters["@Surname"].Value = Convert.ToString(txtSurname.Text);
                command.Parameters["@Name"].Value = Convert.ToString(txtName.Text);
                command.Parameters["@Phone"].Value = Convert.ToString(txtPhone.Text);
                command.Parameters["@Adress"].Value = Convert.ToString(txtAdress.Text);
                command.Parameters["@Date_birth"].Value = Convert.ToDateTime(Date_birthTimePicker.Text);
                command.Parameters["@Date_order_ticket"].Value = Convert.ToDateTime(Date_order_ticketTimePicker.Text);
                command.Parameters["@Date_visiting"].Value = Convert.ToDateTime(Date_visitingTimePicker.Text);
                command.Parameters["@Price"].Value = Convert.ToDouble(txtPrice.Text);
                command.Parameters["@Count"].Value = Convert.ToInt32(txtCount.Text);
                command.Parameters["@Household"].Value = Convert.ToString(cboHousehold.Text);
                command.Parameters["@Animal"].Value = Convert.ToString(cboAnimal.Text);

                SqlParameter parameter = new SqlParameter("@result", SqlDbType.Int);
                parameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(parameter);

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "insert_to_order_tickets";

                command.ExecuteNonQuery();
                int tmp = Convert.ToInt32(command.Parameters["@result"].Value);
                if (tmp == 0)
                    MessageBox.Show("Запис з таким ID вже існує!");
                else
                {
                    MessageBox.Show("Ви замовили квиток!");

                    txtId.Text = "";
                    txtSurname.Text = "";
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtAdress.Text = "";
                    Date_birthTimePicker.Value = DateTime.Now;
                    Date_visitingTimePicker.Value = DateTime.Now;
                    txtPrice.Text = "";
                    txtCount.Text = "";
                }
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
    }
}