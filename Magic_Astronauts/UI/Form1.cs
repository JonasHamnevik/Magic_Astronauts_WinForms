using Magic_Astronauts.Core;
using System.ComponentModel;
using System.Data;

namespace Magic_Astronauts
{
    public partial class Form1 : Form
    {
        List<Weather> weatherList = new List<Weather>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select File";
            fileDialog.FileName = txtFileName.Text;
            fileDialog.Filter = "Excel Sheet (*.xls)|*.xls|(*.xlsx)|*.xlsx|(*.csv)|*.csv";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = fileDialog.FileName;
            }
        }

        private void Import_Btn_Click(object sender, EventArgs e)
        {
            //List<Weather> weatherValues = File.ReadAllLines(txtFileName.Text)
            weatherList = File.ReadAllLines(txtFileName.Text)
            .Skip(1)
            .Select(x => Weather.csvConverter(x))
            .ToList();

            var bindingList = new BindingList<Weather>(weatherList);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            txtFileName.Clear();
        }
    }
}