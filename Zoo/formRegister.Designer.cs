namespace Lab9_database
{
    partial class formRegister
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkBox1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Depth = 0;
            this.textBox1.Hint = "Username";
            this.textBox1.Location = new System.Drawing.Point(26, 107);
            this.textBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(277, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // textBox2
            // 
            this.textBox2.Depth = 0;
            this.textBox2.Hint = "Password";
            this.textBox2.Location = new System.Drawing.Point(26, 158);
            this.textBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.Size = new System.Drawing.Size(277, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(214, 297);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(89, 29);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Register";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(26, 345);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(277, 1);
            this.materialDivider1.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 369);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(179, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Already have an account?";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(257, 369);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Login";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Depth = 0;
            this.textBox3.Hint = "Confirm Password";
            this.textBox3.Location = new System.Drawing.Point(26, 205);
            this.textBox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.SelectedText = "";
            this.textBox3.SelectionLength = 0;
            this.textBox3.SelectionStart = 0;
            this.textBox3.Size = new System.Drawing.Size(277, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.UseSystemPasswordChar = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Depth = 0;
            this.checkBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBox1.Location = new System.Drawing.Point(26, 253);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Ripple = true;
            this.checkBox1.Size = new System.Drawing.Size(87, 30);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.TabStop = true;
            this.checkBox1.Text = "As admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // formRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 416);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "formRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.formRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox3;
        private MaterialSkin.Controls.MaterialRadioButton checkBox1;
    }
}

