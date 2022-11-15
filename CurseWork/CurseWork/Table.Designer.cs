namespace CurseWork
{
    partial class Table
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
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.LibraryGroupBox = new System.Windows.Forms.GroupBox();
            this.ReaderGroupBox = new System.Windows.Forms.GroupBox();
            this.MagazineGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LibraryGroupBox.SuspendLayout();
            this.ReaderGroupBox.SuspendLayout();
            this.MagazineGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 223);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 30);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(278, 223);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(124, 30);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(554, 223);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(124, 30);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // LibraryGroupBox
            // 
            this.LibraryGroupBox.Controls.Add(this.AuthorTextBox);
            this.LibraryGroupBox.Controls.Add(this.AuthorLabel);
            this.LibraryGroupBox.Location = new System.Drawing.Point(233, 12);
            this.LibraryGroupBox.Name = "LibraryGroupBox";
            this.LibraryGroupBox.Size = new System.Drawing.Size(226, 187);
            this.LibraryGroupBox.TabIndex = 3;
            this.LibraryGroupBox.TabStop = false;
            this.LibraryGroupBox.Text = "Библиотека";
            // 
            // ReaderGroupBox
            // 
            this.ReaderGroupBox.Controls.Add(this.FIOLabel);
            this.ReaderGroupBox.Controls.Add(this.FIOTextBox);
            this.ReaderGroupBox.Location = new System.Drawing.Point(465, 12);
            this.ReaderGroupBox.Name = "ReaderGroupBox";
            this.ReaderGroupBox.Size = new System.Drawing.Size(240, 187);
            this.ReaderGroupBox.TabIndex = 4;
            this.ReaderGroupBox.TabStop = false;
            this.ReaderGroupBox.Text = "Читатель";
            this.ReaderGroupBox.Visible = false;
            // 
            // MagazineGroupBox
            // 
            this.MagazineGroupBox.Controls.Add(this.StatusLabel);
            this.MagazineGroupBox.Controls.Add(this.StatusTextBox);
            this.MagazineGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MagazineGroupBox.Name = "MagazineGroupBox";
            this.MagazineGroupBox.Size = new System.Drawing.Size(200, 187);
            this.MagazineGroupBox.TabIndex = 5;
            this.MagazineGroupBox.TabStop = false;
            this.MagazineGroupBox.Text = "Журнал";
            this.MagazineGroupBox.Visible = false;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(7, 39);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(53, 16);
            this.AuthorLabel.TabIndex = 0;
            this.AuthorLabel.Text = "Автор: ";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(126, 39);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(94, 22);
            this.AuthorTextBox.TabIndex = 1;
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(146, 39);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(94, 22);
            this.FIOTextBox.TabIndex = 2;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(100, 39);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(94, 22);
            this.StatusTextBox.TabIndex = 3;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(6, 42);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(44, 16);
            this.FIOLabel.TabIndex = 2;
            this.FIOLabel.Text = "ФИО: ";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(6, 39);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(59, 16);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Статус: ";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 381);
            this.Controls.Add(this.MagazineGroupBox);
            this.Controls.Add(this.ReaderGroupBox);
            this.Controls.Add(this.LibraryGroupBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Name = "Table";
            this.Text = "Table";
            this.LibraryGroupBox.ResumeLayout(false);
            this.LibraryGroupBox.PerformLayout();
            this.ReaderGroupBox.ResumeLayout(false);
            this.ReaderGroupBox.PerformLayout();
            this.MagazineGroupBox.ResumeLayout(false);
            this.MagazineGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox LibraryGroupBox;
        private System.Windows.Forms.GroupBox ReaderGroupBox;
        private System.Windows.Forms.GroupBox MagazineGroupBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label StatusLabel;
    }
}