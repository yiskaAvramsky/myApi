namespace myApi
{
    public interface IDataContext
    {
        public List<Event> EventList { get; set; }
        public int count { get; set; }
    }
}
