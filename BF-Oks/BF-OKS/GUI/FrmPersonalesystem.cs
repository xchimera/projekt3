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
using CalendarControl;

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

        private void OpdaterListView()
        {
            IMedarbejderData medarbejderdata;
            IEnumerator medarbejderiterator = personalesystem.GetMedarbejderIterator();
            evCalendar1.Events.Clear();
            LoadNyheder();
            
            if (medarbejderiterator == null)
            {
                MessageBox.Show("Medarbejderlisten kunne desværre ikke vises", "Systemfejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            medarbejderiterator.Reset();
            lstKartotek.Items.Clear();

            while (medarbejderiterator.MoveNext())
            {
                medarbejderdata = (IMedarbejderData)medarbejderiterator.Current;
                ListViewItem medarbejdere = new ListViewItem();

                medarbejdere.Text = medarbejderdata.Cpr_nummer.ToString();
                medarbejdere.SubItems.Add(medarbejderdata.Navn);
                medarbejdere.SubItems.Add(medarbejderdata.Adresse);
                medarbejdere.SubItems.Add(medarbejderdata.Postnr.ToString());
                medarbejdere.SubItems.Add(medarbejderdata.By);
                medarbejdere.SubItems.Add(medarbejderdata.Tlf.ToString());
                medarbejdere.SubItems.Add(medarbejderdata.Afdelingsid.ToString());
                
                lstKartotek.Items.Add(medarbejdere);
                IndsætKalenderFravær(medarbejderdata.Cpr_nummer);
                
            }
            medarbejderiterator.Reset();
            evCalendar1.UpdateCalendar();
        }

   



        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    IMedarbejderData medarbejderData;
            //    IEnumerator medarbiterator = personalesystem.GetMedarbejderIterator();
            //    if (medarbiterator == null)
            //    {
            //        MessageBox.Show("Medarbejderlisten kunne desværre ikke vises", "Systemfejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    medarbiterator.Reset();   // Sæt iterator til at pege før første element

            //    while (medarbiterator.MoveNext())   // så længe der er medarbejderer
            //    {
            //        //medarbejderData = (IMedarbejderData)medarbiterator.Current;   // læs aktuel/current medarbejder
            //        Medarbejder medarbejder = (Medarbejder)medarbiterator.Current;
                    
            //        ListViewItem medarbejdere = new ListViewItem();
            //        medarbejdere.Text = medarbejder.Cpr_nummer.ToString();
            //        medarbejdere.SubItems.Add(medarbejder.Navn);

            //        medarbejdere.SubItems.Add(medarbejder.Adresse);
            //        medarbejdere.SubItems.Add(medarbejder.Postnr.ToString());
            //        medarbejdere.SubItems.Add(medarbejder.By);
            //        medarbejdere.SubItems.Add(medarbejder.Tlf.ToString());
            //        medarbejdere.SubItems.Add(medarbejder.Afdelingsid.ToString());
                   
            //        //lstMedarbKato.Items.Add(medarbejdere);
                    
                    
            //        lstKartotek.Items.Add(medarbejdere);
            //        //lstRediger.Items.Add(medarbejdere);
            //    }

            //    medarbiterator.Reset();   // Sæt iterator til at pege før første element       

            //    // referencer: Interfaces
            //    // oprettet ienumerator i conrtroller og medarbejdercollection
            //    // tilføjet BY i medarbeder og BY i IMedarbejderData
            //    // gjort IMmedarbejderData til Public
            //    // omdøbt lstView1 til lstFravær skulle nok ikke v

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            OpdaterListView();
            //LoadNyheder();
        }

        public void IndsætKalenderFravær(long cprnummer)
        {
            IFraværData ifraværdata;
            IEnumerator fraværiterator = personalesystem.GetFraværIterator(cprnummer);

            if (fraværiterator == null)
            {
                return;
            }

            fraværiterator.Reset();

            while (fraværiterator.MoveNext())
            {
                ifraværdata = (IFraværData)fraværiterator.Current;
                OpretNyhed(ifraværdata.Dato_fra.Day + "-" + ifraværdata.Dato_fra.Month + "--" + ifraværdata.Dato_til.Day + "-" + ifraværdata.Dato_til.Month+ "  " + ifraværdata.Navn,"", ifraværdata.Dato_fra, Color.Red);
            }

        }

        private void LoadNyheder()
        {

            INyhedData inyheddata;
            IEnumerator nyhedsiterator = personalesystem.GetNyhed();

            nyhedsiterator.Reset();

            while (nyhedsiterator.MoveNext())
            {
                inyheddata = (INyhedData)nyhedsiterator.Current;
                OpretNyhed(inyheddata.NyhedText, inyheddata.NyhedText, inyheddata.Dato, Color.YellowGreen);
            }
            nyhedsiterator.Reset();


        }


        //private void txtSøgRegistrerFravær_TextChanged(object sender, EventArgs e)
        //{
            
        //        IMedarbejderData medarbejderdata;
        //        IEnumerator medarbiterator = personalesystem.GetMedarbejderIterator();
        //        if (txtSøg.Text =="")
        //        {
        //        }

        //        medarbiterator.Reset();
        //        lstRediger.Items.Clear();

        //        while (medarbiterator.MoveNext())
        //        {
        //            medarbejderdata = (IMedarbejderData)medarbiterator.Current;
        //            string info;
        //            info = Convert.ToString(txtSøg.Text);

        //            if (medarbejderdata.Navn == info || medarbejderdata.Adresse == info || Convert.ToString(medarbejderdata.Postnr) == info || medarbejderdata.Adresse == info 
        //                || medarbejderdata.By == info || Convert.ToString(medarbejderdata.Cpr_nummer) == info || Convert.ToString(medarbejderdata.Tlf) == info);
                    
        //            {
        //                ListViewItem medarbejdere = new ListViewItem();
        //                medarbejdere.Text = medarbejderdata.Cpr_nummer.ToString();
        //                medarbejdere.SubItems.Add(medarbejderdata.Navn);
        //                medarbejdere.SubItems.Add(medarbejderdata.Adresse);
        //                medarbejdere.SubItems.Add(medarbejderdata.Postnr.ToString());
        //                medarbejdere.SubItems.Add(medarbejderdata.By);
        //                medarbejdere.SubItems.Add(medarbejderdata.Tlf.ToString());
        //                medarbejdere.SubItems.Add(medarbejderdata.Afdelingsid.ToString());
                                                
        //                lstRediger.Items.Add(medarbejdere);

        //            }



                        
                    
        //        }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvitm = lstKartotek.SelectedItems[0];
                long cprnummer = long.Parse(lvitm.Text.ToString());

                FrmFravær fravær = new FrmFravær(personalesystem, cprnummer);
                fravær.ShowDialog(this);
                OpdaterListView();
            }
            catch (Exception)
            {
                MessageBox.Show("vælg venligst en  medarbejder");
            }
        }

        private void btnRediger_Click(object sender, EventArgs e)
        {

        }

        private void btnRedigerMedarbejder_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvitm = lstKartotek.SelectedItems[0];
                long cprnummer = long.Parse(lvitm.Text.ToString());
                Medarbejder medarbejder = personalesystem.FindMedarbejder(cprnummer);

                FrmRedigerMedarbejder redigermedarbejder = new FrmRedigerMedarbejder(personalesystem, medarbejder);
                redigermedarbejder.ShowDialog(this);
                OpdaterListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg venligst en medarbejder");
            }
        }

        private void btnOpretMedarbejder_Click(object sender, EventArgs e)
        {
            FrmOpretMedarbejder opretmedarbejder = new FrmOpretMedarbejder(personalesystem);
            opretmedarbejder.ShowDialog();
            OpdaterListView();
        }

        private void lstKartotek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKartotek.SelectedItems.Count > 0) 
            {
                ListViewItem lvitm = lstKartotek.SelectedItems[0];
                long cprnummer = long.Parse(lvitm.Text.ToString());

                IFraværData ifraværdata;
                IEnumerator fraværiterator = personalesystem.GetFraværIterator(cprnummer);

                fraværiterator.Reset();
                lstFravær.Items.Clear();

                while (fraværiterator.MoveNext())
                {
                    ifraværdata = (IFraværData)fraværiterator.Current;
                    ListViewItem fravære = new ListViewItem();
                    fravære.Text = ifraværdata.Dato_fra.Day + "-" + ifraværdata.Dato_fra.Month + "-" + ifraværdata.Dato_fra.Year;
                    fravære.SubItems.Add(ifraværdata.Dato_til.Day + "-"+ ifraværdata.Dato_til.Month + "-" + ifraværdata.Dato_til.Year);
                    fravære.SubItems.Add(ifraværdata.Type.ToString());
                    fravære.SubItems.Add(ifraværdata.Note.ToString());

                    lstFravær.Items.Add(fravære);
                }

                fraværiterator.Reset();
            }
        }





        private void txtSøg_TextChanged(object sender, EventArgs e)
        {
            IMedarbejderData medarbejderdata;
            IEnumerator medarbejderiterator = personalesystem.GetMedarbejderIterator();
            if (tstxt_soeg.Text == "")
            {
                OpdaterListView();
                return;
            }

            medarbejderiterator.Reset();
            lstKartotek.Items.Clear();

            while (medarbejderiterator.MoveNext())
            {                
                medarbejderdata = (IMedarbejderData)medarbejderiterator.Current;
                string info;
                info = Convert.ToString(tstxt_soeg.Text);

                if ((medarbejderdata.Navn).ToUpper().IndexOf(info.ToUpper()) != -1 || Convert.ToString(medarbejderdata.Cpr_nummer).IndexOf(info) != -1 || Convert.ToString(medarbejderdata.Postnr) == info 
                        || Convert.ToString(medarbejderdata.By) == info || Convert.ToString(medarbejderdata.Tlf).IndexOf(info) != -1 || Convert.ToString(medarbejderdata.Afdelingsid) == info)
                {
                
                ListViewItem medarbejdere = new ListViewItem();

                medarbejdere.Text = medarbejderdata.Cpr_nummer.ToString();
                medarbejdere.SubItems.Add(medarbejderdata.Navn);
                medarbejdere.SubItems.Add(medarbejderdata.Adresse);
                medarbejdere.SubItems.Add(medarbejderdata.Postnr.ToString());
                medarbejdere.SubItems.Add(medarbejderdata.By);
                medarbejdere.SubItems.Add(medarbejderdata.Tlf.ToString());
                medarbejdere.SubItems.Add(medarbejderdata.Afdelingsid.ToString());

                lstKartotek.Items.Add(medarbejdere);
                }
            }
            medarbejderiterator.Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FrmOpretNyhed nyhed = new FrmOpretNyhed(personalesystem, evCalendar1);
            //nyhed.ShowDialog(this);
        }

        private void indsætNyhedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOpretNyhed opretnyhed = new FrmOpretNyhed(personalesystem, evCalendar1);
            opretnyhed.ShowDialog(this);
        }

        public void OpretNyhed(string header, string body, DateTime dato, Color color)
        {
            CalEvent events = new CalEvent(header, body, dato, color);
            evCalendar1.Events.Add(events);
            //evCalendar1.UpdateCalendar();
        }

        //TODO: FrmPersonaleSystem -> RedigérFravær! 

      private void lstFravær_MouseDown(object sender, MouseEventArgs e)
      {
          if ((e.Button == MouseButtons.Right) && (lstFravær.GetItemAt(e.X, e.Y) != null)) //If it's the right button.
          {

              RedigerFraværMenu.Show(this.lstFravær, e.Location);

          }
      }

    }
}
