namespace Airrport
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
            this.DgvAirport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbAirline = new System.Windows.Forms.ComboBox();
            this.LblAirline = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.LblGate = new System.Windows.Forms.Label();
            this.CmbGate = new System.Windows.Forms.ComboBox();
            this.LblRunway = new System.Windows.Forms.Label();
            this.CmbRunway = new System.Windows.Forms.ComboBox();
            this.LblType = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAirport)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAirport
            // 
            this.DgvAirport.AllowUserToAddRows = false;
            this.DgvAirport.AllowUserToDeleteRows = false;
            this.DgvAirport.AllowUserToResizeColumns = false;
            this.DgvAirport.AllowUserToResizeRows = false;
            this.DgvAirport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAirport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAirport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column5,
            this.LblDate,
            this.Column3,
            this.Column7});
            this.DgvAirport.Location = new System.Drawing.Point(279, 1);
            this.DgvAirport.Name = "DgvAirport";
            this.DgvAirport.Size = new System.Drawing.Size(751, 341);
            this.DgvAirport.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Airline";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "City";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Gate";
            this.Column5.Name = "Column5";
            // 
            // LblDate
            // 
            this.LblDate.HeaderText = "Runway";
            this.LblDate.Name = "LblDate";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TargetDate";
            this.Column7.Name = "Column7";
            // 
            // CmbAirline
            // 
            this.CmbAirline.FormattingEnabled = true;
            this.CmbAirline.Location = new System.Drawing.Point(22, 34);
            this.CmbAirline.Name = "CmbAirline";
            this.CmbAirline.Size = new System.Drawing.Size(164, 21);
            this.CmbAirline.TabIndex = 1;
            // 
            // LblAirline
            // 
            this.LblAirline.AutoSize = true;
            this.LblAirline.Location = new System.Drawing.Point(19, 18);
            this.LblAirline.Name = "LblAirline";
            this.LblAirline.Size = new System.Drawing.Size(35, 13);
            this.LblAirline.TabIndex = 2;
            this.LblAirline.Text = "Airline";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(19, 80);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(24, 13);
            this.LblCity.TabIndex = 4;
            this.LblCity.Text = "City";
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(22, 96);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(164, 21);
            this.CmbCity.TabIndex = 3;
            // 
            // LblGate
            // 
            this.LblGate.AutoSize = true;
            this.LblGate.Location = new System.Drawing.Point(19, 143);
            this.LblGate.Name = "LblGate";
            this.LblGate.Size = new System.Drawing.Size(30, 13);
            this.LblGate.TabIndex = 6;
            this.LblGate.Text = "Gate";
            // 
            // CmbGate
            // 
            this.CmbGate.FormattingEnabled = true;
            this.CmbGate.Location = new System.Drawing.Point(22, 159);
            this.CmbGate.Name = "CmbGate";
            this.CmbGate.Size = new System.Drawing.Size(164, 21);
            this.CmbGate.TabIndex = 5;
            // 
            // LblRunway
            // 
            this.LblRunway.AutoSize = true;
            this.LblRunway.Location = new System.Drawing.Point(19, 204);
            this.LblRunway.Name = "LblRunway";
            this.LblRunway.Size = new System.Drawing.Size(46, 13);
            this.LblRunway.TabIndex = 8;
            this.LblRunway.Text = "Runway";
            // 
            // CmbRunway
            // 
            this.CmbRunway.FormattingEnabled = true;
            this.CmbRunway.Location = new System.Drawing.Point(22, 220);
            this.CmbRunway.Name = "CmbRunway";
            this.CmbRunway.Size = new System.Drawing.Size(164, 21);
            this.CmbRunway.TabIndex = 7;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(19, 267);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(31, 13);
            this.LblType.TabIndex = 11;
            this.LblType.Text = "Type";
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Enis",
            "Qalxis"});
            this.CmbType.Location = new System.Drawing.Point(22, 283);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(164, 21);
            this.CmbType.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date";
            // 
            // DtpDate
            // 
            this.DtpDate.Location = new System.Drawing.Point(22, 345);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(164, 20);
            this.DtpDate.TabIndex = 14;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(22, 393);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(164, 36);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 544);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.LblRunway);
            this.Controls.Add(this.CmbRunway);
            this.Controls.Add(this.LblGate);
            this.Controls.Add(this.CmbGate);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.CmbCity);
            this.Controls.Add(this.LblAirline);
            this.Controls.Add(this.CmbAirline);
            this.Controls.Add(this.DgvAirport);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAirport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAirport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn LblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox CmbAirline;
        private System.Windows.Forms.Label LblAirline;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Label LblGate;
        private System.Windows.Forms.ComboBox CmbGate;
        private System.Windows.Forms.Label LblRunway;
        private System.Windows.Forms.ComboBox CmbRunway;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Button BtnAdd;
    }
}

