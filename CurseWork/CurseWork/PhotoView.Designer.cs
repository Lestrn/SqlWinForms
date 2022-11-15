namespace CurseWork
{
    partial class PhotoView
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
            this.SelectedPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedPicture
            // 
            this.SelectedPicture.Location = new System.Drawing.Point(12, 2);
            this.SelectedPicture.Name = "SelectedPicture";
            this.SelectedPicture.Size = new System.Drawing.Size(770, 425);
            this.SelectedPicture.TabIndex = 0;
            this.SelectedPicture.TabStop = false;
            // 
            // PhotoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 439);
            this.Controls.Add(this.SelectedPicture);
            this.Name = "PhotoView";
            this.Text = "PhotoView";
            this.Load += new System.EventHandler(this.PhotoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SelectedPicture;
    }
}