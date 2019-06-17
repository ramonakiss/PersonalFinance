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
    public partial class BevetelModositas : Form
    {
        int bejelID;
        int rowID;
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; AttachDbFileName=|DataDirectory|koltsegkovetes.mdf;");
        public BevetelModositas(int id,int rowid)
        {
            InitializeComponent();
            bejelID = id;
            rowID = rowid;
        }
 

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

        private void btnModosit_Click(object sender, EventArgs e)
        {

            bool szamE = true;
            bool karakterszam = true;
            if (tbBeModosit2.Text.Length > 50)
            {
                MessageBox.Show("Maximum 50 karaktert írhat megjegyzéshez!");
                karakterszam = false;
            }
            if (tbBeModosit.Text != "")
                foreach (var karakter in tbBeModosit.Text)

                {
                    if (!char.IsDigit(karakter))
                        szamE = false;
                }
            if (szamE == false)
                MessageBox.Show("Csak számot írhat az összeg mezőbe!(0-nál nagyobbat)");


            else if (szamE != false && karakterszam != false)
            {
                int osszeg = int.Parse(tbBeModosit.Text);
                DialogResult dialogResult = MessageBox.Show("Biztosan módosítani szeretné az adatokat?", "Adatmódosítás", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        var cmdFrissit = new SqlCommand("UPDATE bevetel SET be_kategoria =@cbModosit,be_osszeg = @osszeg," +
                            "be_datum = @dtpModosit," +
                            "be_megjegyzes = @tbMegjegyzModosit" +
                            " where ID = @ID and regID = @regID", conn);
                        cmdFrissit.Parameters.AddWithValue("@cbModosit", cbBeModosit.selectedValue);
                        cmdFrissit.Parameters.AddWithValue("@osszeg", osszeg);
                        cmdFrissit.Parameters.AddWithValue("@dtpModosit", dtpBeModosit.Value.ToString("yyyy-MM-dd"));
                        cmdFrissit.Parameters.AddWithValue("@tbMegjegyzModosit", tbBeModosit2.Text);
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
              
            }
        }
                private void pbKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

