
namespace SchoolManagmentSystem
{
    partial class Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StudentsDGV = new System.Windows.Forms.DataGridView();
            this.studentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDbDataSet = new SchoolManagmentSystem.SchoolDbDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.class_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gender_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fees_tb = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.address_rtb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.studentTblTableAdapter = new SchoolManagmentSystem.SchoolDbDataSetTableAdapters.StudentTblTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsDGV
            // 
            this.StudentsDGV.AllowUserToOrderColumns = true;
            this.StudentsDGV.AllowUserToResizeRows = false;
            this.StudentsDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.StudentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StudentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.StudentsDGV.ColumnHeadersHeight = 30;
            this.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.StudentsDGV.EnableHeadersVisualStyles = false;
            this.StudentsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StudentsDGV.Location = new System.Drawing.Point(446, 77);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.RowHeadersVisible = false;
            this.StudentsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.StudentsDGV.Size = new System.Drawing.Size(679, 668);
            this.StudentsDGV.TabIndex = 0;
            // 
            // studentTblBindingSource
            // 
            this.studentTblBindingSource.DataMember = "StudentTbl";
            this.studentTblBindingSource.DataSource = this.schoolDbDataSet;
            // 
            // schoolDbDataSet
            // 
            this.schoolDbDataSet.DataSetName = "SchoolDbDataSet";
            this.schoolDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 79);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(133, 276);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(235, 31);
            this.dateTimePicker.TabIndex = 3;
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_tb.Location = new System.Drawing.Point(133, 118);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(273, 31);
            this.name_tb.TabIndex = 4;
            // 
            // class_cb
            // 
            this.class_cb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_cb.FormattingEnabled = true;
            this.class_cb.Items.AddRange(new object[] {
            "9",
            "10",
            "11"});
            this.class_cb.Location = new System.Drawing.Point(133, 213);
            this.class_cb.Name = "class_cb";
            this.class_cb.Size = new System.Drawing.Size(170, 33);
            this.class_cb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-4, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birthday Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fees";
            // 
            // gender_cb
            // 
            this.gender_cb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Items.AddRange(new object[] {
            "male",
            "female"});
            this.gender_cb.Location = new System.Drawing.Point(133, 164);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(170, 33);
            this.gender_cb.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Class";
            // 
            // fees_tb
            // 
            this.fees_tb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fees_tb.Location = new System.Drawing.Point(133, 509);
            this.fees_tb.Name = "fees_tb";
            this.fees_tb.Size = new System.Drawing.Size(261, 31);
            this.fees_tb.TabIndex = 7;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(33, 569);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(111, 51);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click_1);
            // 
            // address_rtb
            // 
            this.address_rtb.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_rtb.Location = new System.Drawing.Point(133, 341);
            this.address_rtb.Name = "address_rtb";
            this.address_rtb.Size = new System.Drawing.Size(287, 149);
            this.address_rtb.TabIndex = 9;
            this.address_rtb.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(33, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Address";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(176, 569);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(111, 51);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(309, 569);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(111, 51);
            this.edit_button.TabIndex = 8;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // studentTblTableAdapter
            // 
            this.studentTblTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(142, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.address_rtb);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.fees_tb);
            this.Controls.Add(this.gender_cb);
            this.Controls.Add(this.class_cb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentsDGV);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.ComboBox class_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gender_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fees_tb;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.RichTextBox address_rtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private SchoolDbDataSet schoolDbDataSet;
        private System.Windows.Forms.BindingSource studentTblBindingSource;
        private SchoolDbDataSetTableAdapters.StudentTblTableAdapter studentTblTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}