using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace myFirstApiYaelFrank
{
    public class DataContext: IDataContext
    {

        public List<Event> EventList { get; set; } 

        //all lists - data from DB
        public DataContext()
        {
            //EventList = new List<Event>();
            //{  new Event { Id = Event.index, Title = "adi",Start=new DateTime(2023,10,25) },
            //   new Event { Id = Event.index, Title = "noa",Start=new DateTime(2023,11,25) },
            //   new Event { Id = Event.index, Title = "yael",Start=new DateTime(2023,11,22) }
            //};
            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                EventList = csv.GetRecords<Event>().ToList();
            }
        }

    }
}
