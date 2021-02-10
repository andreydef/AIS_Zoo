using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace Lab9_database.Admin
{
    public partial class formAnimals_admin : Form
    {
        SqlConnection connection;
        SqlCommand set_photo;
        byte[] img = null;
        string constring = @"Data Source=DESKTOP-RV4PASN;Initial Catalog=Zoo;Integrated Security=True";

        public formAnimals_admin()
        {
            InitializeComponent();
        }

        public static byte[] getImage(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] image = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return image;
        }

        private void formAnimals_admin_Load(object sender, EventArgs e)
        {
            this.animalTableAdapter.Fill(this.zooDataSet1.Animal);
        }

        private void btnUpload_insert_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "ImageFiles(*.JPG;*.PNG;*.JPEG)|*.JPG;*.PNG;*.JPEG;|Allfiles (*.*)|*.*";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    img = getImage(open_dialog.FileName);
                    pictureBoxInsert.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxInsert.Image = Image.FromFile(open_dialog.FileName);
                }
                catch (Exception n)
                {
                    DialogResult rezult = MessageBox.Show(n.Message, n.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpload_update_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "ImageFiles(*.JPG;*.PNG;*.JPEG)|*.JPG;*.PNG;*.JPEG;|Allfiles (*.*)|*.*";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    img = getImage(open_dialog.FileName);
                    pictureBoxUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxUpdate.Image = Image.FromFile(open_dialog.FileName);
                }
                catch (Exception n)
                {
                    DialogResult rezult = MessageBox.Show(n.Message, n.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(constring);
            connection.Open();

            if (txtId.Text == "" || txtNumber.Text == "" ||
                txtNazva.Text == "" || txtAlias.Text == "" ||
                txtAge.Text == "" || txtCountry.Text == "")
            {
                MessageBox.Show("Є незаповнені поля!");
            }

            try
            {
                set_photo = connection.CreateCommand();

                set_photo.CommandText = "INSERT INTO [Animal] (Id, Number, Nazva, Alias, Age, Country, Photo) values ( @id, @number, @nazva, @alias, @age, @country, @photo)";

                set_photo.Parameters.Add("@id", SqlDbType.Int, 4);
                set_photo.Parameters["@id"].Value = Convert.ToInt32(txtId.Text);

                set_photo.Parameters.Add("@number", SqlDbType.Int, 4);
                set_photo.Parameters["@number"].Value = Convert.ToInt32(txtNumber.Text);

                set_photo.Parameters.Add("@nazva", SqlDbType.VarChar, 25);
                set_photo.Parameters["@nazva"].Value = Convert.ToString(txtNazva.Text);

                set_photo.Parameters.Add("@alias", SqlDbType.VarChar, 10);
                set_photo.Parameters["@alias"].Value = Convert.ToString(txtAlias.Text);

                set_photo.Parameters.Add("@age", SqlDbType.Int, 4);
                set_photo.Parameters["@age"].Value = Convert.ToInt32(txtAge.Text);

                set_photo.Parameters.Add("@country", SqlDbType.VarChar, 25);
                set_photo.Parameters["@country"].Value = Convert.ToString(txtCountry.Text);

                set_photo.Parameters.Add("@photo", SqlDbType.Image, img.Length);
                set_photo.Parameters["@photo"].Value = img;

                set_photo.ExecuteNonQuery();

                txtId.Text = "";
                txtNumber.Text = "";
                txtNazva.Text = "";
                txtAlias.Text = "";
                txtAge.Text = "";
                txtCountry.Text = "";
                pictureBoxInsert.Image = null;

                this.animalTableAdapter.Fill(this.zooDataSet1.Animal);
            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message, n.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Дані успішно додано!");
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(constring);
            connection.Open();

            if (txtId_update.Text == "" || txtNumber_update.Text == "" ||
                txtNazva_update.Text == "" || txtAlias_update.Text == "" ||
                txtAge_update.Text == "" || txtCountry_update.Text == "")
            {
                MessageBox.Show("Є незаповнені поля!");
            }

            try
            {
                set_photo = connection.CreateCommand();

                set_photo.CommandText = "UPDATE [Animal] SET Id=@id, Number=@number, Nazva=@nazva, Alias=@alias, Age=@age, Country=@country, Photo=@photo WHERE Id = @id";

                set_photo.Parameters.Add("@id", SqlDbType.Int, 4);
                set_photo.Parameters["@id"].Value = Convert.ToInt32(txtId_update.Text);

                set_photo.Parameters.Add("@number", SqlDbType.Int, 4);
                set_photo.Parameters["@number"].Value = Convert.ToInt32(txtNumber_update.Text);

                set_photo.Parameters.Add("@nazva", SqlDbType.VarChar, 25);
                set_photo.Parameters["@nazva"].Value = Convert.ToString(txtNazva_update.Text);

                set_photo.Parameters.Add("@alias", SqlDbType.VarChar, 10);
                set_photo.Parameters["@alias"].Value = Convert.ToString(txtAlias_update.Text);

                set_photo.Parameters.Add("@age", SqlDbType.Int, 4);
                set_photo.Parameters["@age"].Value = Convert.ToInt32(txtAge_update.Text);

                set_photo.Parameters.Add("@country", SqlDbType.VarChar, 25);
                set_photo.Parameters["@country"].Value = Convert.ToString(txtCountry_update.Text);

                set_photo.Parameters.Add("@photo", SqlDbType.Image, img.Length);
                set_photo.Parameters["@photo"].Value = img;

                set_photo.ExecuteNonQuery();

                txtId_update.Text = "";
                txtNumber_update.Text = "";
                txtNazva_update.Text = "";
                txtAlias_update.Text = "";
                txtAge_update.Text = "";
                txtCountry_update.Text = "";
                pictureBoxUpdate.Image = null;

                this.animalTableAdapter.Fill(this.zooDataSet1.Animal);
            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message, n.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Дані успішно оновлено!");
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
                cmd.CommandText = "DELETE FROM [Animal] WHERE Id= @id";

                cmd.Parameters.Add("@id", SqlDbType.Int, 2);
                cmd.Parameters["@id"].Value = Convert.ToInt32(txtDelete.Text);
                cmd.ExecuteNonQuery();

                txtDelete.Text = "";
                MessageBox.Show("Data deleted Successfully");

                this.animalTableAdapter.Fill(this.zooDataSet1.Animal);
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