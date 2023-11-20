
namespace myApi
{
    public class DataContext:IDataContext
    {
        public List<Event> EventList { get; set; }
        public int count { get; set; }
        public DataContext()
        {
            EventList = new List<Event>();
            EventList.Add(new Event { id = 1, title = "default event", start = DateTime.Now });
            EventList.Add(new Event { id = 2, title = "default event2", start = DateTime.Now });
            EventList.Add(new Event { id = 3, title = "default event3", start = DateTime.Now });
            count = 4;
        }
    }
}
