using Tyuiu.ChelolyanAE.Sprint6.Task0.V25.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task0.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNameOne_CAE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResultTwo_CAE.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_CAE.Text)));
            }
            catch
            {
                MessageBox.Show("�������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void textBoxResultTwo_CAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_CAE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonNameTwo_CAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ����-24-2 �������� ������ ����������");
        }

        private void groupBoxInput_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxConclusion_CAE_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxTask_CAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxNameThree_CAE_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxFormule_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNameX_CAE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
