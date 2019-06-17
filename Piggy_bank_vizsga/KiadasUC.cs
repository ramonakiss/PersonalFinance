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
namespace Piggy_bank_vizsga
{
    public partial class KiadasUC : UserControl
    {
        int bejelID;
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; AttachDbFileName=|DataDirectory|koltsegkovetes.mdf;");
        public KiadasUC(int id)
        {
            InitializeComponent();
            bejelID = id;
            AppDomain.CurrentDomain.SetData("DataDirectory",
            Path.GetFullPath(Path.Combine(Assembly.GetExecutingAssembly().Location,
            @"..\..\..\Resources")));

            DgvFeltoltes();

        }

        private void dgvKi_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
             {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.dgvTorles.Width;
                var h = Properties.Resources.dgvTorles.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.dgvTorles, new Rectangle(x, y, w, h));
                e.Handled = true;
             }

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.dgvSzerk.Width;
                var h = Properties.Resources.dgvSzerk.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.dgvSzerk, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvKi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            if (e.ColumnIndex == Torles.Index && dgvKi.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretnéd az adatokat?", "Törlés", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int index = dgvKi.CurrentCell.RowIndex; // hova kattintottunk


                    int rowID = int.Parse(dgvKi[0, index].Value.ToString());  // kiválasztott sor
                    dgvKi.Rows.RemoveAt(index); // törlöm a dgv-ből
                    try
                    {
                        conn.Open();
                        var cmdTorol = new SqlCommand("Delete from kiadas where ID = @sorid and regID = @ID", conn);
                        cmdTorol.Parameters.AddWithValue("@sorid", rowID);
                        cmdTorol.Parameters.AddWithValue("@ID", bejelID);
                        cmdTorol.ExecuteNonQuery();
                    }
                    finally
                    {
                        conn.Close();
                    }

                }

            }



            if (e.ColumnIndex == Szerkesztes.Index && dgvKi.Rows.Count > 0)
            {
                int indexsor = dgvKi.CurrentCell.RowIndex; // lekérdezem a sort
                int rowID = int.Parse(dgvKi[0, indexsor].Value.ToString()); // mi szerepel az Id-ban
                var modositas = new KiadasModositas(bejelID, rowID); // átadom az új formnak
                foreach (var item in cbKiKat.Items)
                {
                    modositas.cbKiModosit.Items.Add(item); // adja hozzá a cb-hez azokat az elemeket amik voltak 
                }


                var currentRow = dgvKi.CurrentRow; // aktuális sor
                var cbAktualis = currentRow.Cells[1].Value; // aktuális sor 1. oszlopának értéke

                var index = cbKiKat.Items.IndexOf(cbAktualis.ToString()); // cb lekérdezett aktuális eleme
                modositas.cbKiModosit.selectedIndex = index; // az új formon az legyen kijelölve
                modositas.dtpKiModosit.Value = Convert.ToDateTime(currentRow.Cells[2].Value.ToString()); //az új formban dtp-nél jelenjen meg az ami a kiválasztott sorban volt
                modositas.tbKiModosit.Text = currentRow.Cells[3].Value.ToString(); //ugyanez
                modositas.tbKiModosit2.Text = currentRow.Cells[4].Value.ToString(); // ugyanez

                modositas.ShowDialog();
                DgvFeltoltes();

            }
        }

        private void DgvFeltoltes()
        {
            try
            {
                conn.Open();
                var cmdFeltolt = new SqlCommand("SELECT ID, ki_kategoria, ki_datum, ki_osszeg, ki_megjegyzes from kiadas where regID = @ID order by ki_datum desc", conn);
                cmdFeltolt.Parameters.AddWithValue("@ID", bejelID);
                var readerFeltolt = cmdFeltolt.ExecuteReader();
                dgvKi.Rows.Clear();
                while (readerFeltolt.Read())
                {
                    dgvKi.Rows.Add(

                        readerFeltolt[0],
                        readerFeltolt[1],
                        readerFeltolt[2],
                        readerFeltolt[3],
                        readerFeltolt[4]);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnKeres_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                var cmdKeres = new SqlCommand("SELECT ID, ki_kategoria, ki_datum, ki_osszeg, ki_megjegyzes from kiadas where regID = @ID and ki_datum BETWEEN @kezdoDatum AND @vegsoDatum", conn);
                cmdKeres.Parameters.AddWithValue("@ID", bejelID);
                cmdKeres.Parameters.AddWithValue("@kezdoDatum", dtpKezdo.Value.ToString("yyyy-MM-dd"));
                cmdKeres.Parameters.AddWithValue("@vegsoDatum", dtpVegso.Value.ToString("yyyy-MM-dd"));
                var readerKeres = cmdKeres.ExecuteReader();
                dgvKi.Rows.Clear();
                while (readerKeres.Read())
                {

                    dgvKi.Rows.Add(

                        readerKeres[0],
                        readerKeres[1],
                        readerKeres[2],
                        readerKeres[3],
                        readerKeres[4]);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbKiKat_OnValueChanged(object sender, EventArgs e)
        {
         
            dgvKi.Rows.Clear();
            try
            {

                conn.Open();
                var cmdKatkeres = new SqlCommand($@"SELECT ID, ki_kategoria,ki_datum,  ki_osszeg, ki_megjegyzes FROM kiadas 
                 WHERE ki_kategoria LIKE '{tbKiKatKer.Text}%' and regID = @ID", conn);
                cmdKatkeres.Parameters.AddWithValue("@ID", bejelID);
                var readerKatKeres = cmdKatkeres.ExecuteReader();

                while (readerKatKeres.Read())
                {
                    dgvKi.Rows.Add(

                       readerKatKeres[0],
                       readerKatKeres[1],
                       readerKatKeres[2],
                       readerKatKeres[3],
                       readerKatKeres[4]);

                }
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void tbKiMegjegyzKer_OnValueChanged(object sender, EventArgs e)
        {

            dgvKi.Rows.Clear();
            try
            {
                conn.Open();
                var cmdMegjegyzkeres = new SqlCommand($@"SELECT ID, ki_kategoria,ki_datum,  ki_osszeg, ki_megjegyzes FROM kiadas 
                 WHERE ki_megjegyzes LIKE '{tbKiMegjegyzKer.Text}%' and regID = '{bejelID}'", conn);

                var readerMegyjegyzKeres = cmdMegjegyzkeres.ExecuteReader();

                while (readerMegyjegyzKeres.Read())
                {

                    dgvKi.Rows.Add(

                       readerMegyjegyzKeres[0],
                       readerMegyjegyzKeres[1],
                       readerMegyjegyzKeres[2],
                       readerMegyjegyzKeres[3],
                       readerMegyjegyzKeres[4]);
                }
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            bool szamE = true;
            bool karakterSzam = true;
            if (tbKiOsszeg.Text != "" && cbKiKat.selectedIndex != -1) // ha nem üres az összeg és a kategória
            {
                if (tbKiMegjegyz.Text.Length > 50)
                {
                    MessageBox.Show("Maximum 50 karaktert írhat a megjegyzéshez!");
                    karakterSzam = false;
                }

                if (tbKiOsszeg.Text != "")
                    foreach (var karakter in tbKiOsszeg.Text)

                    {
                        if (!char.IsDigit(karakter))
                            szamE = false;
                    }
                if (szamE == false)
                    MessageBox.Show("Csak számot írhat az összeg mezőbe(0-nál nagyobbat)!");


                else if (szamE != false && karakterSzam != false)
                {
                    int osszeg = int.Parse(tbKiOsszeg.Text);
                    try
                    {
                        conn.Open();

                        var cmdBeilleszt = "INSERT INTO kiadas(ki_kategoria, ki_osszeg, ki_datum, ki_megjegyzes, regID) VALUES" +
                             $"('{cbKiKat.selectedValue}', '{osszeg}', '{dtpKiDatum.Value.ToString("yyyy-MM-dd")}', '{tbKiMegjegyz.Text}', '{bejelID}');";
                        var adapter = new SqlDataAdapter();
                        adapter.InsertCommand = new SqlCommand(cmdBeilleszt, conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                        conn.Close();
                        tbKiOsszeg.Text = "";
                        tbKiMegjegyz.Text = "";
                        dtpKiDatum.ResetText();

                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }

            else MessageBox.Show("Kötelező kitölteni a kategória, illetve összeg mezőt!");
            DgvFeltoltes();
        }
    }
}
