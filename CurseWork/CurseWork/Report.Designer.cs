namespace CurseWork
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            this.libraryDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrintBtn = new System.Windows.Forms.Button();
            this.LibraryListView = new System.Windows.Forms.ListView();
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Photo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublishName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsNewDayOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(12, 21);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(776, 31);
            this.PrintBtn.TabIndex = 1;
            this.PrintBtn.Text = "To Excel";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // LibraryListView
            // 
            this.LibraryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookName,
            this.Author,
            this.DayOut,
            this.Genre,
            this.Photo,
            this.Code,
            this.PublishName,
            this.Price,
            this.Amount,
            this.IsNewDayOut,
            this.Description,
            this.KeyWords});
            this.LibraryListView.HideSelection = false;
            this.LibraryListView.Location = new System.Drawing.Point(13, 57);
            this.LibraryListView.Margin = new System.Windows.Forms.Padding(4);
            this.LibraryListView.Name = "LibraryListView";
            this.LibraryListView.Size = new System.Drawing.Size(775, 398);
            this.LibraryListView.TabIndex = 4;
            this.LibraryListView.UseCompatibleStateImageBehavior = false;
            this.LibraryListView.View = System.Windows.Forms.View.Details;
            // 
            // BookName
            // 
            this.BookName.Text = "Назва книги";
            // 
            // Author
            // 
            this.Author.Text = "Автор";
            // 
            // DayOut
            // 
            this.DayOut.Text = "Рік видавництва";
            // 
            // Genre
            // 
            this.Genre.Text = "Жанр";
            // 
            // Photo
            // 
            this.Photo.Text = "Обкладинка";
            // 
            // Code
            // 
            this.Code.Text = "Код УДК";
            // 
            // PublishName
            // 
            this.PublishName.DisplayIndex = 11;
            this.PublishName.Text = "Видавництво";
            // 
            // Price
            // 
            this.Price.DisplayIndex = 6;
            this.Price.Text = "Ціна";
            // 
            // Amount
            // 
            this.Amount.DisplayIndex = 7;
            this.Amount.Text = "Кількість";
            // 
            // IsNewDayOut
            // 
            this.IsNewDayOut.DisplayIndex = 8;
            this.IsNewDayOut.Text = "Нове видавництво";
            // 
            // Description
            // 
            this.Description.DisplayIndex = 9;
            this.Description.Text = "Опис";
            // 
            // KeyWords
            // 
            this.KeyWords.DisplayIndex = 10;
            this.KeyWords.Text = "Ключові слава";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LibraryListView);
            this.Controls.Add(this.PrintBtn);
            this.Name = "Report";
            this.Text = "Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Report_FormClosed);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource libraryDBBindingSource;
      
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.ListView LibraryListView;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader DayOut;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Photo;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader PublishName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader IsNewDayOut;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader KeyWords;
    }
}