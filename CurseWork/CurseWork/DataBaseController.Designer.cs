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
            this.SuspendLayout();
            // 
            // TabelsComboBox
            // 
            this.TabelsComboBox.FormattingEnabled = true;
            this.TabelsComboBox.Items.AddRange(new object[] {
            "Библиотека",
            "Журнал",
            "Читатели"});
            this.TabelsComboBox.Location = new System.Drawing.Point(9, 75);
            this.TabelsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabelsComboBox.Name = "TabelsComboBox";
            this.TabelsComboBox.Size = new System.Drawing.Size(110, 21);
            this.TabelsComboBox.TabIndex = 0;
            // 
            // QueryComboBox
            // 
            this.QueryComboBox.FormattingEnabled = true;
            this.QueryComboBox.Items.AddRange(new object[] {
            "Выборка",
            "Проекция",
            "Соединение с выборкой",
            "Соединение с проекцией",
            "Агрегирующие функции SELECT",
            "Агрегирующие функции HAVING",
            "Группировка с условием",
            "Группировка без условия",
            "Объединение",
            "Пересечение",
            "Разность",
            "Деление"});
            this.QueryComboBox.Location = new System.Drawing.Point(206, 75);
            this.QueryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QueryComboBox.Name = "QueryComboBox";
            this.QueryComboBox.Size = new System.Drawing.Size(110, 21);
            this.QueryComboBox.TabIndex = 1;
            // 
            // TabelsLabel
            // 
            this.TabelsLabel.AutoSize = true;
            this.TabelsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabelsLabel.Location = new System.Drawing.Point(9, 29);
            this.TabelsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TabelsLabel.Name = "TabelsLabel";
            this.TabelsLabel.Size = new System.Drawing.Size(101, 26);
            this.TabelsLabel.TabIndex = 2;
            this.TabelsLabel.Text = "Таблицы";
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryLabel.Location = new System.Drawing.Point(214, 29);
            this.QueryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(97, 26);
            this.QueryLabel.TabIndex = 3;
            this.QueryLabel.Text = "Запросы";
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(328, 115);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(111, 27);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.UseVisualStyleBackColor = true;
            // 
            // OpenQueryButton
            // 
            this.OpenQueryButton.Location = new System.Drawing.Point(328, 32);
            this.OpenQueryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenQueryButton.Name = "OpenQueryButton";
            this.OpenQueryButton.Size = new System.Drawing.Size(111, 27);
            this.OpenQueryButton.TabIndex = 5;
            this.OpenQueryButton.Text = "Открыть запрос";
            this.OpenQueryButton.UseVisualStyleBackColor = true;
            // 
            // OpenTableButton
            // 
            this.OpenTableButton.Location = new System.Drawing.Point(328, 75);
            this.OpenTableButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenTableButton.Name = "OpenTableButton";
            this.OpenTableButton.Size = new System.Drawing.Size(111, 27);
            this.OpenTableButton.TabIndex = 6;
            this.OpenTableButton.Text = "Открыть таблицу";
            this.OpenTableButton.UseVisualStyleBackColor = true;
            this.OpenTableButton.Click += new System.EventHandler(this.OpenTableButton_Click);
            // 
            // DataBaseController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 331);
            this.Controls.Add(this.OpenTableButton);
            this.Controls.Add(this.OpenQueryButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.TabelsLabel);
            this.Controls.Add(this.QueryComboBox);
            this.Controls.Add(this.TabelsComboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

