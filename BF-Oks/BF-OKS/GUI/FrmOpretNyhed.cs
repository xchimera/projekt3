using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;
using CalendarControl;

namespace GUI
{
    public partial class FrmOpretNyhed : Form
    {
        Personalesystem personalesystem;
        EVCalendar calender;
        DateTime dato;

        public FrmOpretNyhed(Personalesystem personalesystem, EVCalendar calender)
        {
            InitializeComponent();
            this.calender = calender;
            this.personalesystem = personalesystem;
            dateTimePicker1.Value = calender.LastClickedDay;
            
        }

        private void btnOpretNyhed_Click(object sender, EventArgs e)
        {            
            string nyhed;
            DateTime dato;
            dato = dateTimePicker1.Value;
            nyhed = txtNyhed.Text;
            long id = personalesystem.OpretNyhed(nyhed, dato);
 
            OpretNyhed(nyhed, nyhed, dato, colorDialog1.Color, id);

            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OpretNyhed(string header, string body, DateTime dato, Color color, long id)
        {
            CalEvent events = new CalEvent(header, body, dato, color, id);
            calender.Events.Add(events);
            calender.UpdateCalendar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColorPicker.BackColor = colorDialog1.Color;
        }
    }
}
