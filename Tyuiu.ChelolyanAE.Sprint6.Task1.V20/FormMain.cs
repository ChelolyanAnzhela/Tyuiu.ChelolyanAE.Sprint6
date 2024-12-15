using Tyuiu.ChelolyanAE.Sprint6.Task1.V20.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task1.V20
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
                int startStep = Convert.ToInt32(textBoxStart_CAE.Text);
                int stopStep = Convert.ToInt32(textBoxStop_CAE.Text);
                string strline;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_CAE.Text = "";
                textBoxResult_CAE.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_CAE.AppendText("|     X    |    f(x)  |" + Environment.NewLine);
                textBoxResult_CAE.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_CAE.AppendText(strline + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_CAE.AppendText("+----------+----------+" + Environment.NewLine);

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

        private void textBoxResult_CAE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
