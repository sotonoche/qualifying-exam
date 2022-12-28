using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1Task1X.Visible = false;
            labelTask1Y.Visible = false;

            textBoxTask1X.Visible = false;
            textBoxTask1Y.Visible = false;

            buttonTask1GetRes.Visible = false;

            labelTask2X.Visible = false;
            labelTask2Y.Visible = false;

            textBoxTask2X.Visible = false;
            textBoxTask2Y.Visible = false;

            buttonTask2GetRes.Visible = false;
        }
        //открытие html страницы
        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //создаем объет класса OpenFileDialog
            OpenFileDialog ofd = new OpenFileDialog();
            //задаем фильтр только на расширение файлов html 
            ofd.Filter = "HTML Document (*.html)|*.html";
            //если окно с выбором файла зыкрыто прекращаем работу программы
            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            //узнаем имя выбранного файла
            string filePath = ofd.FileName;
            string fileName = ofd.SafeFileName;

            webBrowser1.Navigate(filePath);

            if (fileName == "1stPage.html")
            {
                label1Task1X.Visible = true;
                labelTask1Y.Visible = true;

                textBoxTask1X.Visible = true;
                textBoxTask1Y.Visible = true;

                buttonTask1GetRes.Visible = true;

                labelTask2X.Visible = false;
                labelTask2Y.Visible = false;

                textBoxTask2X.Visible = false;
                textBoxTask2Y.Visible = false;

                buttonTask2GetRes.Visible = false;
            }
            else if (fileName == "2ndPage.html")
            {
                label1Task1X.Visible = false;
                labelTask1Y.Visible = false;

                textBoxTask1X.Visible = false;
                textBoxTask1Y.Visible = false;

                buttonTask1GetRes.Visible = false;

                labelTask2X.Visible = true;
                labelTask2Y.Visible = true;

                textBoxTask2X.Visible = true;
                textBoxTask2Y.Visible = true;

                buttonTask2GetRes.Visible = true;
            }

        }
        //сообщение об авторе
        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подготовил: ст.гр ПКсп-120 Кирсанов К.А.\nВариант: 20", "О программе");
        }
        //выход из программы
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ограничение на ввод букв в текстбокс
        private void textBoxTask1X_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void textBoxTask1Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTask1X.Text == "" || textBoxTask1Y.Text == "")
            {
                MessageBox.Show("Введите значение в поле", "Ошибка!");
                return;
            }

            double x = double.Parse(textBoxTask1X.Text);
            double y = double.Parse(textBoxTask1Y.Text);


            if (x < 0 && y > 0) MessageBox.Show("Точка находится вне области", "Результат");
            else if ((x * x + y * y) < 64.00 || (x * x + y * y) > 256.00)
            {
                MessageBox.Show("Точка находится вне области", "Результат");
                toolStripStatusLabel1.Text = "Точка находится вне области";
            }
            else if ((x * x + y * y) == 64.00 || (x * x + y * y) == 256.00)
            {
                MessageBox.Show("Точка находится на границе области", "Результат");
                toolStripStatusLabel1.Text = "Точка находится на границе области";
            }
            else if ((x * x + y * y) > 64.00 && (x * x + y * y) < 256.00) {
                MessageBox.Show("Точка находится в области", "Результат");
                toolStripStatusLabel1.Text = "Точка находится в области";
            }
            
        }

        private void buttonTask2GetRes_Click(object sender, EventArgs e)
        {
            if (textBoxTask2X.Text == "" || textBoxTask2Y.Text == "")
            {
                MessageBox.Show("Введите значение в поле", "Ошибка!");
                return;
            }

            double x = double.Parse(textBoxTask2X.Text);
            double y = double.Parse(textBoxTask2Y.Text);

            int leftDownCornX = -6;
            int leftDownCornY = 1;

            int leftUpCornX = -3;
            int leftUpCornY = 7;

            int rightDownCornX = 7;
            int rightDownCornY = 1;

            int rightUpCornX = 4;
            int rightUpCornY = 7;

            int d = (rightDownCornX - leftDownCornX) * (leftUpCornY - leftDownCornY) - (leftUpCornX - leftDownCornX) * (rightDownCornY - leftDownCornY);

            if ((0 <= ((leftUpCornY - leftDownCornY) * (x - leftDownCornX) - (leftUpCornX - leftDownCornX) * (y - leftDownCornY))) && (d >= ((leftUpCornY - leftDownCornY) * (x - leftDownCornX) - (leftUpCornX - leftDownCornX) * (y - leftDownCornY))) && (0 <= ((rightDownCornX - leftDownCornX) * (y - leftDownCornY) - (rightDownCornY - leftDownCornY) * (x - leftDownCornX)) && d >= ((rightDownCornX - leftDownCornX) * (y - leftDownCornY) - (rightDownCornY - leftDownCornY) * (x - leftDownCornX)))) {
                MessageBox.Show("Точка находится в области");
                toolStripStatusLabel1.Text = "Точка находится в области";
            }
            else
            {
                MessageBox.Show("Точка находится вне области");
                toolStripStatusLabel1.Text = "Точка находится вне области";
            }
            
        }
    }
}
