using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEECEVenueServiceRequester.Model.JSON
{
    public class VenueList
    {
        public VenueList()
        {
            venues = new List<Venue>();
        }
        public List<Venue> venues { get; set; }
    }

    public class Venue
    {
        public Venue()
        {
            CommingEvents = new List<Commingevent>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public List<Commingevent> CommingEvents { get; set; }
    }

    public class Commingevent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Weekday { get; set; }
        public string Monthday { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Time { get; set; }
        public string VPlaceforEvent { get; set; }
    }
}
