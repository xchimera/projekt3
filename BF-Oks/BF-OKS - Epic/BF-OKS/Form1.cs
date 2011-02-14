using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Database;

namespace BF_OKS
{
    public partial class Form1 : Form
    {
        DB_Sql sql;
        public Form1()
        {
            InitializeComponent();
            sql = new DB_Sql();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medarbejder med = sql.FindPersonale("søren");
            
        }
    }
}
