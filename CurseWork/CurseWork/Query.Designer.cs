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
            this.QueryListView = new System.Windows.Forms.ListView();
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
            this.CaptionLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionLabel.Location = new System.Drawing.Point(12, 18);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(60, 24);
            this.CaptionLabel.TabIndex = 1;
            this.CaptionLabel.Text = "Запит";
            // 
            // QueryListView
            // 
            this.QueryListView.HideSelection = false;
            this.QueryListView.Location = new System.Drawing.Point(3, 149);
            this.QueryListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryListView.Name = "QueryListView";
            this.QueryListView.Size = new System.Drawing.Size(423, 347);
            this.QueryListView.TabIndex = 3;
            this.QueryListView.UseCompatibleStateImageBehavior = false;
            this.QueryListView.View = System.Windows.Forms.View.Details;
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 572);
            this.Controls.Add(this.QueryListView);
            this.Controls.Add(this.CaptionLabel);
            this.Controls.Add(this.QueryTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Query";
            this.Text = "Query";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Table_Closed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.ListView QueryListView;
    }
}