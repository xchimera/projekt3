using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;
using Model;
using Interfaces;

namespace GUI
{
    public partial class Form1 : Form
    {
        Personalesystem personalesystem;

        public Form1()
        {
            InitializeComponent();
            personalesystem = new Personalesystem();
            string[] row1 = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8" };
            lstFravær.Items.Add("Column1Text").SubItems.AddRange(row1);
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
            long cprnummer;
            string type = null;
            try
            {
                start_dato = DateTime.Parse(txtStartDato.Text);
                slut_dato = DateTime.Parse(txtSlutDato.Text);
                ListViewItem lvitm = lstFravær.SelectedItems["CPR"];
                cprnummer = long.Parse(lvitm.Text.ToString());
                if (rdbSyg.Checked)
                {
                    type = "syg";
                }
                else if (rdbFri.Checked)
                {
                    type = "fri";
                }
                else if (rdbFerie.Checked)
                {
                    type = "ferie";
                }
                personalesystem.OpretFravær(cprnummer, start_dato, slut_dato, txtFraværNote.Text, type);

            }
            catch (Exception)
            {
                MessageBox.Show("Indtast venligst rigtige værdier");
            }

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

            try
            {
                navn = txtFornavn.Text;
                adresse = txtAdresse.Text;
                by = txtBy.Text;
                postnr = int.Parse(txtPostnr.Text);
                telefon = long.Parse(txtTelefon.Text);
                cprnr = long.Parse(txtCPR.Text);
                afdeling = int.Parse(txtAfdeling.Text);
                if (personalesystem.OpretMedarbejder(navn, cprnr, adresse, postnr, telefon, afdeling))
                {
                    MessageBox.Show("Medarbejder oprettet");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                IMedarbejderData medarbejderData;
                IEnumerator medarbiterator = personalesystem.GetMedarbejderIterator();
                if (medarbiterator == null)
                {
                    MessageBox.Show("Medarbejderlisten kunne desværre ikke vises", "Systemfejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                medarbiterator.Reset();   // Sæt iterator til at pege før første element

                while (medarbiterator.MoveNext())   // så længe der er medarbejderer
                {

                    medarbejderData = (IMedarbejderData)medarbiterator.Current;   // læs aktuel/current medarbejder
                    ListViewItem medarbejdere = new ListViewItem();
                    medarbejdere.Text = medarbejderData.Cpr_nummer.ToString();
                    medarbejdere.SubItems.Add(medarbejderData.Navn);
                    medarbejdere.SubItems.Add(medarbejderData.Adresse);
                    medarbejdere.SubItems.Add(medarbejderData.Postnr.ToString());
                    medarbejdere.SubItems.Add(medarbejderData.By);
                    medarbejdere.SubItems.Add(medarbejderData.Tlf.ToString());
                    medarbejdere.SubItems.Add(medarbejderData.Afdelingsid.ToString());

                    lstMedarbKato.Items.Add(medarbejdere);
                    lstFravær.Items.Add(medarbejdere);
                }
                // referencer: Interfaces
                // oprettet ienumerator i conrtroller og medarbejdercollection
                // tilføjet BY i medarbeder og BY i IMedarbejderData
                // gjort IMmedarbejderData til Public
                // omdøbt lstView1 til lstFravær
            }
        }

        private void test_Click_1(object sender, EventArgs e)
        {
            {
                Medarbejder medarbejderData;
                IEnumerator medarbiterator = personalesystem.GetMedarbejderIterator();
                if (medarbiterator == null)
                {
                    MessageBox.Show("Medarbejderlisten kunne desværre ikke vises", "Systemfejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                medarbiterator.Reset();   // Sæt iterator til at pege før første element

                while (medarbiterator.MoveNext())   // så længe der er medarbejderer
                {

                    medarbejderData = medarbiterator.Current as Medarbejder;   // læs aktuel/current medarbejder
                    ListViewItem medarbejdere = new ListViewItem();
                    medarbejdere.Text = medarbejderData.Cpr_nummer.ToString();
                    medarbejdere.SubItems.Add(medarbejderData.Navn);
                    medarbejdere.SubItems.Add(medarbejderData.Adresse);
                    medarbejdere.SubItems.Add(medarbejderData.Postnr.ToString());
                    medarbejdere.SubItems.Add(medarbejderData.By);
                    medarbejdere.SubItems.Add(medarbejderData.Tlf.ToString());
                    medarbejdere.SubItems.Add(medarbejderData.Afdelingsid.ToString());

                    lstMedarbKato.Items.Add(medarbejdere);
                    lstFravær.Items.Add(medarbejdere);
                }
                // referencer: Interfaces
                // oprettet ienumerator i conrtroller og medarbejdercollection
                // tilføjet BY i medarbeder og BY i IMedarbejderData
                // gjort IMmedarbejderData til Public
                // omdøbt lstView1 til lstFravær
            }


        }


    }

}