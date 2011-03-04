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
    public partial class FrmOpretFravær : Form
    {
        long cprnummer;
        Personalesystem personalesystem;

        public FrmOpretFravær(Personalesystem personalesystem, long cprnummer)
        {
            InitializeComponent();
            this.cprnummer = cprnummer;
            this.personalesystem = personalesystem;
        }

        private void btnCancelFravær_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitFravær_Click(object sender, EventArgs e)
        {
            DateTime start_dato;
            DateTime slut_dato;
            string type = null;
            try
            {
                start_dato = dateTimePicker1.Value;
                slut_dato = dateTimePicker2.Value;
                
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
                if (personalesystem.OpretFravær(cprnummer, start_dato, slut_dato, txtFraværNote.Text, type))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Der skete en fejl under oprettelsen af fravær");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Indtast venligst rigtige værdier");
            }
            
        }
    }
}
