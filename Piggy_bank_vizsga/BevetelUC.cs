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


namespace Piggy_bank_vizsga
{
    public partial class BevetelUC : UserControl
    {
        int bejelID;
         SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; AttachDbFileName=|DataDirectory|koltsegkovetes.mdf;");

        public BevetelUC(int id)
        {
            InitializeComponent();

            bejelID = id; 
            AppDomain.CurrentDomain.SetData("DataDirectory",
                Path.GetFullPath(Path.Combine(Assembly.GetExecutingAssembly().Location,
                @"..\..\..\Resources")));

            DgvFeltoltes();

        }
       


        private void dgvBevetel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         
            if (e.ColumnIndex == Torles.Index &&  dgvBevetel.Rows.Count > 0 )
            { 
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretné az adatokat?",
                    "Törlés", MessageBoxButtons.YesNo);
                
                if (dialogResult == DialogResult.Yes)
                {
                    int index = dgvBevetel.CurrentCell.RowIndex; 


                    int rowID = int.Parse(dgvBevetel[0, index].Value.ToString()); 
                    dgvBevetel.Rows.RemoveAt(index); 
                   
                    conn.Open();
                    var cmdTorol = new SqlCommand("Delete from bevetel where ID = @sorid and regID = @ID", conn);
                    cmdTorol.Parameters.AddWithValue("@sorid", rowID);
                    cmdTorol.Parameters.AddWithValue("@ID", bejelID);
                    cmdTorol.ExecuteNonQuery();
                    conn.Close();
                    
                }
                
            }
           


