namespace CurseWork
{
    partial class ReadersTable
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
            this.ReaderGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReaderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReaderGroupBox
            // 
            this.ReaderGroupBox.Controls.Add(this.textBox1);
            this.ReaderGroupBox.Controls.Add(this.label3);
            this.ReaderGroupBox.Controls.Add(this.label2);
            this.ReaderGroupBox.Controls.Add(this.label1);
            this.ReaderGroupBox.Controls.Add(this.FIOLabel);
            this.ReaderGroupBox.Controls.Add(this.FIOTextBox);
            this.ReaderGroupBox.Location = new System.Drawing.Point(12, 11);
            this.ReaderGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReaderGroupBox.Name = "ReaderGroupBox";
            this.ReaderGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReaderGroupBox.Size = new System.Drawing.Size(456, 407);
            this.ReaderGroupBox.TabIndex = 5;
            this.ReaderGroupBox.TabStop = false;
            this.ReaderGroupBox.Text = "Читатель";
            this.ReaderGroupBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ФИО: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ФИО: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО: ";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(6, 68);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(44, 16);
            this.FIOLabel.TabIndex = 2;
            this.FIOLabel.Text = "ФИО: ";
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(142, 62);
            this.FIOTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(95, 22);
            this.FIOTextBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 22);
            this.textBox1.TabIndex = 6;
            // 
            // ReadersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReaderGroupBox);
            this.Name = "ReadersTable";
            this.Text = "ReadersTable";
            this.ReaderGroupBox.ResumeLayout(false);
            this.ReaderGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ReaderGroupBox;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}