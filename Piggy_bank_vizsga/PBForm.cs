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
    public partial class PBForm : Form
    {
        string bejelFelhaszn = "";
        int bejelID;
        UserControl aktualisUC = null; 
        public PBForm(string bejelentkezettFelhaszn, int id) 
        {
             InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            bejelFelhaszn = bejelentkezettFelhaszn;
            bejelID = id;
            aktualisUC = new KezdolapUC(); 
            aktualisUC.Location = new Point(200,33);
            this.Controls.Add(aktualisUC);
            (aktualisUC as KezdolapUC).lblUdv.Text = "Üdvözölöm " + bejelFelhaszn +"!\nKövesse nyomon a költségeit!"; 

        }

        private void btnKezdo_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(aktualisUC); 
            var kezdolapUC = new KezdolapUC();
            kezdolapUC.Location = new Point(200, 33);
            this.Controls.Add(kezdolapUC); 
            aktualisUC = kezdolapUC;
            (aktualisUC as KezdolapUC).lblUdv.Text = "Üdvözölöm " + bejelFelhaszn + "!\nKövesse nyomon a költségeit!";
        }

        private void btnBe_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(aktualisUC);
            var bevetelUC = new BevetelUC(bejelID);
            bevetelUC.Location = new Point(200, 33);
            this.Controls.Add(bevetelUC);
            aktualisUC = bevetelUC;
            this.Controls.Add(aktualisUC);
          
        }

        private void btnKi_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(aktualisUC);
            var kiadasUC = new KiadasUC(bejelID);
            kiadasUC.Location = new Point(200, 33);
            this.Controls.Add(kiadasUC);
            aktualisUC = kiadasUC;
            this.Controls.Add(aktualisUC);
        }

        private void btnAt_Click(object sender, EventArgs e)
        {
            timer.Start();
            if (pnlGombok.Height != 0)
            {
                pnlGombok.Height = 0;
                timer.Enabled = false;
            }
            
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

        private void pbKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbKijelent_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pnlGombok.Height = 135;
            timer.Stop();
        }

        private void btnHavi_Click(object sender, EventArgs e)
        {
            pnlGombok.Height = 0;
            this.Controls.Remove(aktualisUC);
            var haviUC = new AttekintesHaviUC(bejelID);
            haviUC.Location = new Point(200, 33);
            this.Controls.Add(haviUC);
            aktualisUC = haviUC;
            this.Controls.Add(aktualisUC);
        }

        private void btnEvi_Click(object sender, EventArgs e)
        {
            pnlGombok.Height = 0;
            this.Controls.Remove(aktualisUC);
            var eviUC = new AttekintesEviUC(bejelID);
            eviUC.Location = new Point(200, 33);
            this.Controls.Add(eviUC);
            aktualisUC = eviUC;
            this.Controls.Add(aktualisUC);
        }
    }
}
