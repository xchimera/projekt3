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
            //string[] row1 = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8" };
            //lstFravær.Items.Add("Column1Text").SubItems.AddRange(row1);
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
                ListViewItem lvitm = lstFravær.SelectedItems[0];
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

                IMedarbejderData medarbejderdata;
                IEnumerator medarbiterator = personalesystem.GetMedarbejderIterator();
                medarbiterator.Reset();

                while (medarbiterator.MoveNext())
                {
                    medarbejderdata = (IMedarbejderData)medarbiterator.Current;

                }

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
            try
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
                    //medarbejderData = (IMedarbejderData)medarbiterator.Current;   // læs aktuel/current medarbejder
                    Medarbejder medarbejder = (Medarbejder)medarbiterator.Current;
                    
                    ListViewItem medarbejdere = new ListViewItem();
                    medarbejdere.Text = medarbejder.Cpr_nummer.ToString();
                    medarbejdere.SubItems.Add(medarbejder.Navn);

                    medarbejdere.SubItems.Add(medarbejder.Adresse);
                    medarbejdere.SubItems.Add(medarbejder.Postnr.ToString());
                    medarbejdere.SubItems.Add(medarbejder.By);
                    medarbejdere.SubItems.Add(medarbejder.Tlf.ToString());
                    medarbejdere.SubItems.Add(medarbejder.Afdelingsid.ToString());

                    //lstMedarbKato.Items.Add(medarbejdere);
                   
                    lstFravær.Items.Add(medarbejdere);
                    //lstRediger.Items.Add(medarbejdere);
                }

                medarbiterator.Reset();   // Sæt iterator til at pege før første element

              

                // referencer: Interfaces
                // oprettet ienumerator i conrtroller og medarbejdercollection
                // tilføjet BY i medarbeder og BY i IMedarbejderData
                // gjort IMmedarbejderData til Public
                // omdøbt lstView1 til lstFravær skulle nok ikke v

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSøgRegistrerFravær_TextChanged(object sender, EventArgs e)
        {
            
                IMedarbejderData medarbejderdata;
                IEnumerator medarbiterator = personalesystem.GetMedarbejderIterator();
                if (txtSøg.Text =="")
                {
                }

                medarbiterator.Reset();
                lstRediger.Items.Clear();

                while (medarbiterator.MoveNext())
                {
                    medarbejderdata = (IMedarbejderData)medarbiterator.Current;
                    string info;
                    info = Convert.ToString(txtSøg.Text);

                    if (medarbejderdata.Navn == info || medarbejderdata.Adresse == info || Convert.ToString(medarbejderdata.Postnr) == info || medarbejderdata.Adresse == info 
                        || medarbejderdata.By == info || Convert.ToString(medarbejderdata.Cpr_nummer) == info || Convert.ToString(medarbejderdata.Tlf) == info);
                    
                    {
                        ListViewItem medarbejdere = new ListViewItem();
                        medarbejdere.Text = medarbejderdata.Cpr_nummer.ToString();
                        medarbejdere.SubItems.Add(medarbejderdata.Navn);
                        medarbejdere.SubItems.Add(medarbejderdata.Adresse);
                        medarbejdere.SubItems.Add(medarbejderdata.Postnr.ToString());
                        medarbejdere.SubItems.Add(medarbejderdata.By);
                        medarbejdere.SubItems.Add(medarbejderdata.Tlf.ToString());
                        medarbejdere.SubItems.Add(medarbejderdata.Afdelingsid.ToString());
                                                
                        lstRediger.Items.Add(medarbejdere);

                    }



                        
                    
                }
        }


    }
}
