using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Lab9_database.Admin
{
    public partial class formOrderTickets_admin : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RV4PASN;Initial Catalog=Zoo;Integrated Security=True");

        public formOrderTickets_admin()
        {
            InitializeComponent();
        }

        private void formOrderTickets_admin_Load(object sender, EventArgs e)
        {
            this.order_ticketsTableAdapter.Fill(this.orderTicketsDataSet.Order_tickets);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (connection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Відсутнє з'єднання!");
                }

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

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE [Order_tickets] SET Id=@id, Surname=@surname, Name=@name, " +
                    "Phone=@phone, Adress=@adress, Date_birth=@date_birth, " +
                    "Date_order_ticket=@date_order_ticket," +
                    " Date_visiting=@date_visiting, Price=@price, Count=@count, " +
                    "Household=@household, Animal=@animal WHERE Id = @id";

                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters.Add("@surname", SqlDbType.NChar);
                command.Parameters.Add("@name", SqlDbType.NChar);
                command.Parameters.Add("@phone", SqlDbType.NChar);
                command.Parameters.Add("@adress", SqlDbType.NChar);
                command.Parameters.Add("@date_birth", SqlDbType.Date);
                command.Parameters.Add("@date_order_ticket", SqlDbType.Date);
                command.Parameters.Add("@date_visiting", SqlDbType.Date);
                command.Parameters.Add("@price", SqlDbType.Float);
                command.Parameters.Add("@count", SqlDbType.Int);
                command.Parameters.Add("@household", SqlDbType.NChar);
                command.Parameters.Add("@animal", SqlDbType.NChar);

                command.Parameters["@id"].Value = Convert.ToInt32(txtId.Text);
                command.Parameters["@surname"].Value = Convert.ToString(txtSurname.Text);
                command.Parameters["@name"].Value = Convert.ToString(txtName.Text);
                command.Parameters["@phone"].Value = Convert.ToString(txtPhone.Text);
                command.Parameters["@adress"].Value = Convert.ToString(txtAdress.Text);
                command.Parameters["@date_birth"].Value = Convert.ToDateTime(Date_birthTimePicker.Text);
                command.Parameters["@date_order_ticket"].Value = Convert.ToDateTime(Date_order_ticketTimePicker.Text);
                command.Parameters["@date_visiting"].Value = Convert.ToDateTime(Date_visitingTimePicker.Text);
                command.Parameters["@price"].Value = Convert.ToDouble(txtPrice.Text);
                command.Parameters["@count"].Value = Convert.ToInt32(txtCount.Text);
                command.Parameters["@household"].Value = Convert.ToString(cboHousehold.Text);
                command.Parameters["@animal"].Value = Convert.ToString(cboAnimal.Text);

                command.ExecuteNonQuery();

                txtId.Text = "";
                txtSurname.Text = "";
                txtName.Text = "";
                txtPhone.Text = "";
                txtAdress.Text = "";
                Date_birthTimePicker.Value = DateTime.Now;
                Date_visitingTimePicker.Value = DateTime.Now;
                txtPrice.Text = "";
                txtCount.Text = "";

                MessageBox.Show("Data updated Successfully");

                this.order_ticketsTableAdapter.Fill(this.orderTicketsDataSet.Order_tickets);
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
                cmd.CommandText = "DELETE FROM [Order_tickets] WHERE Id= @id";
                cmd.Parameters.Add("@id", SqlDbType.Int, 2);
                cmd.Parameters["@id"].Value = Convert.ToInt32(txtDelete.Text);

                cmd.ExecuteNonQuery();
                txtDelete.Text = "";
                MessageBox.Show("Data deleted Successfully");

                this.order_ticketsTableAdapter.Fill(this.orderTicketsDataSet.Order_tickets);
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