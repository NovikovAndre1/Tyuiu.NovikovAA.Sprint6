
using Tyuiu.NovikovAA.Sprint6.Task3.V27.Lib;


namespace Tyuiu.NovikovAA.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { {9,  13, -14,  23,   1},
                                      { 15, -17,  21,  25, 23 },
                                      {-4,  29, -20, -10,  14 },
                                      { 27,  33,  12,  33, -12 },
                                      {  18,  -9,  -5,   6,   3 } };


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            

            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = Convert.ToString(ds.Calculate(mtrx));
        }
    }
}
