namespace Eclerx.Question4.Niraj
{
    partial class Form1
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
            this.txtEmployeeNo = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblEmployeeNo = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.radioButtonPayroll = new System.Windows.Forms.RadioButton();
            this.radioButtonConsultant = new System.Windows.Forms.RadioButton();
            this.GropBoxEmployeeType = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.GropBoxEmployeeType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeNo
            // 
            this.txtEmployeeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNo.Location = new System.Drawing.Point(325, 54);
            this.txtEmployeeNo.Name = "txtEmployeeNo";
            this.txtEmployeeNo.Size = new System.Drawing.Size(162, 27);
            this.txtEmployeeNo.TabIndex = 0;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(325, 134);
            this.txtEmployeeName.MaxLength = 20;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(162, 27);
            this.txtEmployeeName.TabIndex = 1;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(325, 205);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(162, 27);
            this.txtSalary.TabIndex = 2;
            // 
            // lblEmployeeNo
            // 
            this.lblEmployeeNo.AutoSize = true;
            this.lblEmployeeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNo.Location = new System.Drawing.Point(155, 57);
            this.lblEmployeeNo.Name = "lblEmployeeNo";
            this.lblEmployeeNo.Size = new System.Drawing.Size(119, 20);
            this.lblEmployeeNo.TabIndex = 3;
            this.lblEmployeeNo.Text = "Employee No";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(155, 134);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(144, 20);
            this.lblEmployeeName.TabIndex = 4;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(155, 212);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(62, 20);
            this.lblSalary.TabIndex = 5;
            this.lblSalary.Text = "Salary";
            // 
            // radioButtonPayroll
            // 
            this.radioButtonPayroll.AutoSize = true;
            this.radioButtonPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPayroll.Location = new System.Drawing.Point(23, 55);
            this.radioButtonPayroll.Name = "radioButtonPayroll";
            this.radioButtonPayroll.Size = new System.Drawing.Size(88, 24);
            this.radioButtonPayroll.TabIndex = 9;
            this.radioButtonPayroll.TabStop = true;
            this.radioButtonPayroll.Text = "Payroll";
            this.radioButtonPayroll.UseVisualStyleBackColor = true;
            // 
            // radioButtonConsultant
            // 
            this.radioButtonConsultant.AutoSize = true;
            this.radioButtonConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonConsultant.Location = new System.Drawing.Point(23, 109);
            this.radioButtonConsultant.Name = "radioButtonConsultant";
            this.radioButtonConsultant.Size = new System.Drawing.Size(120, 24);
            this.radioButtonConsultant.TabIndex = 10;
            this.radioButtonConsultant.TabStop = true;
            this.radioButtonConsultant.Text = "Consultant";
            this.radioButtonConsultant.UseVisualStyleBackColor = true;
            // 
            // GropBoxEmployeeType
            // 
            this.GropBoxEmployeeType.Controls.Add(this.radioButtonPayroll);
            this.GropBoxEmployeeType.Controls.Add(this.radioButtonConsultant);
            this.GropBoxEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GropBoxEmployeeType.Location = new System.Drawing.Point(545, 54);
            this.GropBoxEmployeeType.Name = "GropBoxEmployeeType";
            this.GropBoxEmployeeType.Size = new System.Drawing.Size(221, 175);
            this.GropBoxEmployeeType.TabIndex = 11;
            this.GropBoxEmployeeType.TabStop = false;
            this.GropBoxEmployeeType.Text = "Employee Type";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(220, 283);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 36);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(442, 283);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 36);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(93, 339);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(673, 283);
            this.dataGridViewEmployee.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 673);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.GropBoxEmployeeType);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeNo);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GropBoxEmployeeType.ResumeLayout(false);
            this.GropBoxEmployeeType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeNo;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblEmployeeNo;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.RadioButton radioButtonPayroll;
        private System.Windows.Forms.RadioButton radioButtonConsultant;
        private System.Windows.Forms.GroupBox GropBoxEmployeeType;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
    }
}

