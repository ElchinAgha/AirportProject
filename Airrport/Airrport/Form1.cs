using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Airrport
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
        public Form1()
        {
            
            InitializeComponent();
            CmbFill();
            fillDgv();
        }
        private void fillDgv()
        {
            DgvAirport.Rows.Clear();
            con.Open();
            string query = "SELECT Flights.Id,Airlines.Airline,Cities.City,Gates.Gate,Runways.Runway,Flights.[Type],Flights.TargetDate FROM Flights INNER JOIN  Airlines ON Flights.AirlineId = Airlines.Id INNER JOIN  Cities ON Flights.CityId = Cities.Id INNER JOIN  Gates ON Flights.GateId = Gates.Id INNER JOIN Runways On Flights.RunwayId = Runways.Id";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string FlightType = "Enis";
                if (reader.GetInt32(5) == 1)
                {
                    FlightType = "Qalxis";
                }
                DgvAirport.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), FlightType, reader.GetDateTime(6));
            }

            con.Close();
        }
        private void CmbFill()
        {
            CmbAirline.ResetText();
            CmbCity.ResetText();
            CmbGate.ResetText();
            CmbRunway.ResetText();
            CmbType.ResetText();

            con.Open();
            string query = "SELECT Airline FROM Airlines";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CmbAirline.Items.Add(reader.GetString(0));
            }
            con.Close();
            con.Open();
            string query1 = "SELECT City FROM Cities";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                CmbCity.Items.Add(reader1.GetString(0));
            }
            con.Close();

            con.Open();
            string query2 = "SELECT Gate FROM Gates";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                CmbGate.Items.Add(reader2.GetString(0));
            }
            con.Close();
            con.Open();
            string query3 = "SELECT Runway FROM Runways";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                CmbRunway.Items.Add(reader3.GetString(0));
            }
            con.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
        }
    }
}
