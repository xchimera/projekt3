using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Controller;

namespace GUI
{
    public partial class FrmRedigerMedarbejder : Form
    {
        Personalesystem personalesystem;
        Medarbejder medarbejder;

        public FrmRedigerMedarbejder(Personalesystem personalesystem, Medarbejder medarbejder)
        {
            InitializeComponent();
            this.medarbejder = medarbejder;
            this.personalesystem = personalesystem;
            txtCpr.Text = medarbejder.Cpr_nummer.ToString();
            txtNavn.Text = medarbejder.Navn;
            txtAdresse.Text = medarbejder.Adresse;
            txtPostnr.Text = medarbejder.Postnr.ToString();
            txtBy.Text = medarbejder.By;
            txtTlf.Text = medarbejder.Tlf.ToString();
            txtAfdeling.Text = medarbejder.Afdelingsid.ToString();
        }

        private void btnRedigerMedarbejder_Click(object sender, EventArgs e)
        {
                   
            // Attributter
            string navn;
            string adresse;
            string by;
            int postnr;
            long telefon;
            
            int afdeling;

            try
            {


                navn = txtNavn.Text;
                adresse = txtAdresse.Text;
                by = txtBy.Text;
                postnr = int.Parse(txtPostnr.Text);
                telefon = long.Parse(txtTlf.Text);
                
                afdeling = int.Parse(txtAfdeling.Text);


                if (personalesystem.RedigerMedarbejder(medarbejder.Cpr_nummer, navn, adresse, postnr, telefon, afdeling))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kunne ikke rette medarbejder, tjek om medarbejderen findes");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Indtast venligst alle værdier rigtigt");
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSletMedarbejder_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("Er du sikker på du vil slette " + medarbejder.Navn + "?", "Slet " + medarbejder.Navn + "?", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    SletMedarbejder();
                    break;
                case DialogResult.No:

                    break;
            }
        }


        public void SletMedarbejder()
        {
            if (personalesystem.SletMedarbejder(medarbejder.Cpr_nummer))
            {
                MessageBox.Show("Medarbejder slettet");
                this.Close();
            }
            else
            {
                MessageBox.Show("Der skete en fejl under sletning af " + medarbejder.Navn);
            }
            
        }
            
        
    }
}
