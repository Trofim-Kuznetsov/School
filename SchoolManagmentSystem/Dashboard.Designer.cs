
namespace SchoolManagmentSystem
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TeachersLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EventsLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 90);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(673, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 65);
            this.button1.TabIndex = 34;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.StLbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(48, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 161);
            this.panel2.TabIndex = 35;
            // 
            // StLbl
            // 
            this.StLbl.AutoSize = true;
            this.StLbl.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StLbl.Location = new System.Drawing.Point(91, 71);
            this.StLbl.Name = "StLbl";
            this.StLbl.Size = new System.Drawing.Size(27, 34);
            this.StLbl.TabIndex = 36;
            this.StLbl.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "Students";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Controls.Add(this.TeachersLbl);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(335, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 161);
            this.panel3.TabIndex = 35;
            // 
            // TeachersLbl
            // 
            this.TeachersLbl.AutoSize = true;
            this.TeachersLbl.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeachersLbl.Location = new System.Drawing.Point(91, 71);
            this.TeachersLbl.Name = "TeachersLbl";
            this.TeachersLbl.Size = new System.Drawing.Size(31, 34);
            this.TeachersLbl.TabIndex = 36;
            this.TeachersLbl.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Teachers";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.EventsLbl);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(628, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 161);
            this.panel4.TabIndex = 35;
            // 
            // EventsLbl
            // 
            this.EventsLbl.AutoSize = true;
            this.EventsLbl.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventsLbl.Location = new System.Drawing.Point(88, 71);
            this.EventsLbl.Name = "EventsLbl";
            this.EventsLbl.Size = new System.Drawing.Size(31, 34);
            this.EventsLbl.TabIndex = 36;
            this.EventsLbl.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 31);
            this.label4.TabIndex = 36;
            this.label4.Text = "Events";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 490);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StLbl;
        private System.Windows.Forms.Label TeachersLbl;
        private System.Windows.Forms.Label EventsLbl;
    }
}