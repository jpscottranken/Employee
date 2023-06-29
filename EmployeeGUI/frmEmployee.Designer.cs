namespace EmployeeGUI
{
    partial class frmEmployee
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.lblAvgGrossPay = new System.Windows.Forms.Label();
            this.lblHighGrossPay = new System.Windows.Forms.Label();
            this.lblLowGrossPay = new System.Windows.Forms.Label();
            this.lblTotalGrossPay = new System.Windows.Forms.Label();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.txtAvgGrossPay = new System.Windows.Forms.TextBox();
            this.txtHighGrossPay = new System.Windows.Forms.TextBox();
            this.txtLowGrossPay = new System.Windows.Forms.TextBox();
            this.txtTotalGrossPay = new System.Windows.Forms.TextBox();
            this.txtTotalEmployees = new System.Windows.Forms.TextBox();
            this.bllTitle = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(65, 520);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(212, 69);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(687, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(212, 69);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1001, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(212, 69);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(62, 103);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(215, 38);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "FIrst Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(62, 187);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(215, 38);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.ForeColor = System.Drawing.Color.White;
            this.lblHoursWorked.Location = new System.Drawing.Point(62, 273);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(215, 38);
            this.lblHoursWorked.TabIndex = 15;
            this.lblHoursWorked.Text = "Hours Worked:";
            this.lblHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.ForeColor = System.Drawing.Color.White;
            this.lblHourlyRate.Location = new System.Drawing.Point(62, 356);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(215, 38);
            this.lblHourlyRate.TabIndex = 16;
            this.lblHourlyRate.Text = "Hourly Rate:";
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.ForeColor = System.Drawing.Color.White;
            this.lblGrossPay.Location = new System.Drawing.Point(62, 444);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(215, 38);
            this.lblGrossPay.TabIndex = 17;
            this.lblGrossPay.Text = "Gross Pay:";
            this.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(311, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(306, 38);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "firstname";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(311, 187);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(306, 38);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Tag = "lastname";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(311, 273);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(306, 38);
            this.txtHoursWorked.TabIndex = 2;
            this.txtHoursWorked.Tag = "hoursworked";
            this.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(311, 356);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(306, 38);
            this.txtHourlyRate.TabIndex = 3;
            this.txtHourlyRate.Tag = "hourlyrate";
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.Location = new System.Drawing.Point(311, 441);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(306, 38);
            this.txtGrossPay.TabIndex = 7;
            this.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAvgGrossPay
            // 
            this.lblAvgGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAvgGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGrossPay.ForeColor = System.Drawing.Color.White;
            this.lblAvgGrossPay.Location = new System.Drawing.Point(662, 447);
            this.lblAvgGrossPay.Name = "lblAvgGrossPay";
            this.lblAvgGrossPay.Size = new System.Drawing.Size(215, 35);
            this.lblAvgGrossPay.TabIndex = 22;
            this.lblAvgGrossPay.Text = "Avg Gross Pay:";
            this.lblAvgGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighGrossPay
            // 
            this.lblHighGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHighGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighGrossPay.ForeColor = System.Drawing.Color.White;
            this.lblHighGrossPay.Location = new System.Drawing.Point(662, 359);
            this.lblHighGrossPay.Name = "lblHighGrossPay";
            this.lblHighGrossPay.Size = new System.Drawing.Size(215, 35);
            this.lblHighGrossPay.TabIndex = 21;
            this.lblHighGrossPay.Text = "High Gross Pay:";
            this.lblHighGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowGrossPay
            // 
            this.lblLowGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLowGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowGrossPay.ForeColor = System.Drawing.Color.White;
            this.lblLowGrossPay.Location = new System.Drawing.Point(662, 276);
            this.lblLowGrossPay.Name = "lblLowGrossPay";
            this.lblLowGrossPay.Size = new System.Drawing.Size(215, 35);
            this.lblLowGrossPay.TabIndex = 20;
            this.lblLowGrossPay.Text = "Low Gross Pay:";
            this.lblLowGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalGrossPay
            // 
            this.lblTotalGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrossPay.ForeColor = System.Drawing.Color.White;
            this.lblTotalGrossPay.Location = new System.Drawing.Point(662, 190);
            this.lblTotalGrossPay.Name = "lblTotalGrossPay";
            this.lblTotalGrossPay.Size = new System.Drawing.Size(215, 35);
            this.lblTotalGrossPay.TabIndex = 19;
            this.lblTotalGrossPay.Text = "Total Gross Pay:";
            this.lblTotalGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalEmployees.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployees.ForeColor = System.Drawing.Color.White;
            this.lblTotalEmployees.Location = new System.Drawing.Point(662, 106);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(215, 35);
            this.lblTotalEmployees.TabIndex = 18;
            this.lblTotalEmployees.Text = "Total Employees:";
            this.lblTotalEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAvgGrossPay
            // 
            this.txtAvgGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgGrossPay.Location = new System.Drawing.Point(907, 444);
            this.txtAvgGrossPay.Name = "txtAvgGrossPay";
            this.txtAvgGrossPay.ReadOnly = true;
            this.txtAvgGrossPay.Size = new System.Drawing.Size(306, 38);
            this.txtAvgGrossPay.TabIndex = 12;
            this.txtAvgGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHighGrossPay
            // 
            this.txtHighGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighGrossPay.Location = new System.Drawing.Point(907, 359);
            this.txtHighGrossPay.Name = "txtHighGrossPay";
            this.txtHighGrossPay.ReadOnly = true;
            this.txtHighGrossPay.Size = new System.Drawing.Size(306, 38);
            this.txtHighGrossPay.TabIndex = 11;
            this.txtHighGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLowGrossPay
            // 
            this.txtLowGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLowGrossPay.Location = new System.Drawing.Point(907, 276);
            this.txtLowGrossPay.Name = "txtLowGrossPay";
            this.txtLowGrossPay.ReadOnly = true;
            this.txtLowGrossPay.Size = new System.Drawing.Size(306, 38);
            this.txtLowGrossPay.TabIndex = 10;
            this.txtLowGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalGrossPay
            // 
            this.txtTotalGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrossPay.Location = new System.Drawing.Point(907, 190);
            this.txtTotalGrossPay.Name = "txtTotalGrossPay";
            this.txtTotalGrossPay.ReadOnly = true;
            this.txtTotalGrossPay.Size = new System.Drawing.Size(306, 38);
            this.txtTotalGrossPay.TabIndex = 9;
            this.txtTotalGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalEmployees
            // 
            this.txtTotalEmployees.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEmployees.Location = new System.Drawing.Point(907, 106);
            this.txtTotalEmployees.Name = "txtTotalEmployees";
            this.txtTotalEmployees.ReadOnly = true;
            this.txtTotalEmployees.Size = new System.Drawing.Size(306, 38);
            this.txtTotalEmployees.TabIndex = 8;
            this.txtTotalEmployees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bllTitle
            // 
            this.bllTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bllTitle.Font = new System.Drawing.Font("Arial Narrow", 28.25F, System.Drawing.FontStyle.Bold);
            this.bllTitle.ForeColor = System.Drawing.Color.White;
            this.bllTitle.Location = new System.Drawing.Point(62, 27);
            this.bllTitle.Name = "bllTitle";
            this.bllTitle.Size = new System.Drawing.Size(1151, 45);
            this.bllTitle.TabIndex = 23;
            this.bllTitle.Text = "AWD1100 - Chapter 12 Pretest Creating An Employee Class";
            this.bllTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowList
            // 
            this.btnShowList.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowList.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(363, 520);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(212, 69);
            this.btnShowList.TabIndex = 24;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // frmEmployee
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1267, 620);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.bllTitle);
            this.Controls.Add(this.txtAvgGrossPay);
            this.Controls.Add(this.txtHighGrossPay);
            this.Controls.Add(this.txtLowGrossPay);
            this.Controls.Add(this.txtTotalGrossPay);
            this.Controls.Add(this.txtTotalEmployees);
            this.Controls.Add(this.lblAvgGrossPay);
            this.Controls.Add(this.lblHighGrossPay);
            this.Controls.Add(this.lblLowGrossPay);
            this.Controls.Add(this.lblTotalGrossPay);
            this.Controls.Add(this.lblTotalEmployees);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "////////////////////////////////////////////";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label lblAvgGrossPay;
        private System.Windows.Forms.Label lblHighGrossPay;
        private System.Windows.Forms.Label lblLowGrossPay;
        private System.Windows.Forms.Label lblTotalGrossPay;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.TextBox txtAvgGrossPay;
        private System.Windows.Forms.TextBox txtHighGrossPay;
        private System.Windows.Forms.TextBox txtLowGrossPay;
        private System.Windows.Forms.TextBox txtTotalGrossPay;
        private System.Windows.Forms.TextBox txtTotalEmployees;
        private System.Windows.Forms.Label bllTitle;
        private System.Windows.Forms.Button btnShowList;
    }
}

