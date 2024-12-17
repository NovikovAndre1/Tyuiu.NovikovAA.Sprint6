using System.Windows.Forms;
using Tyuiu.NovikovAA.Sprint6.Task0.V9.Lib;


namespace Tyuiu.NovikovAA.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox2.Text); // Изменено: используем textBox2

                if (x == 0)
                {
                    label4.Text = "Ошибка: Деление на ноль!";
                    return;
                }

                double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);

                label4.Text = $"Результат: {y:F2}";
            }
            catch (FormatException)
            {
                label4.Text = "Ошибка: Неверный формат ввода! Введите число.";
            }
            catch (Exception ex)
            {
                label4.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
