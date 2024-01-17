namespace PayrollGUI
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
            this.txtTotalGross = new System.Windows.Forms.TextBox();
            this.txtAverageGross = new System.Windows.Forms.TextBox();
            this.txtTotalEmps = new System.Windows.Forms.TextBox();
            this.lblAvgGross = new System.Windows.Forms.Label();
            this.lblTotalGross = new System.Windows.Forms.Label();
            this.lblTotalEmps = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotalGross
            // 
            this.txtTotalGross.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGross.Location = new System.Drawing.Point(874, 186);
            this.txtTotalGross.Name = "txtTotalGross";
            this.txtTotalGross.ReadOnly = true;
            this.txtTotalGross.Size = new System.Drawing.Size(201, 38);
            this.txtTotalGross.TabIndex = 9;
            this.txtTotalGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAverageGross
            // 
            this.txtAverageGross.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverageGross.Location = new System.Drawing.Point(874, 284);
            this.txtAverageGross.Name = "txtAverageGross";
            this.txtAverageGross.ReadOnly = true;
            this.txtAverageGross.Size = new System.Drawing.Size(201, 38);
            this.txtAverageGross.TabIndex = 10;
            this.txtAverageGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalEmps
            // 
            this.txtTotalEmps.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEmps.Location = new System.Drawing.Point(874, 72);
            this.txtTotalEmps.Name = "txtTotalEmps";
            this.txtTotalEmps.ReadOnly = true;
            this.txtTotalEmps.Size = new System.Drawing.Size(201, 38);
            this.txtTotalEmps.TabIndex = 8;
            this.txtTotalEmps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAvgGross
            // 
            this.lblAvgGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAvgGross.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGross.Location = new System.Drawing.Point(641, 287);
            this.lblAvgGross.Name = "lblAvgGross";
            this.lblAvgGross.Size = new System.Drawing.Size(198, 30);
            this.lblAvgGross.TabIndex = 18;
            this.lblAvgGross.Text = "Average Gross:";
            this.lblAvgGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalGross
            // 
            this.lblTotalGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalGross.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGross.Location = new System.Drawing.Point(641, 189);
            this.lblTotalGross.Name = "lblTotalGross";
            this.lblTotalGross.Size = new System.Drawing.Size(198, 30);
            this.lblTotalGross.TabIndex = 17;
            this.lblTotalGross.Text = "Total Gross:";
            this.lblTotalGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalEmps
            // 
            this.lblTotalEmps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalEmps.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmps.Location = new System.Drawing.Point(641, 72);
            this.lblTotalEmps.Name = "lblTotalEmps";
            this.lblTotalEmps.Size = new System.Drawing.Size(198, 30);
            this.lblTotalEmps.TabIndex = 16;
            this.lblTotalEmps.Text = "Total Emps:";
            this.lblTotalEmps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGross
            // 
            this.txtGross.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGross.Location = new System.Drawing.Point(391, 482);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(201, 38);
            this.txtGross.TabIndex = 7;
            this.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(391, 183);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(201, 38);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(391, 281);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(201, 38);
            this.txtHours.TabIndex = 2;
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(391, 390);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(201, 38);
            this.txtRate.TabIndex = 3;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(391, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(201, 38);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGross
            // 
            this.lblGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGross.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(158, 485);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(198, 30);
            this.lblGross.TabIndex = 15;
            this.lblGross.Text = "Gross:";
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(158, 393);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(198, 30);
            this.lblRate.TabIndex = 14;
            this.lblRate.Text = "Rate:";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHours
            // 
            this.lblHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHours.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(158, 284);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(198, 30);
            this.lblHours.TabIndex = 13;
            this.lblHours.Text = "Hours:";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(158, 186);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(198, 30);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(158, 69);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(198, 30);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(880, 576);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 69);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(516, 576);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(195, 69);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(161, 576);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(195, 69);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1232, 714);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalGross);
            this.Controls.Add(this.txtAverageGross);
            this.Controls.Add(this.txtTotalEmps);
            this.Controls.Add(this.lblAvgGross);
            this.Controls.Add(this.lblTotalGross);
            this.Controls.Add(this.lblTotalEmps);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotalGross;
        private System.Windows.Forms.TextBox txtAverageGross;
        private System.Windows.Forms.TextBox txtTotalEmps;
        private System.Windows.Forms.Label lblAvgGross;
        private System.Windows.Forms.Label lblTotalGross;
        private System.Windows.Forms.Label lblTotalEmps;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
    }
}

