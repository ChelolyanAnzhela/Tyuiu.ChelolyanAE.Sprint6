using Tyuiu.ChelolyanAE.Sprint6.Task6.V30.Lib;
namespace Tyuiu.ChelolyanAE.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_CAE_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResult_CAE.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_CAE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_CAE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CAE.ShowDialog();
            openFilePath = openFileDialogTask_CAE.FileName;
            textBoxStart_CAE.Text = File.ReadAllText(openFilePath);
            groupBoxOne_CAE.Text = groupBoxOne_CAE.Text + "" + openFileDialogTask_CAE.FileName;
            buttonDone_CAE.Enabled = true;
        }

        private void textBoxResult_CAE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
