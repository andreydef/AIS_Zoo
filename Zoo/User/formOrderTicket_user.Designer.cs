
namespace Lab9_database.User
{
    partial class formOrderTicket_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.Date_birthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Date_order_ticketTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Date_visitingTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.cboHousehold = new System.Windows.Forms.ComboBox();
            this.cboAnimal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.zooDataSet = new Lab9_database.ZooDataSet();
            this.householdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.householdTableAdapter = new Lab9_database.ZooDataSetTableAdapters.HouseholdTableAdapter();
            this.zooDataSet1 = new Lab9_database.ZooDataSet1();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new Lab9_database.ZooDataSet1TableAdapters.AnimalTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Замовити квиток ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(523, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Введіть дані для оформлення квитка";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(36, 177);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(167, 20);
            this.txtSurname.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(36, 219);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(36, 271);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(167, 20);
            this.txtPhone.TabIndex = 21;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(36, 323);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(167, 20);
            this.txtAdress.TabIndex = 22;
            // 
            // Date_birthTimePicker
            // 
            this.Date_birthTimePicker.Location = new System.Drawing.Point(250, 177);
            this.Date_birthTimePicker.Name = "Date_birthTimePicker";
            this.Date_birthTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Date_birthTimePicker.TabIndex = 23;
            // 
            // Date_order_ticketTimePicker
            // 
            this.Date_order_ticketTimePicker.Enabled = false;
            this.Date_order_ticketTimePicker.Location = new System.Drawing.Point(250, 229);
            this.Date_order_ticketTimePicker.Name = "Date_order_ticketTimePicker";
            this.Date_order_ticketTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Date_order_ticketTimePicker.TabIndex = 24;
            // 
            // Date_visitingTimePicker
            // 
            this.Date_visitingTimePicker.Location = new System.Drawing.Point(250, 281);
            this.Date_visitingTimePicker.Name = "Date_visitingTimePicker";
            this.Date_visitingTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Date_visitingTimePicker.TabIndex = 25;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(36, 375);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(167, 20);
            this.txtPrice.TabIndex = 26;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(36, 433);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(167, 20);
            this.txtCount.TabIndex = 27;
            // 
            // cboHousehold
            // 
            this.cboHousehold.FormattingEnabled = true;
            this.cboHousehold.Location = new System.Drawing.Point(36, 480);
            this.cboHousehold.Name = "cboHousehold";
            this.cboHousehold.Size = new System.Drawing.Size(121, 21);
            this.cboHousehold.TabIndex = 28;
            // 
            // cboAnimal
            // 
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Location = new System.Drawing.Point(36, 531);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(121, 21);
            this.cboAnimal.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Household";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Animal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Date birth";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Date order ticket";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Date visiting";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(505, 513);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(93, 31);
            this.btnInsert.TabIndex = 43;
            this.btnInsert.Text = "Замовити";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // householdBindingSource
            // 
            this.householdBindingSource.DataMember = "Household";
            this.householdBindingSource.DataSource = this.zooDataSet;
            // 
            // householdTableAdapter
            // 
            this.householdTableAdapter.ClearBeforeFill = true;
            // 
            // zooDataSet1
            // 
            this.zooDataSet1.DataSetName = "ZooDataSet1";
            this.zooDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.zooDataSet1;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(36, 133);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 44;
            // 
            // formOrderTicket_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(630, 568);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboAnimal);
            this.Controls.Add(this.cboHousehold);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.Date_visitingTimePicker);
            this.Controls.Add(this.Date_order_ticketTimePicker);
            this.Controls.Add(this.Date_birthTimePicker);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "formOrderTicket_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Замовити квиток ";
            this.Load += new System.EventHandler(this.formOrderTicket_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.DateTimePicker Date_birthTimePicker;
        private System.Windows.Forms.DateTimePicker Date_order_ticketTimePicker;
        private System.Windows.Forms.DateTimePicker Date_visitingTimePicker;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.ComboBox cboHousehold;
        private System.Windows.Forms.ComboBox cboAnimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnInsert;
        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource householdBindingSource;
        private ZooDataSetTableAdapters.HouseholdTableAdapter householdTableAdapter;
        private ZooDataSet1 zooDataSet1;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private ZooDataSet1TableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtId;
    }
}