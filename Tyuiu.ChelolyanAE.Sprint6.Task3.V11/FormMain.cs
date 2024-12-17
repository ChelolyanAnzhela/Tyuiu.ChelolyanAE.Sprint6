using Tyuiu.ChelolyanAE.Sprint6.Task3.V11.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = { {27,-15,14,2,37 },
                  {-8,14,-10,33,0 },
                  {1,7,-11,-11,23 },
                  {-13,-20,15,-16,34 },
                  {-3,1,-1,5,1 }};
        private void buttonHelp_CAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИИПБ-24-2 Челольян Анжела Евгеньевна");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewMatrix_CAE.ColumnCount = columns;
            dataGridViewMatrix_CAE.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_CAE.Columns[i].Width = 40;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_CAE.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_CAE_Click(object sender, EventArgs e)
        {
            int[,] newmtrx = ds.Calculate(matrix);
            int newrows = newmtrx.GetUpperBound(0) + 1;
            int newcolumns = newmtrx.Length / newrows;

            dataGridViewResult_CAE.ColumnCount = newcolumns;
            dataGridViewResult_CAE.RowCount = newrows;
            for (int i = 0; i < newcolumns; i++)
            {
                dataGridViewResult_CAE.Columns[i].Width = 50;
            }


            for (int i = 0; i < newcolumns; i++)
            {
                for (int j = 0; j < newrows; j++)
                {
                    dataGridViewResult_CAE.Rows[i].Cells[j].Value = Convert.ToString(newmtrx[i, j]);
                }
            }
        }

        private void textBoxResult_CAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMatrix_CAE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