            if (e.ColumnIndex == Szerkesztes.Index && dgvBevetel.Rows.Count > 0 )
            {
                int indexsor = dgvBevetel.CurrentCell.RowIndex; 
                int rowID = int.Parse(dgvBevetel[0, indexsor].Value.ToString()); 
                var modositas = new BevetelModositas(bejelID,rowID); 
                foreach (var item in cbBeKat.Items)
                {
                    modositas.cbBeModosit.Items.Add(item); 
                }
                var currentRow = dgvBevetel.CurrentRow; 
                var cbAktualis = currentRow.Cells[1].Value; 
                var index = cbBeKat.Items.IndexOf(cbAktualis.ToString()); 
                modositas.cbBeModosit.selectedIndex = index; 
                modositas.dtpBeModosit.Value = Convert.ToDateTime(currentRow.Cells[2].Value.ToString()); 
                modositas.tbBeModosit.Text = currentRow.Cells[3].Value.ToString(); 
                modositas.tbBeModosit2.Text = currentRow.Cells[4].Value.ToString(); 
                modositas.ShowDialog();
                DgvFeltoltes();
            }
        }
        

        private void btnKeres_Click(object sender, EventArgs e)
        {
            // lekérdezés a kiválasztott dátumok alapján
            try
            {
                conn.Open();
                var cmdKeres = new SqlCommand("SELECT ID, be_kategoria, be_datum, be_osszeg, be_megjegyzes from bevetel" +
                    " where regID = @ID and be_datum BETWEEN @kezdoDatum AND @vegsoDatum", conn);
                cmdKeres.Parameters.AddWithValue("@ID", bejelID);
                cmdKeres.Parameters.AddWithValue("@kezdoDatum", dtpKezdo.Value.ToString("yyyy-MM-dd"));
                cmdKeres.Parameters.AddWithValue("@vegsoDatum", dtpVegso.Value.ToString("yyyy-MM-dd"));
                var readerKeres = cmdKeres.ExecuteReader();
                dgvBevetel.Rows.Clear();
                while (readerKeres.Read())
                {

                    dgvBevetel.Rows.Add(

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

        private void dgvBevetel_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // a 0. sorba ne rajzoljon
             if (e.RowIndex < 0)
                    return;
             // az 5. oszlopba
            if( e.ColumnIndex == 5)

                 
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All); // minden sorba
                // hova rajzoljon
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

        private void DgvFeltoltes()
        {
            try
            {

                conn.Open();
                var cmdFeltolt = new SqlCommand("SELECT ID, be_kategoria, be_datum, be_osszeg, be_megjegyzes from bevetel" +
                    " where regID =  @ID order by be_datum desc", conn);
                cmdFeltolt.Parameters.AddWithValue("@ID", bejelID);
                var readerFeltolt = cmdFeltolt.ExecuteReader();
                dgvBevetel.Rows.Clear();
                while (readerFeltolt.Read())
                {

                    dgvBevetel.Rows.Add(

                        readerFeltolt[0],
                        readerFeltolt[1],
                        readerFeltolt[2],
                        readerFeltolt[3],
                        readerFeltolt[4]
                                        );
                }
            }
            finally
            {
                conn.Close();
            }
           


        }

        private void tbBeKatKeres_OnValueChanged(object sender, EventArgs e)
        {
            dgvBevetel.Rows.Clear();
            try
            {


                conn.Open();
                var cmdKatkeres = new SqlCommand($@"SELECT ID, be_kategoria,be_datum,  be_osszeg, be_megjegyzes FROM bevetel 
                 WHERE be_kategoria LIKE '{tbBeKatKeres.Text}%' and regID = @ID", conn);
                cmdKatkeres.Parameters.AddWithValue("@ID", bejelID);
                var readerKatKeres = cmdKatkeres.ExecuteReader();

                while (readerKatKeres.Read())
                {

                    dgvBevetel.Rows.Add(

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

        private void tbBeMegjegyzKer_OnValueChanged(object sender, EventArgs e)
        {
            dgvBevetel.Rows.Clear();
            try
            {
                conn.Open();
                var cmdMegjegyzkeres = new SqlCommand($@"SELECT ID, be_kategoria,be_datum,  be_osszeg, be_megjegyzes FROM bevetel 
                 WHERE be_megjegyzes LIKE '{tbBeMegjegyzKer.Text}%' and regID = @ID", conn);
                cmdMegjegyzkeres.Parameters.AddWithValue("@ID", bejelID);

                var readerMegjegyzKeres = cmdMegjegyzkeres.ExecuteReader();

                while (readerMegjegyzKeres.Read())
                {

                    dgvBevetel.Rows.Add(

                       readerMegjegyzKeres[0],
                       readerMegjegyzKeres[1],
                       readerMegjegyzKeres[2],
                       readerMegjegyzKeres[3],
                       readerMegjegyzKeres[4]);

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
            if (tbBeOsszeg.Text != "" && cbBeKat.selectedIndex != -1)
            {
                if (tbBeMegjegyz.Text.Length > 50)
                {

                    MessageBox.Show("Maximum 50 karaktert írhat megjegyzéshez!");
                    karakterSzam = false;
                }
                if (tbBeOsszeg.Text != "")
                    foreach (var karakter in tbBeOsszeg.Text)

                    {
                        if (!char.IsDigit(karakter))
                            szamE = false;
                    }
                if (szamE == false)
                    MessageBox.Show("Csak számot írhat az összeg mezőbe!(0-nál nagyobbat)");


                else if (szamE != false && karakterSzam != false)
                {
                    int osszeg = int.Parse(tbBeOsszeg.Text);
                    try
                    {



                        conn.Open();

                        var cmdBeilleszt = "INSERT INTO bevetel(be_kategoria, be_osszeg, be_datum, be_megjegyzes, regID) VALUES" +
                             $"('{cbBeKat.selectedValue}', '{osszeg}', '{dtpBeDatum.Value.ToString("yyyy-MM-dd")}'," +
                             $" '{tbBeMegjegyz.Text}', '{bejelID}');";
                        var adapter = new SqlDataAdapter();
                        adapter.InsertCommand = new SqlCommand(cmdBeilleszt, conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                        conn.Close();
                        tbBeOsszeg.Text = "";
                        tbBeMegjegyz.Text = "";
                        dtpBeDatum.ResetText();
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






