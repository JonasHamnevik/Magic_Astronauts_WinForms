using Magic_Astronauts.Core;
using Magic_Astronauts.DataAccess;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Magic_Astronauts
{
    public partial class Form1 : Form
    {
        IList<Weather> weatherData = new List<Weather>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select File";
            fileDialog.FileName = txtFileName.Text;
            fileDialog.Filter = "CSV File (*.csv)|*.csv";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = fileDialog.FileName;
            }
        }

        private void Import_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                weatherData = File.ReadAllLines(txtFileName.Text)
                .Skip(1)
                .Distinct()
                .Select(x => Weather.csvConverter(x))
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, "You have to choose a .csv-file", MessageBoxButtons.OK);
            }
            //var bindingList = new BindingList<Weather>(weatherList);
            //var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = weatherData;
            txtFileName.Clear();
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            using (var context = new WeatherDbContext())
            {
                context.Weathers.AddRange(weatherData);
                context.SaveChanges();
            }
            MessageBox.Show(Text, "Saved Successful", MessageBoxButtons.OK);
        }
    }
}