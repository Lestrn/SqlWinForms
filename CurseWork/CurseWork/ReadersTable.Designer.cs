namespace CurseWork
{
    partial class ReadersTable
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
            this.ReaderGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.NumberReaderLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NumberReaderTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIBColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReaderGroupBox
            // 
            this.ReaderGroupBox.Controls.Add(this.NumberReaderTextBox);
            this.ReaderGroupBox.Controls.Add(this.PhoneTextBox);
            this.ReaderGroupBox.Controls.Add(this.AdressTextBox);
            this.ReaderGroupBox.Controls.Add(this.PhoneLabel);
            this.ReaderGroupBox.Controls.Add(this.AdressLabel);
            this.ReaderGroupBox.Controls.Add(this.NumberReaderLabel);
            this.ReaderGroupBox.Controls.Add(this.FIOLabel);
            this.ReaderGroupBox.Controls.Add(this.FIOTextBox);
            this.ReaderGroupBox.Location = new System.Drawing.Point(12, 11);
            this.ReaderGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReaderGroupBox.Name = "ReaderGroupBox";
            this.ReaderGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReaderGroupBox.Size = new System.Drawing.Size(352, 407);
            this.ReaderGroupBox.TabIndex = 5;
            this.ReaderGroupBox.TabStop = false;
            this.ReaderGroupBox.Text = "Читатель";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(6, 204);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(119, 16);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Номер телефона";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(6, 125);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(111, 16);
            this.AdressLabel.TabIndex = 4;
            this.AdressLabel.Text = "Адрес читателя";
            // 
            // NumberReaderLabel
            // 
            this.NumberReaderLabel.AutoSize = true;
            this.NumberReaderLabel.Location = new System.Drawing.Point(6, 28);
            this.NumberReaderLabel.Name = "NumberReaderLabel";
            this.NumberReaderLabel.Size = new System.Drawing.Size(200, 16);
            this.NumberReaderLabel.TabIndex = 3;
            this.NumberReaderLabel.Text = "Номер читетельского билета";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(6, 68);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(44, 16);
            this.FIOLabel.TabIndex = 2;
            this.FIOLabel.Text = "ФИО: ";
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(142, 62);
            this.FIOTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(95, 22);
            this.FIOTextBox.TabIndex = 2;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(142, 125);
            this.AdressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(95, 22);
            this.AdressTextBox.TabIndex = 6;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(142, 198);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(95, 22);
            this.PhoneTextBox.TabIndex = 7;
            // 
            // NumberReaderTextBox
            // 
            this.NumberReaderTextBox.Location = new System.Drawing.Point(238, 22);
            this.NumberReaderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberReaderTextBox.Name = "NumberReaderTextBox";
            this.NumberReaderTextBox.Size = new System.Drawing.Size(95, 22);
            this.NumberReaderTextBox.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberColumn,
            this.PIBColumn,
            this.AddressColumn,
            this.PhoneColumn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(370, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(396, 219);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ReadersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ReaderGroupBox);
            this.Name = "ReadersTable";
            this.Text = "ReadersTable";
            this.ReaderGroupBox.ResumeLayout(false);
            this.ReaderGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ReaderGroupBox;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label NumberReaderLabel;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.TextBox NumberReaderTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NumberColumn;
        private System.Windows.Forms.ColumnHeader PIBColumn;
        private System.Windows.Forms.ColumnHeader AddressColumn;
        private System.Windows.Forms.ColumnHeader PhoneColumn;
    }
}