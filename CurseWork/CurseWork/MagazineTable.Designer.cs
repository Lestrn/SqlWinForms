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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NumberReaderLabel = new System.Windows.Forms.Label();
            this.CodeNumberTextBox = new System.Windows.Forms.TextBox();
            this.NumberReaderComboBox = new System.Windows.Forms.ComboBox();
            this.AddNumberReaderTextBox = new System.Windows.Forms.TextBox();
            this.AddNumberReaderLabel = new System.Windows.Forms.Label();
            this.MagazineListView = new System.Windows.Forms.ListView();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberReaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.MagazineGroupBox.Location = new System.Drawing.Point(12, 11);
            this.MagazineGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MagazineGroupBox.Name = "MagazineGroupBox";
            this.MagazineGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MagazineGroupBox.Size = new System.Drawing.Size(334, 428);
            this.MagazineGroupBox.TabIndex = 6;
            this.MagazineGroupBox.TabStop = false;
            this.MagazineGroupBox.Text = "Журнал";
            this.MagazineGroupBox.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(0, 66);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(59, 16);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Статус: ";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(89, 66);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(95, 22);
            this.StatusTextBox.TabIndex = 3;
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(0, 33);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(64, 16);
            this.CodeLabel.TabIndex = 5;
            this.CodeLabel.Text = "Код_УДК";
            // 
            // NumberReaderLabel
            // 
            this.NumberReaderLabel.AutoSize = true;
            this.NumberReaderLabel.Location = new System.Drawing.Point(0, 120);
            this.NumberReaderLabel.Name = "NumberReaderLabel";
            this.NumberReaderLabel.Size = new System.Drawing.Size(200, 16);
            this.NumberReaderLabel.TabIndex = 6;
            this.NumberReaderLabel.Text = "Номер читетельского билета";
            // 
            // CodeNumberTextBox
            // 
            this.CodeNumberTextBox.Location = new System.Drawing.Point(89, 27);
            this.CodeNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeNumberTextBox.Name = "CodeNumberTextBox";
            this.CodeNumberTextBox.Size = new System.Drawing.Size(95, 22);
            this.CodeNumberTextBox.TabIndex = 7;
            // 
            // NumberReaderComboBox
            // 
            this.NumberReaderComboBox.FormattingEnabled = true;
            this.NumberReaderComboBox.Location = new System.Drawing.Point(206, 117);
            this.NumberReaderComboBox.Name = "NumberReaderComboBox";
            this.NumberReaderComboBox.Size = new System.Drawing.Size(121, 24);
            this.NumberReaderComboBox.TabIndex = 8;
            // 
            // AddNumberReaderTextBox
            // 
            this.AddNumberReaderTextBox.Location = new System.Drawing.Point(0, 192);
            this.AddNumberReaderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNumberReaderTextBox.Name = "AddNumberReaderTextBox";
            this.AddNumberReaderTextBox.Size = new System.Drawing.Size(95, 22);
            this.AddNumberReaderTextBox.TabIndex = 9;
            // 
            // AddNumberReaderLabel
            // 
            this.AddNumberReaderLabel.AutoSize = true;
            this.AddNumberReaderLabel.Location = new System.Drawing.Point(-3, 164);
            this.AddNumberReaderLabel.Name = "AddNumberReaderLabel";
            this.AddNumberReaderLabel.Size = new System.Drawing.Size(113, 16);
            this.AddNumberReaderLabel.TabIndex = 10;
            this.AddNumberReaderLabel.Text = "Для добавления";
            // 
            // MagazineListView
            // 
            this.MagazineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeColumn,
            this.StatusColumn,
            this.NumberReaderColumn});
            this.MagazineListView.HideSelection = false;
            this.MagazineListView.Location = new System.Drawing.Point(352, 22);
            this.MagazineListView.Name = "MagazineListView";
            this.MagazineListView.Size = new System.Drawing.Size(419, 244);
            this.MagazineListView.TabIndex = 7;
            this.MagazineListView.UseCompatibleStateImageBehavior = false;
            this.MagazineListView.View = System.Windows.Forms.View.Details;
            this.MagazineListView.SelectedIndexChanged += new System.EventHandler(this.SelectedItem);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(363, 289);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 26);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(502, 289);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(102, 26);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(638, 289);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 26);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            // MagazineTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MagazineListView);
            this.Controls.Add(this.MagazineGroupBox);
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