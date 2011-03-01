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
    public partial class FrmOpretNyhed : Form
    {
        Personalesystem personalesystem;

        public FrmOpretNyhed(Personalesystem personalesystem)
        {
            InitializeComponent();

            this.personalesystem = personalesystem;
        }

        private void btnOpretNyhed_Click(object sender, EventArgs e)
        {
            
            string nyhed;

            nyhed = txtNyhed.Text;

            personalesystem.OpretNyhed(nyhed);
        }
    }
}
