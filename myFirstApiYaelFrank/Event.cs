namespace myFirstApiYaelFrank
{
    public class Event
    {
       public static int index = 1;
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Event()
        {
            index++;
        }

    }
}
