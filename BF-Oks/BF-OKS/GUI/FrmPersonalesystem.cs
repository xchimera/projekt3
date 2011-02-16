using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //TODO: Bind GUI sammen med system
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //TODO: Fjern knap
        }

        private void btnVisFraværMedarbejder_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void btnRFravær_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnKalender_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnKartotek_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void btnRedigerKartotek_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }
                
        private void btnRegistrerFravær_Click(object sender, EventArgs e)
        {
            DateTime start_dato;
            DateTime slut_dato;

            start_dato = DateTime.Parse(txtStartDato.Text);
            slut_dato = DateTime.Parse(txtSlutDato.Text);

        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            // Attributter
            string navn;
            string adresse;
            string by;
            int postnr;
            long telefon;
            long cprnr;
            int afdeling;
         
            navn = txtFornavn.Text;
            adresse = txtAdresse.Text;
            by = txtBy.Text;
            postnr = int.Parse(txtPostnr.Text);
            telefon = long.Parse(txtTelefon.Text);
            cprnr = long.Parse(txtCPR.Text);
            afdeling = int.Parse(txtAfdeling.Text);            
        }
    }
}
