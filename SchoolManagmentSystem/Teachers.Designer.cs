
namespace SchoolManagmentSystem
{
    partial class Teachers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Tgender_cb = new System.Windows.Forms.ComboBox();
            this.Tname_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.address_rtb = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.schoolDbDataSet1 = new SchoolManagmentSystem.SchoolDbDataSet1();
            this.teacherTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTblTableAdapter = new SchoolManagmentSystem.SchoolDbDataSet1TableAdapters.TeacherTblTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.TSub = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TPhoneTb = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TSub_tb = new System.Windows.Forms.TextBox();
            this.TPhone_tb = new System.Windows.Forms.TextBox();
            this.TeachersDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 90);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teachers";
            // 
            // Tgender_cb
            // 
            this.Tgender_cb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tgender_cb.FormattingEnabled = true;
            this.Tgender_cb.Items.AddRange(new object[] {
            "male",
            "female"});
            this.Tgender_cb.Location = new System.Drawing.Point(145, 170);
            this.Tgender_cb.Name = "Tgender_cb";
            this.Tgender_cb.Size = new System.Drawing.Size(207, 33);
            this.Tgender_cb.TabIndex = 12;
            // 
            // Tname_tb
            // 
            this.Tname_tb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tname_tb.Location = new System.Drawing.Point(145, 124);
            this.Tname_tb.Name = "Tname_tb";
            this.Tname_tb.Size = new System.Drawing.Size(207, 31);
            this.Tname_tb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(45, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address";
            // 
            // address_rtb
            // 
            this.address_rtb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_rtb.Location = new System.Drawing.Point(145, 305);
            this.address_rtb.Name = "address_rtb";
            this.address_rtb.Size = new System.Drawing.Size(287, 112);
            this.address_rtb.TabIndex = 15;
            this.address_rtb.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(145, 240);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(235, 31);
            this.dateTimePicker.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birthday Date";
            // 
            // schoolDbDataSet1
            // 
            this.schoolDbDataSet1.DataSetName = "SchoolDbDataSet1";
            this.schoolDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTblBindingSource
            // 
            this.teacherTblBindingSource.DataMember = "TeacherTbl";
            this.teacherTblBindingSource.DataSource = this.schoolDbDataSet1;
            // 
            // teacherTblTableAdapter
            // 
            this.teacherTblTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(162, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(313, 564);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(111, 51);
            this.edit_button.TabIndex = 18;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(180, 564);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(111, 51);
            this.delete_button.TabIndex = 19;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(37, 564);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(111, 51);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // TSub
            // 
            this.TSub.AutoSize = true;
            this.TSub.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSub.Location = new System.Drawing.Point(40, 450);
            this.TSub.Name = "TSub";
            this.TSub.Size = new System.Drawing.Size(81, 25);
            this.TSub.TabIndex = 9;
            this.TSub.Text = "Subject";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(146, 965);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 72);
            this.button2.TabIndex = 21;
            this.button2.Text = "Main menu";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TPhoneTb
            // 
            this.TPhoneTb.AutoSize = true;
            this.TPhoneTb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TPhoneTb.Location = new System.Drawing.Point(-5, 494);
            this.TPhoneTb.Name = "TPhoneTb";
            this.TPhoneTb.Size = new System.Drawing.Size(149, 25);
            this.TPhoneTb.TabIndex = 9;
            this.TPhoneTb.Text = "Phone number";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(146, 1014);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 72);
            this.button3.TabIndex = 21;
            this.button3.Text = "Main menu";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // TSub_tb
            // 
            this.TSub_tb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSub_tb.Location = new System.Drawing.Point(146, 444);
            this.TSub_tb.Name = "TSub_tb";
            this.TSub_tb.Size = new System.Drawing.Size(207, 31);
            this.TSub_tb.TabIndex = 10;
            // 
            // TPhone_tb
            // 
            this.TPhone_tb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TPhone_tb.Location = new System.Drawing.Point(146, 494);
            this.TPhone_tb.Name = "TPhone_tb";
            this.TPhone_tb.Size = new System.Drawing.Size(207, 31);
            this.TPhone_tb.TabIndex = 10;
            // 
            // TeachersDGV
            // 
            this.TeachersDGV.AllowUserToOrderColumns = true;
            this.TeachersDGV.AllowUserToResizeRows = false;
            this.TeachersDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeachersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeachersDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TeachersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeachersDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TeachersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TeachersDGV.ColumnHeadersHeight = 30;
            this.TeachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachersDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.TeachersDGV.EnableHeadersVisualStyles = false;
            this.TeachersDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TeachersDGV.Location = new System.Drawing.Point(488, 87);
            this.TeachersDGV.Name = "TeachersDGV";
            this.TeachersDGV.RowHeadersVisible = false;
            this.TeachersDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TeachersDGV.Size = new System.Drawing.Size(758, 634);
            this.TeachersDGV.TabIndex = 22;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 721);
            this.Controls.Add(this.TeachersDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.address_rtb);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tgender_cb);
            this.Controls.Add(this.TPhone_tb);
            this.Controls.Add(this.TSub_tb);
            this.Controls.Add(this.Tname_tb);
            this.Controls.Add(this.TPhoneTb);
            this.Controls.Add(this.TSub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Tgender_cb;
        private System.Windows.Forms.TextBox Tname_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox address_rtb;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private SchoolDbDataSet1 schoolDbDataSet1;
        private System.Windows.Forms.BindingSource teacherTblBindingSource;
        private SchoolDbDataSet1TableAdapters.TeacherTblTableAdapter teacherTblTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label TSub;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TPhoneTb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TSub_tb;
        private System.Windows.Forms.TextBox TPhone_tb;
        private System.Windows.Forms.DataGridView TeachersDGV;
    }
}