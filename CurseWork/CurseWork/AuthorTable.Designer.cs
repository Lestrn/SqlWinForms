namespace CurseWork
{
    partial class AuthorTable
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
            this.AuthorGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthorListView = new System.Windows.Forms.ListView();
            this.CodeAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.PIBLabel = new System.Windows.Forms.Label();
            this.PIBTextBox = new System.Windows.Forms.TextBox();
            this.CodeAuthorTextBox = new System.Windows.Forms.TextBox();
            this.CodeAuthorLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AuthorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorGroupBox
            // 
            this.AuthorGroupBox.Controls.Add(this.AuthorListView);
            this.AuthorGroupBox.Controls.Add(this.NoteTextBox);
            this.AuthorGroupBox.Controls.Add(this.NoteLabel);
            this.AuthorGroupBox.Controls.Add(this.PIBLabel);
            this.AuthorGroupBox.Controls.Add(this.PIBTextBox);
            this.AuthorGroupBox.Controls.Add(this.CodeAuthorTextBox);
            this.AuthorGroupBox.Controls.Add(this.CodeAuthorLabel);
            this.AuthorGroupBox.Location = new System.Drawing.Point(139, 12);
            this.AuthorGroupBox.Name = "AuthorGroupBox";
            this.AuthorGroupBox.Size = new System.Drawing.Size(589, 388);
            this.AuthorGroupBox.TabIndex = 0;
            this.AuthorGroupBox.TabStop = false;
            // 
            // AuthorListView
            // 
            this.AuthorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeAuthor,
            this.PIB,
            this.Note});
            this.AuthorListView.HideSelection = false;
            this.AuthorListView.Location = new System.Drawing.Point(272, 41);
            this.AuthorListView.Name = "AuthorListView";
            this.AuthorListView.Size = new System.Drawing.Size(264, 97);
            this.AuthorListView.TabIndex = 6;
            this.AuthorListView.UseCompatibleStateImageBehavior = false;
            this.AuthorListView.View = System.Windows.Forms.View.Details;
            this.AuthorListView.SelectedIndexChanged += new System.EventHandler(this.TableListViewItem_Selected);
            // 
            // CodeAuthor
            // 
            this.CodeAuthor.Text = "Код автора";
            // 
            // PIB
            // 
            this.PIB.Text = "ФІО";
            // 
            // Note
            // 
            this.Note.Text = "Заметка";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(99, 131);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoteTextBox.TabIndex = 5;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(29, 131);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(51, 13);
            this.NoteLabel.TabIndex = 4;
            this.NoteLabel.Text = "Заметка";
            // 
            // PIBLabel
            // 
            this.PIBLabel.AutoSize = true;
            this.PIBLabel.Location = new System.Drawing.Point(29, 87);
            this.PIBLabel.Name = "PIBLabel";
            this.PIBLabel.Size = new System.Drawing.Size(29, 13);
            this.PIBLabel.TabIndex = 3;
            this.PIBLabel.Text = "ФІО";
            // 
            // PIBTextBox
            // 
            this.PIBTextBox.Location = new System.Drawing.Point(99, 80);
            this.PIBTextBox.Name = "PIBTextBox";
            this.PIBTextBox.Size = new System.Drawing.Size(100, 20);
            this.PIBTextBox.TabIndex = 2;
            // 
            // CodeAuthorTextBox
            // 
            this.CodeAuthorTextBox.Location = new System.Drawing.Point(99, 41);
            this.CodeAuthorTextBox.Name = "CodeAuthorTextBox";
            this.CodeAuthorTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodeAuthorTextBox.TabIndex = 1;
            // 
            // CodeAuthorLabel
            // 
            this.CodeAuthorLabel.AutoSize = true;
            this.CodeAuthorLabel.Location = new System.Drawing.Point(29, 44);
            this.CodeAuthorLabel.Name = "CodeAuthorLabel";
            this.CodeAuthorLabel.Size = new System.Drawing.Size(64, 13);
            this.CodeAuthorLabel.TabIndex = 0;
            this.CodeAuthorLabel.Text = "Код автора";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(11, 415);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 24);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(211, 415);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(93, 24);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(361, 415);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(93, 24);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AuthorTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AuthorGroupBox);
            this.Name = "AuthorTable";
            this.Text = "AuthorTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Table_Closed);
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.AuthorGroupBox.ResumeLayout(false);
            this.AuthorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AuthorGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListView AuthorListView;
        private System.Windows.Forms.ColumnHeader CodeAuthor;
        private System.Windows.Forms.ColumnHeader PIB;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label PIBLabel;
        private System.Windows.Forms.TextBox PIBTextBox;
        private System.Windows.Forms.TextBox CodeAuthorTextBox;
        private System.Windows.Forms.Label CodeAuthorLabel;
    }
}