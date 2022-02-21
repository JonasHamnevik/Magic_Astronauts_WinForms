using Magic_Astronauts.Core;
using Magic_Astronauts.DataAccess;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Magic_Astronauts
{
    //Man får byta lite namn här och var då jag använt Jonas kod och har då lite andra namn men samma innehåll
    public partial class Form1 : Form
    {
        private static WeatherContext _context = new WeatherContext();
        IList<Weather> weatherData = new List<Weather>();
        public Form1()
        {
            _context.Database.EnsureCreated(); //Skapar dbn när programmet startar
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
        weatherData = File.ReadAllLines(txtFileName.Text)
            .Skip(1)
            .Distinct()
            .Select(x => WeatherData.csvConverter(x))
            .ToList();
        dataGridView1.DataSource = weatherData;
        txtFileName.Clear();
        }

        private void Import_Btn_Click(object sender, EventArgs e)//Denna behövs inte
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
         private void insertToDbButton_Click(object sender, EventArgs e)
        {
         using (var _context = new WeatherContext())
        {
            _context.Weathers.AddRange(weatherData);
            _context.SaveChanges()
        }
        MessageBox.Show(Text, "Saved Successful", MessageBoxButtons.OK);
       }
        private void save_Btn_Click(object sender, EventArgs e)//Denna är likadan som ovan
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
