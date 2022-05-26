
namespace SchoolManagmentSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 79);
            this.panel1.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(164, 27);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(351, 23);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Trofim High School Managment System";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(518, 121);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(65, 25);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Login";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username_label.Location = new System.Drawing.Point(342, 174);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(96, 23);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(342, 231);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(91, 23);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // UnameTb
            // 
            this.UnameTb.Location = new System.Drawing.Point(465, 175);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(177, 26);
            this.UnameTb.TabIndex = 4;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(465, 231);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(177, 26);
            this.PasswordTb.TabIndex = 5;
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.enter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_button.Location = new System.Drawing.Point(500, 278);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(107, 43);
            this.enter_button.TabIndex = 6;
            this.enter_button.Text = "Enter";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 373);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Button enter_button;
    }
}