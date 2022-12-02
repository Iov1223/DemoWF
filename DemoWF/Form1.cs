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
            buttonUndo.Location = location;
            location.X += buttonUndo.Width;
        }
        private Size SetSize()
        {
            var MSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            var height = MSize.Height / 2;
            var width = (MSize.Width / 3) * 2;
            Size size = new Size(width, height);
            richTextBoxContent.Size = size;
            size.Height += 100;
            size.Width += 38;
            this.MaximumSize = this.MinimumSize = size;
            return size;
        }
        private Control[] CreateElements()
        {
            Control[] elements = new Control[5];
            ComboBox comboBoxStyle = new ComboBox();
            /*В шрифте нет switch и событие срабатывает, меняется шрифт на выбранный по умолчанию
             сделал так для демонстрации*/
            comboBoxStyle.Text = "Шрифт";
            comboBoxStyle.Items.Add("Arial");
            comboBoxStyle.Items.Add("Times New Roman");
            comboBoxStyle.Items.Add("Comic Sans MS");
            comboBoxStyle.SelectedIndexChanged += comboStyle_SelectedIndexChanged;
            elements[0] = comboBoxStyle;

            ComboBox comboBoxOutline = new ComboBox();
            /*В остальных ComboBox switch присутствует и событие не срабатывает,
             требует ссылку на объект*/
            comboBoxOutline.Text = "Начертание";
            comboBoxOutline.Items.Add("обычный");
            comboBoxOutline.Items.Add("наклонный");
            comboBoxOutline.Items.Add("полужирный");
            comboBoxOutline.Items.Add("перечёркнутый");
            comboBoxOutline.SelectedIndexChanged += comboOutline_SelectedIndexChanged;
            elements[1] = comboBoxOutline;

            ComboBox comboBoxSise = new ComboBox();
            comboBoxSise.Text = "Размер";
            comboBoxSise.Items.Add("8");
            comboBoxSise.Items.Add("9");
            comboBoxSise.Items.Add("10");
            comboBoxSise.Items.Add("11");
            comboBoxSise.Items.Add("12");
            comboBoxSise.SelectedIndexChanged += comboBoxSize_SelectedIndexChanged;
            elements[2] = comboBoxSise;

            ComboBox comboBoxColor = new ComboBox();
            comboBoxColor.Text = "Цвет";
            comboBoxColor.Items.Add("Красный");
            comboBoxColor.Items.Add("Зелёный");
            comboBoxColor.Items.Add("Синий");
            comboBoxColor.Items.Add("Чёрный");
            comboBoxColor.SelectedValueChanged += comboBoxColor_SelectedValueChanged;
            elements[3] = comboBoxColor;
            /*C кнопкой тоже всё предельно просто, всё работает*/
            Button buttonTime = new Button();
            buttonTime.Text = "Вставить время";
            buttonTime.Size = new Size(122, 22);
            buttonTime.MouseClick += buttonTime_MouseClick;
            elements[4] = buttonTime;

            return elements;
        }

        private void AddElement()
        {
            Form formFormatText = new Form();
            Control[] elements = CreateElements();
            formFormatText.Text = "Окно форматирования";

            Point locationS = elements[0].Location;
            formFormatText.Controls.Add(elements[0]);
            locationS.X = 5;
            locationS.Y = 5;
            elements[0].Location = locationS;

            Point locationO = elements[1].Location;
            formFormatText.Controls.Add(elements[1]);
            locationO.X = 5;
            locationO.Y = 50;
            elements[1].Location = locationO;

            Point locationB = elements[2].Location;
            formFormatText.Controls.Add(elements[2]);
            locationB.X = 5;
            locationB.Y = 95;
            elements[2].Location = locationB;

            Point locationC = elements[3].Location;
            formFormatText.Controls.Add(elements[3]);
            locationC.X = 5;
            locationC.Y = 140;
            elements[3].Location = locationC;

            Point locationT = elements[4].Location;
            formFormatText.Controls.Add(elements[4]);
            locationT.X = 5;
            locationT.Y = 185;
            elements[4].Location = locationT;

            Size min, max;  
            SetSizeForm(out min, out max);
            formFormatText.MaximumSize = min;
            formFormatText.MinimumSize = max;
            formFormatText.Show();
        }
        private void SetSizeForm(out Size min, out Size max)
        {
            var MSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            Form formFormatText = new Form();
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
        }

        private void comboBoxColor_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxColor.SelectedItem.ToString())
            {
                case "Красный":
                    richTextBoxContent.SelectionColor = Color.Red;
                    break;
                case "Зелёный":
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
        {var _sizeFont = richTextBoxContent.SelectionFont.Size;
          
            richTextBoxContent.SelectionFont = new Font("Comic Sans MS", _sizeFont);
            //
            //switch (comboStyle.SelectedItem.ToString();)
            //{
            //    case "Arial":
            //        richTextBoxContent.SelectionFont = new Font("Arial", _sizeFont);
            //        break;
            //    case "Times New Roman":
            //        richTextBoxContent.SelectionFont = new Font("Times New Roman", _sizeFont);
            //        break;
            //    case "Comic Sans MS":
            //        richTextBoxContent.SelectionFont = new Font("Comic Sans MS", _sizeFont);
            //        break;
            //    default:
            //        break;
            //}
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

        private void buttonUndo_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxContent.Undo();
        }
    }
}
