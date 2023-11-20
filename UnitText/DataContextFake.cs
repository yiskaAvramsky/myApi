using myAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitText
{
    public class DataContextFake: IDataContext
    {
        public int count { get; set; }
        public List<Event> EventList { get; set; }
        
        public DataContextFake ()
        {
            EventList = new List<Event>();
            EventList.Add(new Event { id = 1, title = "default event1", start = DateTime.Now });
            EventList.Add(new Event { id = 2, title = "default event2", start = DateTime.Now });
            EventList.Add(new Event { id = 3, title = "default event3", start = DateTime.Now });
            count = 4;
        }
    }
}
