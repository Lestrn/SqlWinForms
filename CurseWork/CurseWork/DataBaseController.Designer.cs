namespace CurseWork
{
    partial class DataBaseController
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabelsComboBox = new System.Windows.Forms.ComboBox();
            this.QueryComboBox = new System.Windows.Forms.ComboBox();
            this.TabelsLabel = new System.Windows.Forms.Label();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.ReportButton = new System.Windows.Forms.Button();
            this.OpenQueryButton = new System.Windows.Forms.Button();
            this.OpenTableButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPassBtn = new System.Windows.Forms.Button();
            this.AttemptsLeftLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TabelsComboBox
            // 
            this.TabelsComboBox.Enabled = false;
            this.TabelsComboBox.FormattingEnabled = true;
            this.TabelsComboBox.Items.AddRange(new object[] {
            "Бібліотека",
            "Журнал",
            "Читачі",
            "Видавництво",
            "Автор",
            "Жанри"});
            this.TabelsComboBox.Location = new System.Drawing.Point(12, 92);
            this.TabelsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabelsComboBox.Name = "TabelsComboBox";
            this.TabelsComboBox.Size = new System.Drawing.Size(145, 24);
            this.TabelsComboBox.TabIndex = 0;
            // 
            // QueryComboBox
            // 
            this.QueryComboBox.Enabled = false;
            this.QueryComboBox.FormattingEnabled = true;
            this.QueryComboBox.Items.AddRange(new object[] {
            "Вибірка",
            "Проекція",
            "З\'єднання з вибіркою",
            "З\'єднання з проекцією",
            "Агрегуючі функції SELECT",
            "Агрегуючі функції HAVING",
            "Угруповання з умовою",
            "Угруповання без умови",
            "Об\'єднання",
            "Перетин",
            "Різниця",
            "Поділ"});
            this.QueryComboBox.Location = new System.Drawing.Point(275, 92);
            this.QueryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryComboBox.Name = "QueryComboBox";
            this.QueryComboBox.Size = new System.Drawing.Size(145, 24);
            this.QueryComboBox.TabIndex = 1;
            // 
            // TabelsLabel
            // 
            this.TabelsLabel.AutoSize = true;
            this.TabelsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabelsLabel.Location = new System.Drawing.Point(12, 36);
            this.TabelsLabel.Name = "TabelsLabel";
            this.TabelsLabel.Size = new System.Drawing.Size(109, 31);
            this.TabelsLabel.TabIndex = 2;
            this.TabelsLabel.Text = "Таблиці";
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryLabel.Location = new System.Drawing.Point(285, 36);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(97, 31);
            this.QueryLabel.TabIndex = 3;
            this.QueryLabel.Text = "Запити";
            // 
            // ReportButton
            // 
            this.ReportButton.Enabled = false;
            this.ReportButton.Location = new System.Drawing.Point(437, 142);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(148, 33);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.Text = "Звіт";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // OpenQueryButton
            // 
            this.OpenQueryButton.Enabled = false;
            this.OpenQueryButton.Location = new System.Drawing.Point(437, 39);
            this.OpenQueryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenQueryButton.Name = "OpenQueryButton";
            this.OpenQueryButton.Size = new System.Drawing.Size(148, 33);
            this.OpenQueryButton.TabIndex = 5;
            this.OpenQueryButton.Text = "Відкрити запити";
            this.OpenQueryButton.UseVisualStyleBackColor = true;
            this.OpenQueryButton.Click += new System.EventHandler(this.OpenQueryButton_Click);
            // 
            // OpenTableButton
            // 
            this.OpenTableButton.Enabled = false;
            this.OpenTableButton.Location = new System.Drawing.Point(437, 92);
            this.OpenTableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenTableButton.Name = "OpenTableButton";
            this.OpenTableButton.Size = new System.Drawing.Size(148, 33);
            this.OpenTableButton.TabIndex = 6;
            this.OpenTableButton.Text = "Відкрити таблицю";
            this.OpenTableButton.UseVisualStyleBackColor = true;
            this.OpenTableButton.Click += new System.EventHandler(this.OpenTableButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(157, 278);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(40, 278);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 23);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password";
            // 
            // ConfirmPassBtn
            // 
            this.ConfirmPassBtn.Location = new System.Drawing.Point(291, 270);
            this.ConfirmPassBtn.Name = "ConfirmPassBtn";
            this.ConfirmPassBtn.Size = new System.Drawing.Size(100, 31);
            this.ConfirmPassBtn.TabIndex = 9;
            this.ConfirmPassBtn.Text = "Confirm";
            this.ConfirmPassBtn.UseVisualStyleBackColor = true;
            this.ConfirmPassBtn.Click += new System.EventHandler(this.ConfirmPassBtn_Click);
            // 
            // AttemptsLeftLabel
            // 
            this.AttemptsLeftLabel.AutoSize = true;
            this.AttemptsLeftLabel.Location = new System.Drawing.Point(397, 277);
            this.AttemptsLeftLabel.Name = "AttemptsLeftLabel";
            this.AttemptsLeftLabel.Size = new System.Drawing.Size(184, 16);
            this.AttemptsLeftLabel.TabIndex = 10;
            this.AttemptsLeftLabel.Text = "У вас залишилось 3 спроби";
            // 
            // DataBaseController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 407);
            this.Controls.Add(this.AttemptsLeftLabel);
            this.Controls.Add(this.ConfirmPassBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.OpenTableButton);
            this.Controls.Add(this.OpenQueryButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.TabelsLabel);
            this.Controls.Add(this.QueryComboBox);
            this.Controls.Add(this.TabelsComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "DataBaseController";
            this.Text = "DataBaseController";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TabelsComboBox;
        private System.Windows.Forms.ComboBox QueryComboBox;
        private System.Windows.Forms.Label TabelsLabel;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button OpenQueryButton;
        private System.Windows.Forms.Button OpenTableButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button ConfirmPassBtn;
        private System.Windows.Forms.Label AttemptsLeftLabel;
    }
}

