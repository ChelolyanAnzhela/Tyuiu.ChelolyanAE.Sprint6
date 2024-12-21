using System.Net.Http.Headers;
using Tyuiu.ChelolyanAE.Sprint6.Task5.V18.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task5.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V18.txt";
        private void buttonDone_CAE_Click(object sender, EventArgs e)
        {
            dataGridViewResult_CAE.ColumnCount = 2;
            dataGridViewResult_CAE.Columns[0].Width = 20;
            dataGridViewResult_CAE.Columns[1].Width = 50;
            this.chartFunction_CAE.ChartAreas[0].AxisX.Title = " Ось X";
            this.chartFunction_CAE.ChartAreas[0].AxisY.Title = " Ось Y";
            chartFunction_CAE.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_CAE.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_CAE.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_CAE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_CAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИИПБ-24-2 Челольян Анжела Евгеньевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunction_CAE_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewResult_CAE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
