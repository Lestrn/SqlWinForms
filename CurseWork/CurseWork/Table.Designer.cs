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
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ReaderGroupBox = new System.Windows.Forms.GroupBox();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.MagazineGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.LibraryGroupBox.SuspendLayout();
            this.ReaderGroupBox.SuspendLayout();
            this.MagazineGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(11, 423);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 24);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(142, 423);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(93, 24);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(340, 423);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(93, 24);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // LibraryGroupBox
            // 
            this.LibraryGroupBox.Controls.Add(this.AuthorTextBox);
            this.LibraryGroupBox.Controls.Add(this.AuthorLabel);
            this.LibraryGroupBox.Location = new System.Drawing.Point(61, 22);
            this.LibraryGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LibraryGroupBox.Name = "LibraryGroupBox";
            this.LibraryGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LibraryGroupBox.Size = new System.Drawing.Size(325, 379);
            this.LibraryGroupBox.TabIndex = 3;
            this.LibraryGroupBox.TabStop = false;
            this.LibraryGroupBox.Text = "Библиотека";
            this.LibraryGroupBox.Visible = false;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(94, 32);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(72, 20);
            this.AuthorTextBox.TabIndex = 1;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(5, 32);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(43, 13);
            this.AuthorLabel.TabIndex = 0;
            this.AuthorLabel.Text = "Автор: ";
            // 
            // ReaderGroupBox
            // 
            this.ReaderGroupBox.Controls.Add(this.FIOLabel);
            this.ReaderGroupBox.Controls.Add(this.FIOTextBox);
            this.ReaderGroupBox.Location = new System.Drawing.Point(61, 22);
            this.ReaderGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReaderGroupBox.Name = "ReaderGroupBox";
            this.ReaderGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReaderGroupBox.Size = new System.Drawing.Size(325, 379);
            this.ReaderGroupBox.TabIndex = 4;
            this.ReaderGroupBox.TabStop = false;
            this.ReaderGroupBox.Text = "Читатель";
            this.ReaderGroupBox.Visible = false;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(4, 34);
            this.FIOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(40, 13);
            this.FIOLabel.TabIndex = 2;
            this.FIOLabel.Text = "ФИО: ";
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(110, 32);
            this.FIOTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(72, 20);
            this.FIOTextBox.TabIndex = 2;
            // 
            // MagazineGroupBox
            // 
            this.MagazineGroupBox.Controls.Add(this.StatusLabel);
            this.MagazineGroupBox.Controls.Add(this.StatusTextBox);
            this.MagazineGroupBox.Location = new System.Drawing.Point(61, 22);
            this.MagazineGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MagazineGroupBox.Name = "MagazineGroupBox";
            this.MagazineGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MagazineGroupBox.Size = new System.Drawing.Size(325, 379);
            this.MagazineGroupBox.TabIndex = 5;
            this.MagazineGroupBox.TabStop = false;
            this.MagazineGroupBox.Text = "Журнал";
            this.MagazineGroupBox.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(4, 32);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(47, 13);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Статус: ";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(75, 32);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(72, 20);
            this.StatusTextBox.TabIndex = 3;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 494);
            this.Controls.Add(this.MagazineGroupBox);
            this.Controls.Add(this.ReaderGroupBox);
            this.Controls.Add(this.LibraryGroupBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.TableForm_Load);
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