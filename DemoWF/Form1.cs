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
        public Form1()
        {
            InitializeComponent();
        }
        private void alignButtons(Size _size, int _left = 25)
        {
            int height = _size.Height, width = _size.Width;
            var location = buttonLeft.Location;
            location.Y = height - 75; // Кнопки находятся на одной высоте
            location.X = _left;
            buttonLeft.Location = location;
            location.X = _left + buttonLeft.Width;
            buttonRight.Location = location;
            location.X += buttonRight.Width;
            buttonOpen.Location = location;
            location.X += buttonOpen.Width;
            buttonSave.Location = location;
            location.X += buttonSave.Width;
            buttonSaveAs.Location = location;
            location.X += buttonSaveAs.Width;
            moveButtons.Location = location;
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
            moveButtons.Width = 50;
            moveButtons.Minimum = 10;
            moveButtons.Maximum = 300;
            moveButtons.Increment = 1;
            moveButtons.Show();
            return size;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            alignButtons(SetSize());
            

            MessageBox.Show($"Форма загрузилась, старт в {DateTime.Now.ToString("HH:mm:ss.fff")}") ;
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

        private void moveButtons_ValueChanged(object sender, EventArgs e)
        {
            int _left = (int)moveButtons.Value;
            Size size = this.Size;
            alignButtons(size, _left);
        }

        private void buttonLeft_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxContent.SelectedText += "ВЛЕВО";
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

        private void buttonRight_MouseClick(object sender, MouseEventArgs e)
        {
            var formFormatText = new Form();
            formFormatText.Text = "Форматирование текста";
            formFormatText.Controls.Add(comboBoxColor);
            Point location = comboBoxColor.Location;
            location.X = 5;
            location.Y = 5;
            comboBoxColor.Location = location;
            
            //comboBoxColor.Location.X = ;
            //comboBoxColor.Show();
            formFormatText.Show();
        }

        private void comboStile_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _sizeFont = richTextBoxContent.SelectionFont.Size;
            switch (comboStile.SelectedItem.ToString())
            {
                case "Microsoft Sans Serif":
                    richTextBoxContent.Font = new Font("Microsoft Sans Serif", _sizeFont);
                    break;
                case " Microsoft Yi Baiti":
                    richTextBoxContent.Font = new Font("Microsoft Yi Baiti", _sizeFont);
                    break;
                case "MingLiU_HKSCS-ExtB":
                    richTextBoxContent.Font = new Font("MingLiU_HKSCS-ExtB", _sizeFont);

                    break;
                default:
                    break;
            }
        }// Microsoft Yi Baiti

       // MingLiU_HKSCS-ExtB

        private void comboOutline_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _sizeFont = richTextBoxContent.SelectionFont.Size;
            switch (comboOutline.SelectedItem.ToString())
            {
                case "обычный":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.Font, FontStyle.Regular);
                    break;
                case "наклонный":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.Font, FontStyle.Italic);
                    break;
                case "полужирный":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.Font, FontStyle.Bold);
                    break;
                case "перечёркнутый":
                    richTextBoxContent.SelectionFont = new Font(richTextBoxContent.Font, FontStyle.Strikeout);
                    break;
                default:
                    break;
            }
        }
    }
}
