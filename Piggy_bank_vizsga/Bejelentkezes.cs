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
    public partial class Bejelentkezes : Form
    {
        

        public Bejelentkezes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AppDomain.CurrentDomain.SetData("DataDirectory",
               Path.GetFullPath(Path.Combine(Assembly.GetExecutingAssembly().Location,
               @"..\..\..\Resources")));
           
        }
        

        private void btnBejel_Click(object sender, EventArgs e)
        {   
            if (tbFelhasznalo.Text != "" && tbJelszo.Text != "")
            {

                string beirtHash;
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                string hash = BitConverter.ToString(md5.ComputeHash(utf8.GetBytes(tbJelszo.Text)));
                SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; AttachDbFileName=|DataDirectory|koltsegkovetes.mdf;");
                conn.Open();
                var cmdJelszo = new SqlCommand($"SELECT jelszo FROM reg_adatok WHERE felhasznalo = @tbFelhasznalo ", conn);
                cmdJelszo.Parameters.AddWithValue("@tbFelhasznalo", tbFelhasznalo.Text);
                var readerJelszo = cmdJelszo.ExecuteReader();

                if (readerJelszo.Read())
                {  
                    beirtHash = readerJelszo[0].ToString();
                    conn.Close();

                    if (hash == beirtHash) 
                    { 
                         conn.Open();
                        
                        string bejelentkezettFelhaszn = ""; 
                        int id;
                        var cmdAtadas = new SqlCommand($"SELECT ker_nev, ID  FROM reg_adatok WHERE felhasznalo = @tbFelhasznalo", conn);
                        cmdAtadas.Parameters.AddWithValue("tbFelhasznalo", tbFelhasznalo.Text);

                        var readerAtadas = cmdAtadas.ExecuteReader();
                        if (readerAtadas.Read())
                            bejelentkezettFelhaszn = readerAtadas[0].ToString();
                            id = (int)readerAtadas[1];
                        
                        conn.Close();
                        this.Hide();
                        var pb = new PBForm(bejelentkezettFelhaszn, id); 
                        pb.Show();
                    }
                    else MessageBox.Show("Nem megfelelő jelszót adott meg!");
                }

                else
                    MessageBox.Show("Nem megfelelő felhasználó név!");

            }
            else MessageBox.Show("Minden mezőt ki kell tölteni!");

         
        }

        private void pbKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void lblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  
            var regForm = new Regisztracio(); // regisztrációs form megnyitás
            regForm.Show();
            this.Hide();
        }

        private void pbLecsuk_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;

            }
            else if (WindowState == FormWindowState.Minimized)

            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Bejelentkezes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnBejel_Click(sender, e);
            }
        }
    }
}
