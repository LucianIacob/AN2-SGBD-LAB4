namespace LAB4_SGBD
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
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand = new System.Data.SqlClient.SqlCommand();
            this.lstProduse = new System.Windows.Forms.ListView();
            this.Cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstStocuri = new System.Windows.Forms.ListView();
            this.CodProdus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Luna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.An = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEndTR = new System.Windows.Forms.Button();
            this.btnBeginTR = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlConnection
            // 
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection_InfoMessage);
            // 
            // sqlCommand
            // 
            this.sqlCommand.Connection = this.sqlConnection;
            // 
            // lstProduse
            // 
            this.lstProduse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cod,
            this.Denumire,
            this.Pret});
            this.lstProduse.Location = new System.Drawing.Point(35, 61);
            this.lstProduse.Name = "lstProduse";
            this.lstProduse.Size = new System.Drawing.Size(159, 124);
            this.lstProduse.TabIndex = 0;
            this.lstProduse.UseCompatibleStateImageBehavior = false;
            this.lstProduse.View = System.Windows.Forms.View.Details;
            this.lstProduse.SelectedIndexChanged += new System.EventHandler(this.lstProduse_SelectedIndexChanged);
            // 
            // Cod
            // 
            this.Cod.Text = "Cod";
            this.Cod.Width = 35;
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 70;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            this.Pret.Width = 50;
            // 
            // lstStocuri
            // 
            this.lstStocuri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodProdus,
            this.Luna,
            this.An,
            this.Stoc});
            this.lstStocuri.Location = new System.Drawing.Point(35, 191);
            this.lstStocuri.Name = "lstStocuri";
            this.lstStocuri.Size = new System.Drawing.Size(159, 63);
            this.lstStocuri.TabIndex = 1;
            this.lstStocuri.UseCompatibleStateImageBehavior = false;
            this.lstStocuri.View = System.Windows.Forms.View.Details;
            this.lstStocuri.SelectedIndexChanged += new System.EventHandler(this.lstStocuri_SelectedIndexChanged);
            // 
            // CodProdus
            // 
            this.CodProdus.Text = "Cod";
            this.CodProdus.Width = 35;
            // 
            // Luna
            // 
            this.Luna.Text = "Luna";
            this.Luna.Width = 40;
            // 
            // An
            // 
            this.An.Text = "An";
            this.An.Width = 40;
            // 
            // Stoc
            // 
            this.Stoc.Text = "Stoc";
            this.Stoc.Width = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMonth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(219, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 225);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Stocks";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Del";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(9, 110);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(84, 20);
            this.txtStock.TabIndex = 8;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(9, 71);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(84, 20);
            this.txtYear.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Month:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(9, 32);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(84, 20);
            this.txtMonth.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEndTR);
            this.groupBox2.Controls.Add(this.btnBeginTR);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(337, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 199);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Isolation Level";
            // 
            // btnEndTR
            // 
            this.btnEndTR.Location = new System.Drawing.Point(6, 170);
            this.btnEndTR.Name = "btnEndTR";
            this.btnEndTR.Size = new System.Drawing.Size(113, 23);
            this.btnEndTR.TabIndex = 6;
            this.btnEndTR.Text = "End Transaction";
            this.btnEndTR.UseVisualStyleBackColor = true;
            this.btnEndTR.Click += new System.EventHandler(this.btnEndTR_Click);
            // 
            // btnBeginTR
            // 
            this.btnBeginTR.Location = new System.Drawing.Point(6, 141);
            this.btnBeginTR.Name = "btnBeginTR";
            this.btnBeginTR.Size = new System.Drawing.Size(113, 23);
            this.btnBeginTR.TabIndex = 5;
            this.btnBeginTR.Text = "Begin Transaction";
            this.btnBeginTR.UseVisualStyleBackColor = true;
            this.btnBeginTR.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(113, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Read Uncommited";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Serializable";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Repetable Read";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Read Commited";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(35, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Load Data";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 289);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstProduse);
            this.Controls.Add(this.lstStocuri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand;
        private System.Windows.Forms.ListView lstProduse;
        private System.Windows.Forms.ColumnHeader Cod;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ListView lstStocuri;
        private System.Windows.Forms.ColumnHeader CodProdus;
        private System.Windows.Forms.ColumnHeader Luna;
        private System.Windows.Forms.ColumnHeader An;
        private System.Windows.Forms.ColumnHeader Stoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEndTR;
        private System.Windows.Forms.Button btnBeginTR;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button6;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}

