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
            this.ReadersListView = new System.Windows.Forms.ListView();
            this.NumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIBColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.NumberReaderComboBox = new System.Windows.Forms.ComboBox();
            this.ForAddTextBox = new System.Windows.Forms.TextBox();
            this.ReaderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReaderGroupBox
            // 
            this.ReaderGroupBox.Controls.Add(this.ForAddTextBox);
            this.ReaderGroupBox.Controls.Add(this.NumberReaderComboBox);
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
            this.FIOLabel.Location = new System.Drawing.Point(6, 99);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(44, 16);
            this.FIOLabel.TabIndex = 2;
            this.FIOLabel.Text = "ФИО: ";
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(142, 99);
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
            // ReadersListView
            // 
            this.ReadersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberColumn,
            this.PIBColumn,
            this.AddressColumn,
            this.PhoneColumn});
            this.ReadersListView.HideSelection = false;
            this.ReadersListView.Location = new System.Drawing.Point(370, 12);
            this.ReadersListView.Name = "ReadersListView";
            this.ReadersListView.Size = new System.Drawing.Size(396, 219);
            this.ReadersListView.TabIndex = 6;
            this.ReadersListView.UseCompatibleStateImageBehavior = false;
            this.ReadersListView.View = System.Windows.Forms.View.Details;
            this.ReadersListView.SelectedIndexChanged += new System.EventHandler(this.SelectedItem);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(380, 256);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(509, 256);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(642, 256);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(105, 23);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NumberReaderComboBox
            // 
            this.NumberReaderComboBox.FormattingEnabled = true;
            this.NumberReaderComboBox.Location = new System.Drawing.Point(212, 25);
            this.NumberReaderComboBox.Name = "NumberReaderComboBox";
            this.NumberReaderComboBox.Size = new System.Drawing.Size(121, 24);
            this.NumberReaderComboBox.TabIndex = 10;
            // 
            // ForAddTextBox
            // 
            this.ForAddTextBox.Location = new System.Drawing.Point(212, 54);
            this.ForAddTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ForAddTextBox.Name = "ForAddTextBox";
            this.ForAddTextBox.Size = new System.Drawing.Size(95, 22);
            this.ForAddTextBox.TabIndex = 11;
            // 
            // ReadersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ReadersListView);
            this.Controls.Add(this.ReaderGroupBox);
            this.Name = "ReadersTable";
            this.Text = "ReadersTable";
            this.Load += new System.EventHandler(this.ReadersLoad);
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
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.ListView ReadersListView;
        private System.Windows.Forms.ColumnHeader NumberColumn;
        private System.Windows.Forms.ColumnHeader PIBColumn;
        private System.Windows.Forms.ColumnHeader AddressColumn;
        private System.Windows.Forms.ColumnHeader PhoneColumn;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ComboBox NumberReaderComboBox;
        private System.Windows.Forms.TextBox ForAddTextBox;
    }
}