using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoWF
{
    public partial class Form1 : Form
    {
        private Form formFormatText = new Form();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void alignButtons(Size _size, int _left = 0)
        {
            int height = _size.Height, width = _size.Width;
            var location = buttonOpen.Location;
            location.Y = height - 75;
            location.X = 10;
            buttonFormat.Location = location;
            location.X += buttonFormat.Width;
            buttonOpen.Location = location;
            location.X += buttonOpen.Width;
            buttonSave.Location = location;
            location.X += buttonSave.Width;
            buttonSaveAs.Location = location;
            location.X += buttonSaveAs.Width;
        }
        private Size SetSize()
        {
            var MSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            var height = MSize.Height / 2;
            var width = (MSize.Width / 3) * 2;
            Size size = new Size(width, height);
            richTextBoxContent.Size = size;
            size.Height += 100; 
            size.Width += 100; 
            this.MaximumSize = this.MinimumSize = size;
            return size;
        }
        private void AddElement()
        {
            formFormatText.Text = "Окно форматирования";

            Point locationS = comboStyle.Location;
            formFormatText.Controls.Add(comboStyle);
            locationS.X = 5;
            locationS.Y = 5;
            comboStyle.Location = locationS;

            Point locationO = comboOutline.Location;
            formFormatText.Controls.Add(comboOutline);
            locationO.X = 5;
            locationO.Y = 50;
            comboOutline.Location = locationO;

            Point locationB = comboBoxSize.Location;
            formFormatText.Controls.Add(comboBoxSize);
            locationB.X = 5;
            locationB.Y = 95;
            comboBoxSize.Location = locationB;

            Point locationC = comboBoxColor.Location;
            formFormatText.Controls.Add(comboBoxColor);
            locationC.X = 5;
            locationC.Y = 140;
            comboBoxColor.Location = locationC;

            Point locationT = buttonTime.Location;
            formFormatText.Controls.Add(buttonTime);
            locationT.X = 5;
            locationT.Y = 185;
            buttonTime.Location = locationT;

            Size min, max;  
            SetSizeForm(out min, out max);
            formFormatText.MaximumSize = min;
            formFormatText.MinimumSize = max;
            
        }
        private void SetSizeForm(out Size min, out Size max)
        {
            var MSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            var formFormatText = new Form();
            formFormatText.MaximumSize = new Size(MSize.Width / 6, MSize.Height / 3);
            formFormatText.MinimumSize = new Size(MSize.Width / 6, MSize.Height / 3);
            min = formFormatText.MinimumSize;
            max = formFormatText.MaximumSize;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            alignButtons(SetSize());
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                string CurrentDoc = FileIO.Browse();
                richTextBoxContent.LoadFile(CurrentDoc);
                labelCurrentDoc.Text = CurrentDoc;
                var doc = new FileIO(CurrentDoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxContent.SaveFile(labelCurrentDoc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                string CurrentDoc = FileIO.SaveAs();
                richTextBoxContent.SaveFile(CurrentDoc);
                labelCurrentDoc.Text = CurrentDoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonFormat_MouseClick(object sender, MouseEventArgs e)
        {
            AddElement();
            formFormatText.Show();
        }

        private void comboBoxColor_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxColor.SelectedItem.ToString())
            {
                case "Красный":
                    richTextBoxContent.SelectionColor = Color.Red;
                    break;
                case "Зеленый":
                    richTextBoxContent.SelectionColor = Color.Green;
                    break;
                case "Синий":
                    richTextBoxContent.SelectionColor = Color.Blue;
                    break;
                case "Чёрный":
                    richTextBoxContent.SelectionColor = Color.Black;
                    break;
                default:
                    break;
            }
        }
        private void comboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _sizeFont = richTextBoxContent.SelectionFont.Size;
            switch (comboStyle.SelectedItem.ToString())
            {
                case "Arial":
                    richTextBoxContent.SelectionFont = new Font("Arial", _sizeFont);
                    break;
                case "Times New Roman":
                    richTextBoxContent.SelectionFont = new Font("Times New Roman", _sizeFont);
                    break;
                case "Comic Sans MS":
                    richTextBoxContent.SelectionFont = new Font("Comic Sans MS", _sizeFont);
                    break;
                default:
                    break;
            }
        }

        private void comboOutline_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboOutline.SelectedItem.ToString())
            {
                case "обычный":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.SelectionFont, FontStyle.Regular);
                    break;
                case "наклонный":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.SelectionFont, FontStyle.Italic);
                    break;
                case "полужирный":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.SelectionFont, FontStyle.Bold);
                    break;
                case "перечёркнутый":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.SelectionFont, FontStyle.Strikeout);
                    break;
                default:
                    break;
            }
        }
        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _styleFont = richTextBoxContent.SelectionFont.FontFamily;
            switch (comboBoxSize.SelectedItem.ToString())
            {
                case "8":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 8);
                    break;
                case "9":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 9);
                    break;
                case "10":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 10);
                    break;
                case "11":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 11);
                    break;
                case "12":
                    richTextBoxContent.SelectionFont = new Font(_styleFont, 12);
                    break;
                default:
                    break;
            }
        }

        private void buttonTime_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime dt = DateTime.Now;
            string time = dt.ToString("dd.MM.yyyy HH:mm:ss");
            richTextBoxContent.SelectedText = time;
        }
      
    }
}
