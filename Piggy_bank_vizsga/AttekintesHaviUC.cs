using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Piggy_bank_vizsga
{
    public partial class AttekintesHaviUC : UserControl
    {
        int bejelID;
        int honap;
        int ev;
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; AttachDbFileName=|DataDirectory|koltsegkovetes.mdf;");
        public AttekintesHaviUC(int id)
        {
            InitializeComponent();
            bejelID = id;
            honap= int.Parse(DateTime.Now.Month.ToString());
            ev = int.Parse(DateTime.Now.Year.ToString());
            AppDomain.CurrentDomain.SetData("DataDirectory",
            Path.GetFullPath(Path.Combine(Assembly.GetExecutingAssembly().Location,
                @"..\..\..\Resources")));

            Kalkulacio();
            Diagram();

        }
        private void Diagram()
        {
           
            DataSet ds = new DataSet();
            try
            {

                conn.Open();
                SqlDataAdapter haviKatAdapt = new SqlDataAdapter($"SELECT ki_kategoria, sum (ki_osszeg) as osszeg from kiadas WHERE YEAR(ki_datum) = @ev " +
                 " AND MONTH(ki_datum) = @honap and regID = @bejelID group by ki_kategoria", conn);

                haviKatAdapt.SelectCommand.Parameters.AddWithValue("@ev", ev);
                haviKatAdapt.SelectCommand.Parameters.AddWithValue("@honap", honap);
                haviKatAdapt.SelectCommand.Parameters.AddWithValue("@bejelID", bejelID);
                haviKatAdapt.Fill(ds);
                katKoltes.DataSource = ds;

                katKoltes.Series["Összesen"].XValueMember = "ki_kategoria";
                katKoltes.Series["Összesen"].YValueMembers = "osszeg";

                katKoltes.Series["Összesen"].IsValueShownAsLabel = true;
                bool vanE = katKoltes.Series["Összesen"].Points.Count > 0;
                katKoltes.Series["Összesen"].IsVisibleInLegend = vanE;
            }
            finally
            {
                conn.Close();
            }
          
                katKoltes.ChartAreas[0].BackColor = Color.Black;
                katKoltes.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
                katKoltes.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
                katKoltes.ChartAreas[0].AxisX.LineColor = Color.White;
                katKoltes.ChartAreas[0].AxisY.LineColor = Color.White;
                katKoltes.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                katKoltes.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                katKoltes.BackColor = Color.Transparent;
                katKoltes.Legends[0].BackColor = Color.Transparent;
                katKoltes.Legends[0].ForeColor = Color.White;
                katKoltes.Series[0].LabelForeColor = Color.White;
                katKoltes.ApplyPaletteColors();
                katKoltes.Series[0].Color = Color.Teal;
                katKoltes.Series[0].LabelForeColor = Color.White;
                katKoltes.ChartAreas[0].BackColor = Color.Black;
            



            DataSet ds2 = new DataSet();
            int ossz;
            try
            {
                conn.Open();
                var cmdFelhasznLekerd = new SqlCommand($"SELECT ISNULL(SUM(ki_osszeg), 0) from kiadas WHERE YEAR(ki_datum) = @ev " +
                    " AND MONTH(ki_datum) = @honap and regID = @bejelID", conn);
                cmdFelhasznLekerd.Parameters.AddWithValue("@ev", ev);
                cmdFelhasznLekerd.Parameters.AddWithValue("@honap", honap);
                cmdFelhasznLekerd.Parameters.AddWithValue("@bejelID", bejelID);
                ossz = (int)cmdFelhasznLekerd.ExecuteScalar();
                SqlDataAdapter szazalekAdapt = new SqlDataAdapter($"SELECT ki_kategoria," +
                $"CAST((SUM(ki_osszeg) / (@osszes * 1.00)) * 100.00 AS DECIMAL(18, 2)) " +
                $"AS szazalek FROM kiadas WHERE YEAR(ki_datum) = @ev " +
                " AND MONTH(ki_datum) = @honap and regID = @bejelID GROUP BY ki_kategoria", conn);
                szazalekAdapt.SelectCommand.Parameters.AddWithValue("@ev", ev);
                szazalekAdapt.SelectCommand.Parameters.AddWithValue("@honap", honap);
                szazalekAdapt.SelectCommand.Parameters.AddWithValue("@bejelID", bejelID);
                szazalekAdapt.SelectCommand.Parameters.AddWithValue("@osszes", ossz);
                szazalekAdapt.Fill(ds2);
                szazalekosKoltes.DataSource = ds2;
                szazalekosKoltes.Series["Szazalek"].XValueMember = "ki_kategoria";
                szazalekosKoltes.Series["Szazalek"].IsValueShownAsLabel = true;
                szazalekosKoltes.Series["Szazalek"].YValueMembers = "szazalek";

                szazalekosKoltes.Series["Szazalek"].LabelFormat = "{0.#}%";
            }
            finally
            {
                conn.Close();
            }

            szazalekosKoltes.ChartAreas[0].BackColor = Color.Transparent;
            szazalekosKoltes.Legends[0].BackColor = Color.Transparent;
            szazalekosKoltes.Legends[0].ForeColor = Color.White;
                     
        }

        private void Kalkulacio ()
        {
            int aktualisOsszeg;
            try
            {
                conn.Open();

                var aktualisOsszegCmd = new SqlCommand("Select (select ISNULL(SUM(be_osszeg), 0) from bevetel WHERE YEAR(be_datum) = @ev" +
                    " AND MONTH(be_datum) = @honap and regID = @bejelID) - (select ISNULL(SUM(ki_osszeg), 0) from kiadas WHERE YEAR(ki_datum) = @ev" +
                    " AND MONTH(ki_datum) = @honap and regID = @bejelID)", conn);

                aktualisOsszegCmd.Parameters.AddWithValue("@ev", ev);
                aktualisOsszegCmd.Parameters.AddWithValue("@honap", honap);
                aktualisOsszegCmd.Parameters.AddWithValue("@bejelID", bejelID);

                var reader = aktualisOsszegCmd.ExecuteReader();
                while (reader.Read())
                {

                    aktualisOsszeg = (int)reader[0];
                    lblAktualis.Text = aktualisOsszeg.ToString() + " Ft";

                }
            }
            finally
            {
                conn.Close();
            }


            int aktualisBevetel;

            try
            {
                conn.Open();
                var aktualusKiadCmd = new SqlCommand("select ISNULL(SUM(be_osszeg), 0) from bevetel WHERE YEAR(be_datum) = @ev" +
                    " AND MONTH(be_datum) = @honap and regID = @bejelID", conn);

                aktualusKiadCmd.Parameters.AddWithValue("@ev", ev);
                aktualusKiadCmd.Parameters.AddWithValue("@honap", honap);
                aktualusKiadCmd.Parameters.AddWithValue("@bejelID", bejelID);

                var reader2 = aktualusKiadCmd.ExecuteReader();
                while (reader2.Read())
                {

                    aktualisBevetel = (int)reader2[0];
                    lblBevetel.Text = aktualisBevetel.ToString() + " Ft";

                }
            }
            finally
            {
                conn.Close();
            }
            try
            {
                conn.Open();

                int aktualisKiadas;

                var aktualisKiadasCmd = new SqlCommand("select ISNULL(SUM(ki_osszeg), 0) from kiadas WHERE YEAR(ki_datum) = @ev" +
                    " AND MONTH(ki_datum) = @honap and regID = @bejelID", conn);

                aktualisKiadasCmd.Parameters.AddWithValue("@ev", ev);
                aktualisKiadasCmd.Parameters.AddWithValue("@honap", honap);
                aktualisKiadasCmd.Parameters.AddWithValue("@bejelID", bejelID);

                var reader3 = aktualisKiadasCmd.ExecuteReader();
                while (reader3.Read())
                {
                    aktualisKiadas = (int)reader3[0];
                    lblKiadas.Text = aktualisKiadas.ToString() + " Ft";

                }
            }
            finally
            {
                conn.Close();
            }

        }

        private void katKoltes_Paint(object sender, PaintEventArgs e)
        {
           
            if (katKoltes.Series["Összesen"].Points.Count == 0)
            {
                Font font = new Font("Consolas", 20f);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;

                e.Graphics.DrawString("Nincs adat...",font, Brushes.White, katKoltes.ClientRectangle, format);
        }   }

        private void szazalekosKoltes_Paint(object sender, PaintEventArgs e)
        {
            if (szazalekosKoltes.Series["Szazalek"].Points.Count == 0)
            {
                Font font = new Font("Consolas", 20f);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;

                e.Graphics.DrawString("Nincs adat...", font, Brushes.White, katKoltes.ClientRectangle, format);
            }
        }
    
    }


}   