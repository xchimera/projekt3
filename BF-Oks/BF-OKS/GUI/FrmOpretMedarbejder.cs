using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;


namespace GUI
{
    public partial class FrmOpretMedarbejder : Form
    {
        Personalesystem personalesystem;


        public FrmOpretMedarbejder(Personalesystem personalesystem)
        {
            InitializeComponent();
            this.personalesystem = personalesystem;
        }




        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpretMedarbejder_Click(object sender, EventArgs e)
        {
            // Attributter
            string navn;
            string adresse;
            string by;
            int postnr;
            long telefon;
            long cprnr;
            int afdeling;

            try
            {
                navn = txtNavn.Text;
                adresse = txtAdresse.Text;
                by = txtBy.Text;
                postnr = int.Parse(txtPostnr.Text);
                telefon = long.Parse(txtTlf.Text);
                cprnr = long.Parse(txtCpr.Text);
                afdeling = int.Parse(txtAfdeling.Text);





                if (personalesystem.OpretMedarbejder(navn, cprnr, adresse, postnr, by, telefon, afdeling))
                {
                    MessageBox.Show("Medarbejder oprettet");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kunne ikke oprette medarbejder, tjek om medarbejderen findes");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Indtast venligst alle værdier, og venligst rigtigt");
            }
        }
    }
}
