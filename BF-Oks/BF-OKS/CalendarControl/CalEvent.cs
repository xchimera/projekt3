using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CalendarControl
{
    public class CalEvent
    {
        /////// Attributes //////
        public long ID { get; set; }
        public string header { get; set; }
        public string body { get; set; }
        public DateTime date { get; set; }
        public Color eventcolor { get; set; }


        public CalEvent(string Header, string Body, DateTime Date, Color EventColor, long id)
        {
            ID = id;
            header = Header;
            body = Body;
            date = Date;
            eventcolor = EventColor;
        }
    }
}
