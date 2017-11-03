using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALRESTfulUtil.HttpClientJson;
using ASEECEVenueServiceRequester.Model.JSON;

namespace ASEECEVenueServiceRequester.Util.JSON
{
    public class ASEECEVenueServiceUtilJSON
    {
        /**
         * Hvilke use cases ønskes gennemført
         *       -> Hvilke utility metoder skal udføres
         * 1 Opret et Spillested (Venue) 
         *          Aktion POST venueservice/Venues
         * 2 Opret og tilknyt et arangement (Event) til et spillested
         *          Aktion PUT venueservice/Venues/{id} 
         * 3 Slet et arrangement fra et spillested
         *          Aktion DELETE venueservice/Events/{id}
         * 4 Ret et arrangement på et givent spillested
         *          Aktion PUT venueservice/Events/{id}
         * 5 Slet et spillested og dets arrangementer
         *          Aktion DELETE venueservice/Events/{id}
         * 6 Vis en oversigt af arrangementer på et spillested
         *          Aktion GET venueservice/Venues/{id}
         * 7 Vis en oversigt over alle arrangementer uanset spillested
         *          Aktion GET venueservice/Events
         **/

        private string portnumber, hostname, servicepath;
        private string fullservicepath;


        public ASEECEVenueServiceUtilJSON(string hname, string portno, string serpath)
        {
            portnumber = portno;
            hostname = "http://" + hname + ":" + portno + "/";
            servicepath = serpath + "/";
            fullservicepath = "http://" + hname + ":" + portno + "/" + servicepath;
        }


        public Venue PostVenue(Venue venue) //Case 1
        {
            APIPostJSON<Venue> venuepost = new APIPostJSON<Venue>(hostname, servicepath + "Venues", venue);
            return venuepost.data;
        }

        public Venue PutVenue(Venue venue) //Case 2
        {
            APIPutJSON<Venue> venueput = new APIPutJSON<Venue>(hostname, servicepath + "Venues/" + venue.Id, venue);
            return venueput.data;
        }

        public void DeleteEvent(Commingevent ev) //Case 3
        {
            APIDeleteJSON<Commingevent> eventdel = new APIDeleteJSON<Commingevent>(hostname, servicepath + "Events/" + ev.Id, ev);
            //ingen return data da event er slettet
        }

        public Commingevent PutEvent(Commingevent ev) //Case 4
        {
            APIPutJSON<Commingevent> eventput = new APIPutJSON<Commingevent>(hostname, servicepath + "Events/" + ev.Id, ev);
            return eventput.data;
        }
        
        public void DeleteVenue(Venue venue) //Use Case 5
        {
            APIDeleteJSON<Venue> deletevenue = new APIDeleteJSON<Venue>(hostname, servicepath + "Venues/" + venue.Id, venue);
        }

        public Venue getVenue(Venue venue) //Use Case 6
        {
            APIGetJSON<Venue> getvenue = new APIGetJSON<Venue>(fullservicepath + "Venues/" + venue.Id);
            return getvenue.data;
        }

        public List<Commingevent> getAllEvent() //Use Case 7
        {
            APIGetJSON<List<Commingevent>> getevents = new APIGetJSON<List<Commingevent>>(fullservicepath + "Events");
            return getevents.data;
         }
    }
}