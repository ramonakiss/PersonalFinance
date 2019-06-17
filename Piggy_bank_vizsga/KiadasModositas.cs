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
    public partial class KiadasModositas : Form
    {
        int bejelID;
        int rowID;
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; AttachDbFileName=|DataDirectory|koltsegkovetes.mdf;");
        public KiadasModositas(int id, int rowid)
        {
            InitializeComponent();
            bejelID = id;
            rowID = rowid;
        }

        private void btnModosit_Click_1(object sender, EventArgs e)
        {
            bool szamE = true;
            bool karakterszam = true;
            if (tbKiModosit2.Text.Length > 50)
            {
                karakterszam = false;
                MessageBox.Show("Maximum 50 karaktert írhat a megjegyzéshez!");
            }
            if (tbKiModosit.Text != "")
                foreach (var karakter in tbKiModosit.Text)

                {
                    if (!char.IsDigit(karakter))
                        szamE = false;
                }
            if (szamE == false)
                MessageBox.Show("Csak számot írhat az összeg mezőbe (0-nál nagyobbat)!");
           
            else if (szamE != false && karakterszam != false)
            {
                int osszeg = int.Parse(tbKiModosit.Text);
                
                    DialogResult dialogResult = MessageBox.Show("Biztosan módosítani szeretnéd az adatokat?", "Adatmódosítás", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                    try
                    {

                        conn.Open();
                        var cmdFrissit = new SqlCommand("UPDATE kiadas SET ki_kategoria =@cbModosit,ki_osszeg = @osszeg,ki_datum = @dtpModosit,ki_megjegyzes = @tbMegjegyzModosit where ID = @ID and regID = @regID", conn);
                        cmdFrissit.Parameters.AddWithValue("@cbModosit", cbKiModosit.selectedValue);
                        cmdFrissit.Parameters.AddWithValue("@osszeg", osszeg);
                        cmdFrissit.Parameters.AddWithValue("@dtpModosit", dtpKiModosit.Value.ToString("yyyy-MM-dd"));
                        cmdFrissit.Parameters.AddWithValue("@tbMegjegyzModosit", tbKiModosit2.Text);
                        cmdFrissit.Parameters.AddWithValue("@ID", rowID);
                        cmdFrissit.Parameters.AddWithValue("@regID", bejelID);
                        cmdFrissit.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Sikeres adatmódosítás");
                        this.Close();

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                
               

   
  }         } 

        private void pbLecsuk_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;

            }
            else if (WindowState == FormWindowState.Normal)

            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pbKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
