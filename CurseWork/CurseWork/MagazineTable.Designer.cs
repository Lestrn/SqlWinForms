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
            this.MagazineGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MagazineGroupBox
            // 
            this.MagazineGroupBox.Controls.Add(this.StatusLabel);
            this.MagazineGroupBox.Controls.Add(this.StatusTextBox);
            this.MagazineGroupBox.Location = new System.Drawing.Point(12, 11);
            this.MagazineGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MagazineGroupBox.Name = "MagazineGroupBox";
            this.MagazineGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MagazineGroupBox.Size = new System.Drawing.Size(296, 428);
            this.MagazineGroupBox.TabIndex = 6;
            this.MagazineGroupBox.TabStop = false;
            this.MagazineGroupBox.Text = "Журнал";
            this.MagazineGroupBox.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(5, 39);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(59, 16);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Статус: ";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(100, 39);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(95, 22);
            this.StatusTextBox.TabIndex = 3;
            // 
            // MagazineTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MagazineGroupBox);
            this.Name = "MagazineTable";
            this.Text = "MagazineTable";
            this.MagazineGroupBox.ResumeLayout(false);
            this.MagazineGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MagazineGroupBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusTextBox;
    }
}