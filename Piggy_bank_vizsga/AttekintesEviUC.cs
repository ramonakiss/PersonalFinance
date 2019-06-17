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
    public partial class AttekintesEviUC : UserControl
    {
        int bejelID;
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; AttachDbFileName=|DataDirectory|koltsegkovetes.mdf;");
        int ev;
        public AttekintesEviUC(int id)
        {
            InitializeComponent();
            bejelID = id;
            ev = int.Parse(DateTime.Now.Year.ToString());
            Diagram();
        }
        public void Diagram()
        {
           
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter haviTeljesKiAdapt = new SqlDataAdapter("SELECT  month(ki_datum) as honap, SUM(ki_osszeg) as osszes" +
                 " FROM kiadas WHERE YEAR(ki_datum) = @ev and regID = @bejelID" +
                 "  group by year(ki_datum), month(ki_datum) ", conn);

                haviTeljesKiAdapt.SelectCommand.Parameters.AddWithValue("@ev", ev);


                haviTeljesKiAdapt.SelectCommand.Parameters.AddWithValue("@bejelID", bejelID);
                haviTeljesKiAdapt.Fill(ds);
                evesBontasKi.DataSource = ds;
                evesBontasKi.Series["Havi teljes költés"].XValueMember = "honap";
                evesBontasKi.Series["Havi teljes költés"].IsValueShownAsLabel = true;
                evesBontasKi.Series["Havi teljes költés"].YValueMembers = "osszes";
                bool vanEKi = evesBontasKi.Series["Havi teljes költés"].Points.Count > 0;
                evesBontasKi.Series["Havi teljes költés"].IsVisibleInLegend = vanEKi;
            }
            finally
            {
                conn.Close();
            }
                evesBontasKi.Series["Havi teljes költés"]["PixelPointWidth"] = "40";
                evesBontasKi.ChartAreas[0].BackColor = Color.Black;
                evesBontasKi.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
                evesBontasKi.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
                evesBontasKi.ChartAreas[0].AxisX.LineColor = Color.White;
                evesBontasKi.ChartAreas[0].AxisY.LineColor = Color.White;
                evesBontasKi.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                evesBontasKi.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                evesBontasKi.BackColor = Color.Transparent;
                evesBontasKi.Legends[0].BackColor = Color.Transparent;
                evesBontasKi.Legends[0].ForeColor = Color.White;
                evesBontasKi.ApplyPaletteColors();
                evesBontasKi.Series[0].Color = Color.Teal;
                evesBontasKi.Series[0].LabelForeColor = Color.White;


            DataSet ds2 = new DataSet();

            try
            {
                conn.Open();
                SqlDataAdapter haviTeljesBeAdapt = new SqlDataAdapter("SELECT  month(be_datum) as honap, SUM(be_osszeg) as osszes" +
                 " FROM bevetel WHERE YEAR(be_datum) = @ev and regID = @bejelID" +
                 "  group by year(be_datum), month(be_datum) ", conn);

                haviTeljesBeAdapt.SelectCommand.Parameters.AddWithValue("@ev", ev);


                haviTeljesBeAdapt.SelectCommand.Parameters.AddWithValue("@bejelID", bejelID);
                haviTeljesBeAdapt.Fill(ds2);
                evesBontasBe.DataSource = ds2;
                evesBontasBe.Series["Havi teljes bevétel"].XValueMember = "honap";
                evesBontasBe.Series["Havi teljes bevétel"].IsValueShownAsLabel = true;
                evesBontasBe.Series["Havi teljes bevétel"].YValueMembers = "osszes";
                bool vanEBe = evesBontasBe.Series["Havi teljes bevétel"].Points.Count > 0;
                evesBontasBe.Series["Havi teljes bevétel"].IsVisibleInLegend = vanEBe;
            }
            finally
            {
                conn.Close();
            }
            evesBontasBe.Series["Havi teljes bevétel"]["PixelPointWidth"] = "40";
            evesBontasBe.ChartAreas[0].BackColor = Color.Black;
            evesBontasBe.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            evesBontasBe.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            evesBontasBe.ChartAreas[0].AxisX.LineColor = Color.White;
            evesBontasBe.ChartAreas[0].AxisY.LineColor = Color.White;
            evesBontasBe.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            evesBontasBe.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            evesBontasBe.BackColor = Color.Transparent;
            evesBontasBe.Legends[0].BackColor = Color.Transparent;
            evesBontasBe.Legends[0].ForeColor = Color.White;
            evesBontasBe.ApplyPaletteColors();
            evesBontasBe.Series[0].Color = Color.Teal;
            evesBontasBe.Series[0].LabelForeColor = Color.White;

        }

        private void evesBontas_Paint(object sender, PaintEventArgs e)
        {

            if (evesBontasKi.Series["Havi teljes költés"].Points.Count == 0)
            {
                Font font = new Font("Consolas", 20f);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;

                e.Graphics.DrawString("Nincs adat...", font, Brushes.White, evesBontasKi.ClientRectangle, format);
            }
        }

        private void evesBontasBe_Paint(object sender, PaintEventArgs e)
        {

            if (evesBontasBe.Series["Havi teljes bevétel"].Points.Count == 0)
            {
                Font font = new Font("Consolas", 20f);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;

                e.Graphics.DrawString("Nincs adat...", font, Brushes.White, evesBontasBe.ClientRectangle, format);
            }
        }
    }
}
