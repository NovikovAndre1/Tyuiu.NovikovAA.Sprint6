
using Tyuiu.NovikovAA.Sprint6.Task7.V9.Lib;


namespace Tyuiu.NovikovAA.Sprint6.Task7.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Какие то значения цифорки буковки и так далее";
            saveFileDialog1.Filter = "И тут тоже должны быть какие то значения";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();
        string path = @"C:\Users\й\source\repos\Tyuiu.NovikovAA.Sprint6\Tyuiu.NovikovAA.Sprint6.Task7.V9\InPutDataFileTask7V9.csv";


        public static double[,] LoadFromDataFile(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(',').Length;

            double[,] arrayValues = new double[rows, columns];


            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToDouble(line_r[c]);
                }
            }
            return arrayValues;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;

            double[,] arrayValues = new double[rows, columns];

            arrayValues = LoadFromDataFile(openFilePath);

            dataGridViewInMatrix.ColumnCount = columns;
            dataGridViewInMatrix.RowCount = rows;
            dataGridViewOutMatrix.ColumnCount = columns;
            dataGridViewOutMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix.Columns[i].Width = 25;
                dataGridViewOutMatrix.Columns[i].Width = 25;
            }


            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromDataFile(openFilePath));
            buttonDone.Enabled = true;
        }

        private void dataGridViewInMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOutMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
