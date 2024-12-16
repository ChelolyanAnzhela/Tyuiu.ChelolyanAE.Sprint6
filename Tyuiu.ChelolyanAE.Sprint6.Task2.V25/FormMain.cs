using Tyuiu.ChelolyanAE.Sprint6.Task2.V25.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_CAE_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_CAE.BackColor = Color.Red;
        }

        private void FormMain_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_CAE.BackColor = Color.Green;
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_CAE.BackColor = Color.Blue;
        }

        private void buttonDone_CAE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_CAE.Text);
                int stopStep = Convert.ToInt32(textBoxStop_CAE.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_CAE.Titles.Add("График функции");
                this.chartFunction_CAE.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_CAE.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_CAE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_CAE.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введенны неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИИПБ-24-2 Челольян Анжела Евгеньевна");
        }

        private void textBoxStop_CAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_CAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewFunction_CAE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartFunction_CAE_Click(object sender, EventArgs e)
        {

        }
    }
}
