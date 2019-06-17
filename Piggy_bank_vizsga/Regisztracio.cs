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
    public partial class Regisztracio : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; AttachDbFileName=|DataDirectory|koltsegkovetes.mdf;");
        ToolTip jelszoToolTip = new ToolTip();
        public Regisztracio()
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AppDomain.CurrentDomain.SetData("DataDirectory",
              Path.GetFullPath(Path.Combine(Assembly.GetExecutingAssembly().Location,
              @"..\..\..\Resources")));
        }

        private void btnReg_Click(object sender, EventArgs e)
        {   
            if (tbFelhasznalo.Text == "" || tbJelszo.Text == "" || tbJelszoUjra.Text == "" || tbVeznev.Text == "" || tbKernev.Text == "")
            {
                MessageBox.Show("Tölts ki mindent mezőt!");
            }
         
            else if (tbJelszo.Text != tbJelszoUjra.Text)
            {
                MessageBox.Show("A két jelszó nem egyezik!");
            }
            else
            { 
                int maxHossz = 20; 
                int minHossz = 6;
                int nagy = 0;
                int kis = 0;
                int szam = 1;

                foreach (var karakter in tbJelszo.Text)

                {   if (char.IsUpper(karakter))
                        nagy++;
                   
                    if (char.IsLower(karakter))
                        kis++;
                  
                    if (char.IsDigit(karakter))
                        szam++;  
                }
              
                bool jelszoOk = true;
                if (nagy == 0 || kis == 0 || szam < 1 || tbJelszo.Text.Length < minHossz || tbJelszo.Text.Length > maxHossz)

                {
                    MessageBox.Show("A jelszó nem felel meg a kritériumoknak.");
                    jelszoOk = false;

                }
                try
                {
                    conn.Open();

                    bool FelhasznTartalmaz = false;
                    var cmdFelhasznLekerd = new SqlCommand($"SELECT count(*) FROM reg_adatok WHERE felhasznalo = @tbFelhaszn", conn);
                    cmdFelhasznLekerd.Parameters.AddWithValue("@tbFelhaszn", tbFelhasznalo.Text);
                    FelhasznTartalmaz = (int)cmdFelhasznLekerd.ExecuteScalar() > 0;

                    if (FelhasznTartalmaz)
                        MessageBox.Show("Ez a felhasználónév foglalt!");
                    bool megfelelo = true;
                    if (tbVeznev.Text.Length > 25)
                    {
                        megfelelo = false;
                        MessageBox.Show("Túl hosszú vezetéknév!");
                    }
                    if (tbKernev.Text.Length > 25)
                    {
                        megfelelo = false;
                        MessageBox.Show("Túl hosszú kresztnév!");
                    }
                    if (tbFelhasznalo.Text.Length > 25)
                    {

                        megfelelo = false;
                        MessageBox.Show("Túl hosszú felhasználónév!");
                    }

                    else if (!FelhasznTartalmaz && jelszoOk != false && megfelelo != false) // ha megfelelő 
                    {
                        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                        UTF8Encoding utf8 = new UTF8Encoding();
                        string hash = BitConverter.ToString(md5.ComputeHash(utf8.GetBytes(tbJelszo.Text)));
                        var cmd = "INSERT INTO reg_adatok(vez_nev, ker_nev, felhasznalo, jelszo) VALUES" +
                        $"('{tbVeznev.Text}', '{tbKernev.Text}', '{tbFelhasznalo.Text}' , '{hash}');";
                        var adapter = new SqlDataAdapter();
                        adapter.InsertCommand = new SqlCommand(cmd, conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Sikeres regisztráció!");
                        conn.Close();
                        this.Close();
                        var bejelentkezes = new Bejelentkezes();
                        bejelentkezes.Show();
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
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

        private void pbKilep_Click(object sender, EventArgs e)
        { 
            var bejelentkezes = new Bejelentkezes();
            bejelentkezes.Show();
            this.Close();
            
        }

        private void tbJelszo_KeyPress(object sender, KeyPressEventArgs e)
        {  
            jelszoToolTip.ToolTipIcon = ToolTipIcon.Info;
           jelszoToolTip.Show("Min 6 max 20 karakter.Tartalmazzon kis- nagy betűt és számot", (sender as Control));
        }

        private void Regisztracio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnReg_Click(sender, e);
            }
        }
    }

}      
    




