using System.Collections.Generic;
​
namespace Bus_Board
{
    public class BusDepartureResponse //Class that includes all the info about the Bus object
    {
        public string Name { get; set; }
        public Departures Departures { get; set; }
    }
​
    public class Departures
    {
        public List<DepartureInfo> All { get; set; }
    }
​
    public class DepartureInfo
    {
        public string Line { get; set; }
        public string Direction { get; set; }
        public string ExpectedDepartureTime { get; set; }
    }
