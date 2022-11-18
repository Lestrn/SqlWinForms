namespace CurseWork
{
    partial class MagazineTable
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
            this.MagazineGroupBox = new System.Windows.Forms.GroupBox();
            this.AddNumberReaderLabel = new System.Windows.Forms.Label();
            this.AddNumberReaderTextBox = new System.Windows.Forms.TextBox();
            this.NumberReaderComboBox = new System.Windows.Forms.ComboBox();
            this.CodeNumberTextBox = new System.Windows.Forms.TextBox();
            this.NumberReaderLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.MagazineListView = new System.Windows.Forms.ListView();
            this.CodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberReaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MagazineGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MagazineGroupBox
            // 
            this.MagazineGroupBox.Controls.Add(this.AddNumberReaderLabel);
            this.MagazineGroupBox.Controls.Add(this.AddNumberReaderTextBox);
            this.MagazineGroupBox.Controls.Add(this.NumberReaderComboBox);
            this.MagazineGroupBox.Controls.Add(this.CodeNumberTextBox);
            this.MagazineGroupBox.Controls.Add(this.NumberReaderLabel);
            this.MagazineGroupBox.Controls.Add(this.CodeLabel);
            this.MagazineGroupBox.Controls.Add(this.StatusLabel);
            this.MagazineGroupBox.Controls.Add(this.StatusTextBox);
            this.MagazineGroupBox.Location = new System.Drawing.Point(9, 9);
            this.MagazineGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MagazineGroupBox.Name = "MagazineGroupBox";
            this.MagazineGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MagazineGroupBox.Size = new System.Drawing.Size(250, 348);
            this.MagazineGroupBox.TabIndex = 6;
            this.MagazineGroupBox.TabStop = false;
            this.MagazineGroupBox.Text = "Журнал";
            // 
            // AddNumberReaderLabel
            // 
            this.AddNumberReaderLabel.AutoSize = true;
            this.AddNumberReaderLabel.Location = new System.Drawing.Point(-2, 133);
            this.AddNumberReaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddNumberReaderLabel.Name = "AddNumberReaderLabel";
            this.AddNumberReaderLabel.Size = new System.Drawing.Size(91, 13);
            this.AddNumberReaderLabel.TabIndex = 10;
            this.AddNumberReaderLabel.Text = "Для добавления";
            // 
            // AddNumberReaderTextBox
            // 
            this.AddNumberReaderTextBox.Location = new System.Drawing.Point(0, 156);
            this.AddNumberReaderTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddNumberReaderTextBox.Name = "AddNumberReaderTextBox";
            this.AddNumberReaderTextBox.Size = new System.Drawing.Size(72, 20);
            this.AddNumberReaderTextBox.TabIndex = 9;
            // 
            // NumberReaderComboBox
            // 
            this.NumberReaderComboBox.FormattingEnabled = true;
            this.NumberReaderComboBox.Location = new System.Drawing.Point(154, 95);
            this.NumberReaderComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumberReaderComboBox.Name = "NumberReaderComboBox";
            this.NumberReaderComboBox.Size = new System.Drawing.Size(92, 21);
            this.NumberReaderComboBox.TabIndex = 8;
            // 
            // CodeNumberTextBox
            // 
            this.CodeNumberTextBox.Location = new System.Drawing.Point(67, 22);
            this.CodeNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodeNumberTextBox.Name = "CodeNumberTextBox";
            this.CodeNumberTextBox.Size = new System.Drawing.Size(72, 20);
            this.CodeNumberTextBox.TabIndex = 7;
            // 
            // NumberReaderLabel
            // 
            this.NumberReaderLabel.AutoSize = true;
            this.NumberReaderLabel.Location = new System.Drawing.Point(0, 98);
            this.NumberReaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberReaderLabel.Name = "NumberReaderLabel";
            this.NumberReaderLabel.Size = new System.Drawing.Size(156, 13);
            this.NumberReaderLabel.TabIndex = 6;
            this.NumberReaderLabel.Text = "Номер читетельского билета";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(0, 27);
            this.CodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(56, 13);
            this.CodeLabel.TabIndex = 5;
            this.CodeLabel.Text = "Код_УДК";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(0, 54);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(47, 13);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Статус: ";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(67, 54);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(72, 20);
            this.StatusTextBox.TabIndex = 3;
            // 
            // MagazineListView
            // 
            this.MagazineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeColumn,
            this.StatusColumn,
            this.NumberReaderColumn});
            this.MagazineListView.HideSelection = false;
            this.MagazineListView.Location = new System.Drawing.Point(264, 18);
            this.MagazineListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MagazineListView.Name = "MagazineListView";
            this.MagazineListView.Size = new System.Drawing.Size(315, 199);
            this.MagazineListView.TabIndex = 7;
            this.MagazineListView.UseCompatibleStateImageBehavior = false;
            this.MagazineListView.View = System.Windows.Forms.View.Details;
            this.MagazineListView.SelectedIndexChanged += new System.EventHandler(this.SelectedItem);
            // 
            // CodeColumn
            // 
            this.CodeColumn.Text = "Код_УДК";
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Статус";
            // 
            // NumberReaderColumn
            // 
            this.NumberReaderColumn.Text = "Номер читацького квитка";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(272, 235);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(68, 21);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(376, 235);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(76, 21);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(478, 235);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(68, 21);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MagazineTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MagazineListView);
            this.Controls.Add(this.MagazineGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MagazineTable";
            this.Text = "MagazineTable";
            this.Load += new System.EventHandler(this.MagazineLoad);
            this.MagazineGroupBox.ResumeLayout(false);
            this.MagazineGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MagazineGroupBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label AddNumberReaderLabel;
        private System.Windows.Forms.TextBox AddNumberReaderTextBox;
        private System.Windows.Forms.ComboBox NumberReaderComboBox;
        private System.Windows.Forms.TextBox CodeNumberTextBox;
        private System.Windows.Forms.Label NumberReaderLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.ListView MagazineListView;
        private System.Windows.Forms.ColumnHeader CodeColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private System.Windows.Forms.ColumnHeader NumberReaderColumn;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}