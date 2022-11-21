namespace CurseWork
{
    partial class PublishTable
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
            this.CodeComboBox = new System.Windows.Forms.ComboBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.PublishLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PublishTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PublishListView = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublishGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.PublishGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeComboBox
            // 
            this.CodeComboBox.FormattingEnabled = true;
            this.CodeComboBox.Location = new System.Drawing.Point(75, 26);
            this.CodeComboBox.Name = "CodeComboBox";
            this.CodeComboBox.Size = new System.Drawing.Size(121, 24);
            this.CodeComboBox.TabIndex = 0;
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(6, 34);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(31, 16);
            this.CodeLabel.TabIndex = 1;
            this.CodeLabel.Text = "Код";
            // 
            // PublishLabel
            // 
            this.PublishLabel.AutoSize = true;
            this.PublishLabel.Location = new System.Drawing.Point(6, 73);
            this.PublishLabel.Name = "PublishLabel";
            this.PublishLabel.Size = new System.Drawing.Size(95, 16);
            this.PublishLabel.TabIndex = 2;
            this.PublishLabel.Text = "Видавництво";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 112);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(47, 16);
            this.AddressLabel.TabIndex = 3;
            this.AddressLabel.Text = "Адрес";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(6, 157);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(67, 16);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "Телефон";
            // 
            // PublishTextBox
            // 
            this.PublishTextBox.Location = new System.Drawing.Point(113, 67);
            this.PublishTextBox.Name = "PublishTextBox";
            this.PublishTextBox.Size = new System.Drawing.Size(100, 22);
            this.PublishTextBox.TabIndex = 5;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(75, 109);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddressTextBox.TabIndex = 6;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(79, 154);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.PhoneTextBox.TabIndex = 7;
            // 
            // PublishListView
            // 
            this.PublishListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Publish,
            this.Address,
            this.Phone});
            this.PublishListView.HideSelection = false;
            this.PublishListView.Location = new System.Drawing.Point(368, 12);
            this.PublishListView.Name = "PublishListView";
            this.PublishListView.Size = new System.Drawing.Size(361, 218);
            this.PublishListView.TabIndex = 8;
            this.PublishListView.UseCompatibleStateImageBehavior = false;
            this.PublishListView.View = System.Windows.Forms.View.Details;
            this.PublishListView.SelectedIndexChanged += new System.EventHandler(this.TableListViewItem_Selected);
            // 
            // Code
            // 
            this.Code.Text = "Код";
            // 
            // Publish
            // 
            this.Publish.Text = "Видавництво";
            // 
            // Address
            // 
            this.Address.Text = "Адреса";
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            // 
            // PublishGroupBox
            // 
            this.PublishGroupBox.Controls.Add(this.CodeLabel);
            this.PublishGroupBox.Controls.Add(this.CodeComboBox);
            this.PublishGroupBox.Controls.Add(this.PhoneLabel);
            this.PublishGroupBox.Controls.Add(this.PhoneTextBox);
            this.PublishGroupBox.Controls.Add(this.PublishLabel);
            this.PublishGroupBox.Controls.Add(this.AddressTextBox);
            this.PublishGroupBox.Controls.Add(this.PublishTextBox);
            this.PublishGroupBox.Controls.Add(this.AddressLabel);
            this.PublishGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PublishGroupBox.Name = "PublishGroupBox";
            this.PublishGroupBox.Size = new System.Drawing.Size(350, 236);
            this.PublishGroupBox.TabIndex = 9;
            this.PublishGroupBox.TabStop = false;
            this.PublishGroupBox.Text = "Видавництво";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(368, 268);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(508, 268);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(654, 268);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(105, 23);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Змінити";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // PublishTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PublishGroupBox);
            this.Controls.Add(this.PublishListView);
            this.Name = "PublishTable";
            this.Text = "PublishTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Table_Closed);
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.PublishGroupBox.ResumeLayout(false);
            this.PublishGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CodeComboBox;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label PublishLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PublishTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.ListView PublishListView;
        private System.Windows.Forms.GroupBox PublishGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Publish;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Button EditButton;
    }
}