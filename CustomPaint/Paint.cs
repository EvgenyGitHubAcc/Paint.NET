using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomPaint
{
    public partial class Paint : Form
    {
        Step obj = new Line();
        Buffer buf = new Buffer();
        bool flag_mouseclick = false;
        bool flag_eraser = false;

        public Paint()
        {
            InitializeComponent();
            
            fontDialog1.ShowColor = true;
            pictureBox1_Color1.BackColor = buf.DrawColor;
            pictureBox2_Color2.BackColor = buf.FillColor;
            DoubleBuffered = true;
            button2_Line.Checked = true;

            Enter_text_Form.Hide();

            //Выпадающие подсказки
            ToolTip t = new ToolTip();
            t.SetToolTip(label1_Color1, "Выбор цвета пера");
            t.SetToolTip(label2_Color2, "Выбор цвета заливки");
            t.SetToolTip(button1_Text, "Выбор элемента текст"); 
            t.SetToolTip(button2_Line, "Выбор элемента Линия");
            t.SetToolTip(button3_Pryamougolnik, "Выбор элемента прямоугольник");
            t.SetToolTip(button4_Oval, "Выбор элемента Овал");
            t.SetToolTip(Fill_Button, "Выбор элемента Заливка");
            t.SetToolTip(Eraser_button, "Выбор элемента Стирка");
            t.SetToolTip(Size_Line, "Толщина линии");
        }
        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Выбор параметров текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                buf.Font = fontDialog1.Font;
                buf.DrawColor = fontDialog1.Color;
                pictureBox1_Color1.BackColor = buf.DrawColor;
            }

        }
        /// <summary>
        /// Элемент текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Text_Click(object sender, EventArgs e)
        {
            Enter_text_Form.Show();
            Enter_text_Form.Focus();
        }
        /// <summary>
        /// Создание экземпляров объектов в буфере
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paint_panel_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (Eraser_button.Checked == false)
                flag_eraser = false;
                Enter_text_Form.Hide();               

            if (Eraser_button.Checked == true)
            {
                obj = new Lastic();
                flag_eraser = true;
                Enter_text_Form.Hide();
            }
            else if (button1_Text.Checked == true)
            {
                if (Enter_text_Form.Text.Count() != 0)
                {
                    obj = new Text(Enter_text_Form.Text);
                    ((Text)obj).Font = buf.Font;
                    Enter_text_Form.Text = null;
                    Enter_text_Form.Show();
                    Enter_text_Form.Focus();
                }
                else
                {
                    obj = null;
                    return;
                }
            }
            else if (button2_Line.Checked == true)
            {
                obj = new Line();
                Enter_text_Form.Text = null;
                Enter_text_Form.Hide();
            }
            else if (button3_Pryamougolnik.Checked == true)
            {
                obj = new RectangleB();
                Enter_text_Form.Text = null;
                Enter_text_Form.Hide();
            }
            else if (button4_Oval.Checked == true)
            {
                obj = new Ellips();
                Enter_text_Form.Text = null;
                Enter_text_Form.Hide();
            }

            flag_mouseclick = true;
            obj.Colorelem = buf.DrawColor;
            obj.Widthelem = buf.LineWidth;
            obj.Start1 = e.Location;
            if (Fill_Button.Checked == true)
            {
                obj.backgroundcolorelem = buf.FillColor;
               // obj.Colorelem = buf.FillColor;
                Enter_text_Form.Text = null;
                Enter_text_Form.Hide();
            }
        }

        private void Paint_panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (obj != null)
            {
                obj.Finish1 = e.Location;
                buf.Add(obj);
            }                        
            obj = new Line();
            flag_mouseclick = false;
            Paint_panel.Invalidate();
        }
        /// <summary>
        /// Отрисовка в окне
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paint_panel_Paint(object sender, PaintEventArgs e)
        {
            var x = buf.Done.ToList();
            for (int i = buf.Done.Count - 1; i >= 0; --i)
            {
                x[i].draw(e.Graphics);
            }
            if (obj != null)
            {
                obj.draw(e.Graphics);
            }
        }
        /// <summary>
        /// Выбор цвета пера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Color1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox1_Color1.BackColor = colorDialog1.Color;
            buf.DrawColor = colorDialog1.Color;

        }
        /// <summary>
        /// Выбор цвета заливки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Color2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox2_Color2.BackColor = colorDialog1.Color;
            buf.FillColor = colorDialog1.Color;
        }

        private void Paint_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag_mouseclick && !flag_eraser)
            {
                if (obj != null)
                {
                    obj.Finish1 = e.Location;
                    Paint_panel.Refresh();
                }
                
            }
            else if (flag_mouseclick && flag_eraser)
            {
                if (obj != null)
                {
                    obj.path.Add(e.Location);
                    Paint_panel.Refresh();
                }
            }
        }
        /// <summary>
        /// Выбор толщины линии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            buf.LineWidth = Convert.ToInt32(comboBox1.SelectedItem.ToString());
        }
        /// <summary>
        /// Выбор цвета пера в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox1_Color1.BackColor = colorDialog1.Color;
            buf.DrawColor = colorDialog1.Color;
        }
        /// <summary>
        /// Выбор цвета заливки в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox2_Color2.BackColor = colorDialog1.Color;
            buf.FillColor = colorDialog1.Color;
        }
        /// <summary>
        /// Откатить изменение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buf.unDrawStep();
            Paint_panel.Refresh();
        }
        /// <summary>
        /// Вернуть изменение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buf.drawStep();
            Paint_panel.Invalidate();
        }
        /// <summary>
        /// Открыть файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buf.Open();
            Paint_panel.Invalidate();
        }
        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buf.Save();
        }
        /// <summary>
        /// Сохранить как
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buf.SaveAs();
            saveToolStripMenuItem.Enabled = true;
        }
        /// <summary>
        /// функция экспорта картинки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buf.ExportImage(Paint_panel);
        }
        /// <summary>
        /// Предпросмотр печати
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enter_text_Form.Text = null;
            Enter_text_Form.Hide();
            printPreviewDialog1.ShowDialog();
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
        /// <summary>
        /// Вывод на печать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Enter_text_Form.Text = null;
            Enter_text_Form.Hide();
            Bitmap img = new Bitmap(Paint_panel.Width, Paint_panel.Height);
            Paint_panel.DrawToBitmap(img, new Rectangle(0, 0, Paint_panel.Width, Paint_panel.Height));
            Graphics g = e.Graphics;
            g.DrawImage(img, 0, 0);
        }

        private void button2_Line_Click(object sender, EventArgs e)
        {
            Enter_text_Form.Hide();
        }

        private void button3_Pryamougolnik_Click(object sender, EventArgs e)
        {
            Enter_text_Form.Hide();
        }

        private void button4_Oval_Click(object sender, EventArgs e)
        {
            Enter_text_Form.Hide();
        }

        private void Eraser_button_Click(object sender, EventArgs e)
        {
            Enter_text_Form.Hide();
        }
    }
}
