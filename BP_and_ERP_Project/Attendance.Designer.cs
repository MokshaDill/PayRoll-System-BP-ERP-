namespace BP_and_ERP_Project
{
    partial class Attendance
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bP_PayrollDataSet = new BP_and_ERP_Project.BP_PayrollDataSet();
            this.empDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataTableAdapter = new BP_and_ERP_Project.BP_PayrollDataSetTableAdapters.EmpDataTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bP_PayrollDataSet2 = new BP_and_ERP_Project.BP_PayrollDataSet2();
            this.bP_PayrollDataSet1 = new BP_and_ERP_Project.BP_PayrollDataSet1();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new BP_and_ERP_Project.BP_PayrollDataSet1TableAdapters.AttendanceTableAdapter();
            this.attendanceTableAdapter1 = new BP_and_ERP_Project.BP_PayrollDataSet2TableAdapters.AttendanceTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bP_PayrollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bP_PayrollDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bP_PayrollDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Full-day",
            "Harf-Day"});
            this.comboBox2.Location = new System.Drawing.Point(156, 165);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Daily Attendance Form";
            // 
            // bP_PayrollDataSet
            // 
            this.bP_PayrollDataSet.DataSetName = "BP_PayrollDataSet";
            this.bP_PayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empDataBindingSource
            // 
            this.empDataBindingSource.DataMember = "EmpData";
            this.empDataBindingSource.DataSource = this.bP_PayrollDataSet;
            // 
            // empDataTableAdapter
            // 
            this.empDataTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.empDataBindingSource;
            this.comboBox4.DisplayMember = "ID";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(156, 76);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(150, 24);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.ValueMember = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Mark";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(340, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 181);
            this.dataGridView1.TabIndex = 15;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 80;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 50;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // attendanceBindingSource1
            // 
            this.attendanceBindingSource1.DataMember = "Attendance";
            this.attendanceBindingSource1.DataSource = this.bP_PayrollDataSet2;
            // 
            // bP_PayrollDataSet2
            // 
            this.bP_PayrollDataSet2.DataSetName = "BP_PayrollDataSet2";
            this.bP_PayrollDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bP_PayrollDataSet1
            // 
            this.bP_PayrollDataSet1.DataSetName = "BP_PayrollDataSet1";
            this.bP_PayrollDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.bP_PayrollDataSet1;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BP_and_ERP_Project.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(717, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(750, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bP_PayrollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bP_PayrollDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bP_PayrollDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private BP_PayrollDataSet bP_PayrollDataSet;
        private System.Windows.Forms.BindingSource empDataBindingSource;
        private BP_PayrollDataSetTableAdapters.EmpDataTableAdapter empDataTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BP_PayrollDataSet1 bP_PayrollDataSet1;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private BP_PayrollDataSet1TableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private BP_PayrollDataSet2 bP_PayrollDataSet2;
        private System.Windows.Forms.BindingSource attendanceBindingSource1;
        private BP_PayrollDataSet2TableAdapters.AttendanceTableAdapter attendanceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}