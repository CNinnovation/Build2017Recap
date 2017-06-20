using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1App.Data
{
    public class Formula1Service
    {
        private DataSet formula1DataSet = new DataSet();
        public void Load()
        {
            formula1DataSet.ReadXml("./racers.xml");
        }

        public IEnumerable<string> GetRacersByCountry(string country)
        {
            DataTable racers = formula1DataSet.Tables["Racers"];
            //var query = from racer in racers.AsEnumerable()
            //            where racer.Field<string>("Nationality") == country
            //            select racer.Field<string>("FirstName") + " " + racer.Field<string>("LastName");

            var query = racers.Rows.Cast<DataRow>().Where(row => row["Nationality"].ToString() == country)
                .Select(row => row["FirstName"] + " " + row["LastName"]);
            return query.ToList();                
        }
    }
}
