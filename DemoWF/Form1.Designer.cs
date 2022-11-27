namespace DemoWF
{
    partial class Form1
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
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCurrentDoc = new System.Windows.Forms.Label();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboStyle = new System.Windows.Forms.ComboBox();
            this.comboOutline = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.buttonTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Location = new System.Drawing.Point(15, 25);
            this.richTextBoxContent.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(933, 461);
            this.richTextBoxContent.TabIndex = 0;
            this.richTextBoxContent.Text = "";
            // 
            // buttonFormat
            // 
            this.buttonFormat.Location = new System.Drawing.Point(98, 612);
            this.buttonFormat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(145, 28);
            this.buttonFormat.TabIndex = 1;
            this.buttonFormat.Text = "Форматировать";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFormat_MouseClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(316, 612);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(100, 28);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(473, 612);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCurrentDoc
            // 
            this.labelCurrentDoc.AutoSize = true;
            this.labelCurrentDoc.Location = new System.Drawing.Point(41, 5);
            this.labelCurrentDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentDoc.Name = "labelCurrentDoc";
            this.labelCurrentDoc.Size = new System.Drawing.Size(71, 16);
            this.labelCurrentDoc.TabIndex = 2;
            this.labelCurrentDoc.Text = "Документ";
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(611, 612);
            this.buttonSaveAs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(145, 28);
            this.buttonSaveAs.TabIndex = 1;
            this.buttonSaveAs.Text = "Сохранить как...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Красный",
            "Зеленый",
            "Синий",
            "Чёрный"});
            this.comboBoxColor.Location = new System.Drawing.Point(942, 153);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(136, 24);
            this.comboBoxColor.TabIndex = 4;
            this.comboBoxColor.Text = "Цвет";
            this.comboBoxColor.SelectedValueChanged += new System.EventHandler(this.comboBoxColor_SelectedValueChanged);
            // 
            // comboStyle
            // 
            this.comboStyle.FormattingEnabled = true;
            this.comboStyle.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Comic Sans MS"});
            this.comboStyle.Location = new System.Drawing.Point(941, 25);
            this.comboStyle.Name = "comboStyle";
            this.comboStyle.Size = new System.Drawing.Size(137, 24);
            this.comboStyle.TabIndex = 5;
            this.comboStyle.Text = "Шрифт";
            this.comboStyle.SelectedIndexChanged += new System.EventHandler(this.comboStyle_SelectedIndexChanged);
            // 
            // comboOutline
            // 
            this.comboOutline.FormattingEnabled = true;
            this.comboOutline.Items.AddRange(new object[] {
            "обычный",
            "наклонный",
            "полужирный",
            "перечёркнутый"});
            this.comboOutline.Location = new System.Drawing.Point(941, 65);
            this.comboOutline.Name = "comboOutline";
            this.comboOutline.Size = new System.Drawing.Size(137, 24);
            this.comboOutline.TabIndex = 6;
            this.comboOutline.Text = "Начертание";
            this.comboOutline.SelectedIndexChanged += new System.EventHandler(this.comboOutline_SelectedIndexChanged);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxSize.Location = new System.Drawing.Point(942, 107);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(136, 24);
            this.comboBoxSize.TabIndex = 7;
            this.comboBoxSize.Text = "Размер";
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // buttonTime
            // 
            this.buttonTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTime.Location = new System.Drawing.Point(942, 204);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(136, 38);
            this.buttonTime.TabIndex = 8;
            this.buttonTime.Text = "Вставить время";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTime_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 642);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboOutline);
            this.Controls.Add(this.comboStyle);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelCurrentDoc);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonFormat);
            this.Controls.Add(this.richTextBoxContent);
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Работа с текстом";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCurrentDoc;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboStyle;
        private System.Windows.Forms.ComboBox comboOutline;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Button buttonTime;
    }
}

