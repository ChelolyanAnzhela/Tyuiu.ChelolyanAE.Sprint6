using Tyuiu.ChelolyanAE.Sprint6.Task4.V13.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task4.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_CAE_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_CAE.Text);
                int stop = Convert.ToInt32(textBoxStop_CAE.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);
                this.chartFunction_CAE.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_CAE.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_CAE.Text = "";
                chartFunction_CAE.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_CAE.Series[0].Points.AddXY(start, valueArray[i]);
                    textBoxResult_CAE.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введенны неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_CAE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V13.txt");
                File.WriteAllText(path, textBoxResult_CAE.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "Сохранен успешно!\n Открыть его в блокноте?", "Сохрание файла", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxTwo_CAE_TextChanged(object sender, EventArgs e)
        {
        }
        private void splitterOne_CAE_SplitterMoved(object sender, EventArgs e)
        { }

        private void buttonHelp_CAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИИПБ-24-2 Челольян Анжела Евгеньевна");
        }

        private void chartFunction_CAE_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_CAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_CAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStop_CAE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
