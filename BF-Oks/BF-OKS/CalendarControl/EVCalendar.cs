using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalendarControl
{
    public partial class EVCalendar : UserControl
    {
        ///////////////////// Attributes ////////////////////
        // List containing the Events for the calendar
        public List<CalEvent> Events = new List<CalEvent>();

        // Simple variables
        DateTime today = DateTime.Now;
        DateTime lastclickedday = DateTime.Now;
        public DateTime LastClickedDay
        {
            get { return lastclickedday; }
        }

        /////////////////////// Properties //////////////////////////
        // TODO: Properties
        ContextMenuStrip daymenu;
        public ContextMenuStrip DayContextMenu
        {
            get { return daymenu; }
            set { daymenu = value; }
        }

        ContextMenuStrip eventmenu;
        public ContextMenuStrip EventContextMenu
        {
            get { return eventmenu; }
            set { eventmenu = value; }
        }

        // Selected month and year
        int currentmonth = DateTime.Now.Month;
        int currentyear = DateTime.Now.Year;
        int daysbefore;

        // String Array containing the names for the different months
        string[] months = new string[] { "Januar", "Februar", "Marts", "April", "Maj", "Juni", "Juli", "August", "September", "Oktober", "November", "December" };

        // String array containing the different names for the days
        string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


        public EVCalendar()
        {
            // Initializes components on the form
            InitializeComponent();

            // Updates the calendar to show the currentmonth
            UpdateCalendar();
        }

        public void AddEvent(string Header, string Body, DateTime Date, Color EventColor, long id)
        {
            // Adds a new object of event to our Events list
            CalEvent calEvent = new CalEvent(Header, Body, Date, EventColor, id);
            Events.Add(calEvent);
            UpdateCalendar();
        }

        private void MouseEnter_Panel(object sender, EventArgs e)
        {
            // Lights up the day when mouse enters the panel
            Panel pan = (Panel)sender;
            pan.BackColor = Color.LightBlue;
        }

        private void MouseLeave_Panel(object sender, EventArgs e)
        {
            // Lights down the day when mouse leaves the panel
            Panel pan = (Panel)sender;
            if ((string)pan.Tag == (DateTime.Now.Day + daysbefore).ToString() && currentmonth == DateTime.Now.Month && currentyear == DateTime.Now.Year)
            {
                pan.BackColor = Color.FromArgb(215, 228, 242);
            }
            else
            {
                pan.BackColor = Color.AliceBlue;
            }
        }

        // Shows the contextmenu when a day panel is right clicked
        private void MouseClick_Panel(object sender, MouseEventArgs e)
        {
            string daytemp = ((Panel)sender).Tag.ToString();
            int day = int.Parse(daytemp) - daysbefore;
            lastclickedday = new DateTime(currentyear, currentmonth, day);

            if (e.Button == System.Windows.Forms.MouseButtons.Right && daymenu != null)
            {
                daymenu.Show(Cursor.Position);
            }
        }

        public void UpdateCalendar()
        {
            // Hides the Calendar while updating to avoid flickering
            tableLayoutPanel1.Visible = false;

            // Reset all day labels text
            foreach (Control con in tableLayoutPanel1.Controls)
            {
                if (con is Panel)
                {
                    // Remove all eventhandlers on mouse enter on day panels
                    con.MouseEnter -= new EventHandler(MouseEnter_Panel);
                    con.MouseLeave -= new EventHandler(MouseLeave_Panel);
                    con.MouseDown -= new MouseEventHandler(MouseClick_Panel);
                    foreach (Control pancon in con.Controls)
                    {
                        if ((string)pancon.Tag == "header")
                        {
                            pancon.Text = "";
                            pancon.BackColor = Color.Lavender;
                        }
                        else
                        {
                            pancon.Dispose();
                        }
                    }
                }
            }

            // Clears all the events before updating the calendar to avoid duplicates
            foreach (Control con in tableLayoutPanel1.Controls)
            {
                foreach (Control labelcon in con.Controls)
                {
                    if ((string)labelcon.Tag == "Event")
                    {
                        con.Controls.Remove(labelcon);
                    }
                }
            }

            ///////// Starts to initialize the calendar and name the dates right //////////
            // Retrieves the date of the first day of the current month
            DateTime time = Convert.ToDateTime("01/" + currentmonth.ToString() + "/" + currentyear.ToString());

            // Retrieves which day of the week the first day of the currentmonth is
            string dayofweek = Application.CurrentCulture.Calendar.GetDayOfWeek(time).ToString();
            daysbefore = Array.IndexOf(days, dayofweek);

            // Iterates through all the days in the month and sets the correct date on the label days
            for (int i = 0; i < DateTime.DaysInMonth(currentyear, currentmonth); i++)
            {
                foreach (Control con in tableLayoutPanel1.Controls)
                {
                    if (con is Panel)
                    {
                        // Sets the correct day text on the label
                        if ((string)con.Tag == ((i + 1) + daysbefore).ToString())
                        {
                            // Adds eventhandler to Mouse Enter on the current day panel
                            con.MouseEnter += new EventHandler(MouseEnter_Panel);
                            con.MouseLeave += new EventHandler(MouseLeave_Panel);
                            con.MouseDown += new MouseEventHandler(MouseClick_Panel);
                            foreach (Control pancon in con.Controls)
                            {
                                if ((string)pancon.Tag == "header")
                                {
                                    pancon.Text = (i + 1).ToString();
                                    pancon.BackColor = Color.FromArgb(185, 209, 234);
                                }
                            }
                        }
                    }
                }
            }


            // Adds an event if there is one on the current date
            foreach (Control con in tableLayoutPanel1.Controls)
            {
                if (con is Panel)
                {
                    foreach (CalEvent item in Events)
                    {
                        if ((item.date.Day + daysbefore).ToString() == (string)con.Tag && item.date.Month == currentmonth && item.date.Year == currentyear)
                        {
                            Label eventlabel = new Label();
                            eventlabel.Text = item.header;
                            eventlabel.Font = new Font(eventlabel.Font.FontFamily, 8, eventlabel.Font.Style);
                            eventlabel.Dock = DockStyle.Top;
                            eventlabel.Height = 16;
                            eventlabel.Tag = "Event";
                            eventlabel.AutoEllipsis = true;
                            eventlabel.AutoSize = false;
                            eventlabel.BackColor = item.eventcolor;
                            eventlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            con.Controls.Add(eventlabel);
                            eventlabel.BringToFront();
                        }
                    }
                }
            }

            // Sets the header text to the current month
            lbl_headermonth.Text = months[currentmonth - 1] + " " + currentyear.ToString();

            // Colors the calendar-cell which mathes the date today
            foreach (Control con in tableLayoutPanel1.Controls)
            {
                if (con is Panel)
                {
                    int day = today.Day + daysbefore;
                    if (con.Tag.ToString() == day.ToString() && DateTime.Now.Month == currentmonth && DateTime.Now.Year == currentyear)
                    {
                        con.BackColor = Color.FromArgb(215, 228, 242);
                    }
                    else
                    {
                        con.BackColor = Color.AliceBlue;
                    }
                }
            }

            // Shows the Calendar after updating
            tableLayoutPanel1.Visible = true;
        }

        private void pic_nextmonth_Click(object sender, EventArgs e)
        {
            // Directs the currently showing month to the next month
            if (currentmonth == 12)
            {
                currentmonth = 1;
                currentyear += 1;
            }
            else
            {
                currentmonth += 1;
            }
            UpdateCalendar();
        }

        private void pic_prevmonth_Click(object sender, EventArgs e)
        {
            // Directs the currently showing month to the previous month
            if (currentmonth == 1)
            {
                currentmonth = 12;
                currentyear -= 1;
            }
            else
            {
                currentmonth -= 1;
            }
            UpdateCalendar();
        }
    }
}
