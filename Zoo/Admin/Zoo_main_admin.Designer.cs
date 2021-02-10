
namespace Lab9_database
{
    partial class Zoo_main_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zoo_main_admin));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelOrderTicket = new System.Windows.Forms.Label();
            this.labelZooAnimal = new System.Windows.Forms.Label();
            this.labelHousehold = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ви ввійшли як: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(423, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "База даних \"Зоопарк\"";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.Location = new System.Drawing.Point(374, 313);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(132, 20);
            this.labelExit.TabIndex = 15;
            this.labelExit.Text = "Вихід з аккаунту";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelOrderTicket
            // 
            this.labelOrderTicket.AutoSize = true;
            this.labelOrderTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderTicket.Location = new System.Drawing.Point(374, 265);
            this.labelOrderTicket.Name = "labelOrderTicket";
            this.labelOrderTicket.Size = new System.Drawing.Size(145, 20);
            this.labelOrderTicket.TabIndex = 14;
            this.labelOrderTicket.Text = "Замовлені квитки";
            this.labelOrderTicket.Click += new System.EventHandler(this.labelOrderTicket_Click);
            // 
            // labelZooAnimal
            // 
            this.labelZooAnimal.AutoSize = true;
            this.labelZooAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZooAnimal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelZooAnimal.Location = new System.Drawing.Point(374, 217);
            this.labelZooAnimal.Name = "labelZooAnimal";
            this.labelZooAnimal.Size = new System.Drawing.Size(144, 20);
            this.labelZooAnimal.TabIndex = 13;
            this.labelZooAnimal.Text = "Тварини зоопарку";
            this.labelZooAnimal.Click += new System.EventHandler(this.labelZooAnimal_Click);
            // 
            // labelHousehold
            // 
            this.labelHousehold.AutoSize = true;
            this.labelHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHousehold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHousehold.Location = new System.Drawing.Point(374, 172);
            this.labelHousehold.Name = "labelHousehold";
            this.labelHousehold.Size = new System.Drawing.Size(189, 20);
            this.labelHousehold.TabIndex = 12;
            this.labelHousehold.Text = "Господарства зоопарку";
            this.labelHousehold.Click += new System.EventHandler(this.labelHousehold_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Вийти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zoo_main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelOrderTicket);
            this.Controls.Add(this.labelZooAnimal);
            this.Controls.Add(this.labelHousehold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Zoo_main_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зоопарк";
            this.Load += new System.EventHandler(this.Zoo_main_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelOrderTicket;
        private System.Windows.Forms.Label labelZooAnimal;
        private System.Windows.Forms.Label labelHousehold;
        private System.Windows.Forms.Button button1;
    }
}