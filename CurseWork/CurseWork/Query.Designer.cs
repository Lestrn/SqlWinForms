namespace CurseWork
{
    partial class Query
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
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.FirstQueryViewList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Enabled = false;
            this.QueryTextBox.Location = new System.Drawing.Point(3, 71);
            this.QueryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(423, 73);
            this.QueryTextBox.TabIndex = 0;
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CaptionLabel.Location = new System.Drawing.Point(12, 18);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(82, 31);
            this.CaptionLabel.TabIndex = 1;
            this.CaptionLabel.Text = "Запит";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(451, 68);
            this.ExecuteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(100, 28);
            this.ExecuteButton.TabIndex = 2;
            this.ExecuteButton.Text = "Виконати";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // FirstQueryViewList
            // 
            this.FirstQueryViewList.HideSelection = false;
            this.FirstQueryViewList.Location = new System.Drawing.Point(3, 149);
            this.FirstQueryViewList.Name = "FirstQueryViewList";
            this.FirstQueryViewList.Size = new System.Drawing.Size(121, 97);
            this.FirstQueryViewList.TabIndex = 3;
            this.FirstQueryViewList.UseCompatibleStateImageBehavior = false;
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 572);
            this.Controls.Add(this.FirstQueryViewList);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.CaptionLabel);
            this.Controls.Add(this.QueryTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Query";
            this.Text = "Query";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Table_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.ListView FirstQueryViewList;
    }
}