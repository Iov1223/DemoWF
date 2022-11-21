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
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCurrentDoc = new System.Windows.Forms.Label();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.moveButtons = new System.Windows.Forms.NumericUpDown();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboStile = new System.Windows.Forms.ComboBox();
            this.comboOutline = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.moveButtons)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Location = new System.Drawing.Point(15, 25);
            this.richTextBoxContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(960, 461);
            this.richTextBoxContent.TabIndex = 0;
            this.richTextBoxContent.Text = "";
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(15, 612);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(100, 28);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "Влево";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseClick);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(168, 612);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(100, 28);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = "Вправо";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRight_MouseClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(316, 612);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.buttonSaveAs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(145, 28);
            this.buttonSaveAs.TabIndex = 1;
            this.buttonSaveAs.Text = "Сохранить как...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // moveButtons
            // 
            this.moveButtons.Location = new System.Drawing.Point(788, 615);
            this.moveButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveButtons.Name = "moveButtons";
            this.moveButtons.Size = new System.Drawing.Size(160, 22);
            this.moveButtons.TabIndex = 3;
            this.moveButtons.ValueChanged += new System.EventHandler(this.moveButtons_ValueChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Красный",
            "Зеленый",
            "Синий",
            "Чёрный"});
            this.comboBoxColor.Location = new System.Drawing.Point(972, 25);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(105, 24);
            this.comboBoxColor.TabIndex = 4;
            this.comboBoxColor.Text = "Цвет";
            this.comboBoxColor.SelectedValueChanged += new System.EventHandler(this.comboBoxColor_SelectedValueChanged);
            // 
            // comboStile
            // 
            this.comboStile.FormattingEnabled = true;
            this.comboStile.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Microsoft Yi Baiti",
            "MingLiU_HKSCS-ExtB"});
            this.comboStile.Location = new System.Drawing.Point(972, 65);
            this.comboStile.Name = "comboStile";
            this.comboStile.Size = new System.Drawing.Size(105, 24);
            this.comboStile.TabIndex = 5;
            this.comboStile.Text = "Стиль";
            this.comboStile.SelectedIndexChanged += new System.EventHandler(this.comboStile_SelectedIndexChanged);
            // 
            // comboOutline
            // 
            this.comboOutline.FormattingEnabled = true;
            this.comboOutline.Items.AddRange(new object[] {
            "обычный",
            "наклонный",
            "полужирный",
            "перечёркнутый"});
            this.comboOutline.Location = new System.Drawing.Point(972, 114);
            this.comboOutline.Name = "comboOutline";
            this.comboOutline.Size = new System.Drawing.Size(105, 24);
            this.comboOutline.TabIndex = 6;
            this.comboOutline.Text = "Начертание";
            this.comboOutline.SelectedIndexChanged += new System.EventHandler(this.comboOutline_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 642);
            this.Controls.Add(this.comboOutline);
            this.Controls.Add(this.comboStile);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.moveButtons);
            this.Controls.Add(this.labelCurrentDoc);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.richTextBoxContent);
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Работа с текстом";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moveButtons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCurrentDoc;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.NumericUpDown moveButtons;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboStile;
        private System.Windows.Forms.ComboBox comboOutline;
    }
}

