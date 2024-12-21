
using Tyuiu.NovikovAA.Sprint6.Task4.V5.Lib;


namespace Tyuiu.NovikovAA.Sprint6.Task4.V5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 ds = new Class1();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);



                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chart1.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart1.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }

            }

            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxStartStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStopStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, chart1.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранён успешно!\n открыть его?");

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой программы и прочее прочее прочее");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
