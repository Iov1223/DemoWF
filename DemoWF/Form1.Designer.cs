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
            this.buttonUndo = new System.Windows.Forms.Button();
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
            this.buttonFormat.Location = new System.Drawing.Point(56, 601);
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
            this.buttonOpen.Location = new System.Drawing.Point(225, 601);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(145, 28);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(399, 601);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 28);
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
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(788, 582);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(145, 28);
            this.buttonUndo.TabIndex = 9;
            this.buttonUndo.Text = "Отменить";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonUndo_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 642);
            this.Controls.Add(this.buttonUndo);
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
        private System.Windows.Forms.Button buttonUndo;
    }
}

