
namespace SchoolManagmentSystem
{
    partial class Fees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FeesDGV = new System.Windows.Forms.DataGridView();
            this.FAmount_tb = new System.Windows.Forms.TextBox();
            this.FName_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.Label();
            this.FDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 90);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fees";
            // 
            // FeesDGV
            // 
            this.FeesDGV.AllowUserToOrderColumns = true;
            this.FeesDGV.AllowUserToResizeRows = false;
            this.FeesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FeesDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FeesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FeesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FeesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FeesDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.FeesDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FeesDGV.EnableHeadersVisualStyles = false;
            this.FeesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FeesDGV.Location = new System.Drawing.Point(0, 272);
            this.FeesDGV.Name = "FeesDGV";
            this.FeesDGV.RowHeadersVisible = false;
            this.FeesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.FeesDGV.Size = new System.Drawing.Size(1070, 454);
            this.FeesDGV.TabIndex = 40;
            // 
            // FAmount_tb
            // 
            this.FAmount_tb.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FAmount_tb.Location = new System.Drawing.Point(422, 127);
            this.FAmount_tb.Name = "FAmount_tb";
            this.FAmount_tb.Size = new System.Drawing.Size(213, 29);
            this.FAmount_tb.TabIndex = 38;
            // 
            // FName_tb
            // 
            this.FName_tb.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FName_tb.Location = new System.Drawing.Point(119, 127);
            this.FName_tb.Name = "FName_tb";
            this.FName_tb.Size = new System.Drawing.Size(199, 29);
            this.FName_tb.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(337, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(654, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date";
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FName.Location = new System.Drawing.Point(52, 127);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(61, 23);
            this.FName.TabIndex = 37;
            this.FName.Text = "Name";
            // 
            // FDate
            // 
            this.FDate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FDate.Location = new System.Drawing.Point(710, 128);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(274, 29);
            this.FDate.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(689, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 33;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(538, 181);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(111, 51);
            this.edit_button.TabIndex = 30;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(403, 181);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(111, 51);
            this.delete_button.TabIndex = 31;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(247, 181);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(111, 51);
            this.save_button.TabIndex = 32;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 726);
            this.Controls.Add(this.FeesDGV);
            this.Controls.Add(this.FAmount_tb);
            this.Controls.Add(this.FName_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.panel1);
            this.Name = "Fees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FeesDGV;
        private System.Windows.Forms.TextBox FAmount_tb;
        private System.Windows.Forms.TextBox FName_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.DateTimePicker FDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
    }
}