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
    public partial class FrmRedigerFravær : Form
    {
        long cprnummer;
        Personalesystem personalesystem;
               
        
        public FrmRedigerFravær(Personalesystem personalesystem, long cprnummer, DateTime dato_fra, DateTime dato_til, string type, string note)
        {
            InitializeComponent();
            this.cprnummer = cprnummer;
            this.personalesystem = personalesystem;
            dtpFra.Value = dato_fra;
            dtpTil.Value = dato_til;
            txtFraværNote.Text = note;
        }


        private void btnEditFravær_Click(object sender, EventArgs e)
        {

            try
            {
                //atributter
                DateTime start_dato = dtpFra.Value;
                DateTime slut_dato = dtpTil.Value;
                string type = null;
                string note = txtFraværNote.Text;
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
                personalesystem.RedigerFravær(cprnummer, start_dato, slut_dato, note, type);

            }
            catch (Exception)
            {
                    
                throw;
            }

        }

        private void SetType(string type)
        {
            if (type == "fri")
            {
                rdbFri.Checked = true;
            }
            else if (type == "syg")
            {
                rdbSyg.Checked = true;
            }
            else if (type == "fer" || type == "ferie")
            {
                rdbFerie.Checked = true;
            }
        }

        private void btnCancelFravær_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
