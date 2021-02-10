namespace Lab9_database
{
    partial class Zoo_main_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zoo_main_user));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHousehold = new System.Windows.Forms.Label();
            this.labelZooAnimal = new System.Windows.Forms.Label();
            this.labelOrderTicket = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(404, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "База даних \"Зоопарк\"";
            // 
            // labelHousehold
            // 
            this.labelHousehold.AutoSize = true;
            this.labelHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHousehold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHousehold.Location = new System.Drawing.Point(343, 179);
            this.labelHousehold.Name = "labelHousehold";
            this.labelHousehold.Size = new System.Drawing.Size(189, 20);
            this.labelHousehold.TabIndex = 2;
            this.labelHousehold.Text = "Господарства зоопарку";
            this.labelHousehold.Click += new System.EventHandler(this.labelHousehold_Click);
            // 
            // labelZooAnimal
            // 
            this.labelZooAnimal.AutoSize = true;
            this.labelZooAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZooAnimal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelZooAnimal.Location = new System.Drawing.Point(343, 224);
            this.labelZooAnimal.Name = "labelZooAnimal";
            this.labelZooAnimal.Size = new System.Drawing.Size(144, 20);
            this.labelZooAnimal.TabIndex = 3;
            this.labelZooAnimal.Text = "Тварини зоопарку";
            this.labelZooAnimal.Click += new System.EventHandler(this.labelZooAnimal_Click);
            // 
            // labelOrderTicket
            // 
            this.labelOrderTicket.AutoSize = true;
            this.labelOrderTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderTicket.Location = new System.Drawing.Point(343, 272);
            this.labelOrderTicket.Name = "labelOrderTicket";
            this.labelOrderTicket.Size = new System.Drawing.Size(141, 20);
            this.labelOrderTicket.TabIndex = 5;
            this.labelOrderTicket.Text = "Замовити квиток";
            this.labelOrderTicket.Click += new System.EventHandler(this.labelOrderTicket_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.Location = new System.Drawing.Point(343, 320);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(132, 20);
            this.labelExit.TabIndex = 6;
            this.labelExit.Text = "Вихід з аккаунту";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вийти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ви ввійшли як: ";
            // 
            // Zoo_main_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelOrderTicket);
            this.Controls.Add(this.labelZooAnimal);
            this.Controls.Add(this.labelHousehold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Zoo_main_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зоопарк";
            this.Load += new System.EventHandler(this.Zoo_main_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHousehold;
        private System.Windows.Forms.Label labelZooAnimal;
        private System.Windows.Forms.Label labelOrderTicket;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}