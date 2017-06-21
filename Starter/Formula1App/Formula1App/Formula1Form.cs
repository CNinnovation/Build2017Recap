using Formula1App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1App
{
    public partial class Formula1Form : Form
    {
        // TODO: add user-id
        private string ConnectionString = "Server=tcp:formula1.database.windows.net,1433;Initial Catalog=Formula1;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        Formula1Service service = new Formula1Service();
        public Formula1Form()
        {
            string[] countries = { "Austria", "Germany", "Switzerland" };
            InitializeComponent();
            comboBoxCountries.Items.AddRange(countries);
            service.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Racers";
            SqlDataReader reader = command.ExecuteReader();
           
            DataSet ds = new DataSet("Racers");

            ds.Load(reader, LoadOption.OverwriteChanges, "Racers");
            ds.WriteXml("racers.xml");
            reader.Close();
            connection.Close();
        }

        private void OnGetRacers(object sender, EventArgs e)
        {
            string selectedCountry = comboBoxCountries.SelectedItem?.ToString();
            if (selectedCountry == null)
            {
                MessageBox.Show("Select a country first");
                return;
            }
            IEnumerable<string> racers = service.GetRacersByCountry(selectedCountry);
            listBoxRacers.Items.Clear();
            listBoxRacers.Items.AddRange(racers.ToArray());

        }
    }
}
