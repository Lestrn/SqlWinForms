namespace CurseWork
{
    partial class GenresTable
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
            this.GenresGroupBox = new System.Windows.Forms.GroupBox();
            this.CodeGenreLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.CodeGenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenresListView = new System.Windows.Forms.ListView();
            this.CodeGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(429, 339);
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
            this.RemoveButton.Location = new System.Drawing.Point(677, 306);
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
            this.EditButton.Location = new System.Drawing.Point(580, 361);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(93, 24);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // GenresGroupBox
            // 
            this.GenresGroupBox.Controls.Add(this.GenresListView);
            this.GenresGroupBox.Controls.Add(this.GenreTextBox);
            this.GenresGroupBox.Controls.Add(this.CodeGenreTextBox);
            this.GenresGroupBox.Controls.Add(this.GenreLabel);
            this.GenresGroupBox.Controls.Add(this.CodeGenreLabel);
            this.GenresGroupBox.Location = new System.Drawing.Point(54, 45);
            this.GenresGroupBox.Name = "GenresGroupBox";
            this.GenresGroupBox.Size = new System.Drawing.Size(528, 294);
            this.GenresGroupBox.TabIndex = 4;
            this.GenresGroupBox.TabStop = false;
            // 
            // CodeGenreLabel
            // 
            this.CodeGenreLabel.AutoSize = true;
            this.CodeGenreLabel.Location = new System.Drawing.Point(39, 32);
            this.CodeGenreLabel.Name = "CodeGenreLabel";
            this.CodeGenreLabel.Size = new System.Drawing.Size(61, 13);
            this.CodeGenreLabel.TabIndex = 0;
            this.CodeGenreLabel.Text = "Код жанра";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(39, 61);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 1;
            this.GenreLabel.Text = "Жанр";
            // 
            // CodeGenreTextBox
            // 
            this.CodeGenreTextBox.Location = new System.Drawing.Point(106, 25);
            this.CodeGenreTextBox.Name = "CodeGenreTextBox";
            this.CodeGenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodeGenreTextBox.TabIndex = 2;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(106, 61);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 3;
            // 
            // GenresListView
            // 
            this.GenresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeGenre,
            this.Genre});
            this.GenresListView.HideSelection = false;
            this.GenresListView.Location = new System.Drawing.Point(249, 19);
            this.GenresListView.Name = "GenresListView";
            this.GenresListView.Size = new System.Drawing.Size(121, 97);
            this.GenresListView.TabIndex = 4;
            this.GenresListView.UseCompatibleStateImageBehavior = false;
            this.GenresListView.View = System.Windows.Forms.View.Details;
            this.GenresListView.SelectedIndexChanged += new System.EventHandler(this.TableListViewItem_Selected);
            // 
            // CodeGenre
            // 
            this.CodeGenre.Text = "Код жанра";
            // 
            // Genre
            // 
            this.Genre.Text = "Жанр";
            // 
            // GenresTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenresGroupBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Name = "GenresTable";
            this.Text = "GenresTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Table_Closed);
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.GenresGroupBox.ResumeLayout(false);
            this.GenresGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox GenresGroupBox;
        private System.Windows.Forms.ListView GenresListView;
        private System.Windows.Forms.ColumnHeader CodeGenre;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox CodeGenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label CodeGenreLabel;
    }
}