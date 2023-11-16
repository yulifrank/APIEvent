namespace myFirstApiYaelFrank
{
    public class Data
    {

        public List<Event> EventList { get; set; }

        //all lists - data from DB
        public Data()
        {
            EventList = new List<Event>()
            {  new Event { Id = Event.index, Title = "adi",Start=new DateTime(2023,10,25) },
               new Event { Id = Event.index, Title = "noa",Start=new DateTime(2023,11,25) },
               new Event { Id = Event.index, Title = "yael",Start=new DateTime(2023,11,22) }};
        }
        
    }
}
