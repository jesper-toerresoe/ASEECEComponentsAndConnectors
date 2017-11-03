using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASEECEVenueServiceRequester.Model.JSON;
using ASEECEVenueServiceRequester.Util.JSON;

namespace TestApplication
{
    class TestJSONASEECEVenueService
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
        public void Testvenueservice()
        {
            ASEECEVenueServiceUtilJSON vstester = new ASEECEVenueServiceUtilJSON("venueserviceaseece.azurewebsites.net", "", "venueservice");
            VenueList vlist = new VenueList(); 
            Venue myvenue = new Venue() {Id=0,Name="Sørens Spillested",Street="Vestergade 66",Town="Aarhus",Country="Denmark" };
            vlist.venues.Add(myvenue); //Lokal udgave af spillested oprette
            Commingevent myevent = new Commingevent() {Id=0 /*Husk 0 for opret!*/,Title="Sing Along",Weekday="Tirsdag",Month="Oktober",Monthday="2",Year="2016",Time="20.30",VPlaceforEvent="Sørens Spillested" };
            //Og herover et lokalt oprette arrangement
            myvenue.CommingEvents.Add(myevent); //Spillested og arrangement knytte sammen
            myvenue = vstester.PostVenue(myvenue); //Use Case 1 udført venueservice og lokalt spillested er opdateret 
            //Use Case 2 her med to ny arrangmenter
            Commingevent nytevent = new Commingevent() { Id = 0 /*Husk 0 for opret!*/, Title = "Elron Harald", Weekday = "Fredag", Month = "November", Monthday = "11", Year = "2016", Time = "23:00", VPlaceforEvent = "Sørens Spillested" };
            myvenue.CommingEvents.Add(nytevent);
            Commingevent nytevent1 = new Commingevent() { Id = 0 /*Husk 0 for opret!*/, Title = "Elevis Presley", Weekday = "Sunday", Month = "January", Monthday = "08", Year = "2017", Time = "16:00:00", VPlaceforEvent = "Sørens Spillested" }; ;
            myvenue.CommingEvents.Add(nytevent1); //Tilføjet spillested
            vstester.PutVenue(myvenue); //Opdater venueservice
            myvenue = vstester.getVenue(myvenue); //opdater lokal udgave at venue og events primært Id's
            //Use Case 2 udført
            //Use Case 3
            vstester.DeleteEvent(myvenue.CommingEvents[1]); //Udpeget arangement/event via index
            myvenue.CommingEvents.RemoveAt(1); //Opdater lokalt spillested og Use Case 3 udført
            //Use Case 4
            myevent = myvenue.CommingEvents[0]; //Reference til Event der skal rettes her via index
            myevent.Time = "23:00";
            myevent.Title = "Sing Along Late";
            vstester.PutEvent(myevent); //Use Case 4 udført lokale ændringer er nu også på venueservice
            //Use Case 5 
            //Kræver at hvert enkelt arrangement til et givent spillested slettes enkeltvis
            foreach (Commingevent ce in myvenue.CommingEvents)
            {
                vstester.DeleteEvent(ce);
            }
            vstester.DeleteVenue(myvenue); //slet på venueservice
            myvenue = null; //slet lokalt og når spillested er slettet er Use Case 5 udført
            //Use Case 6
            Venue venueevent = new Venue() {Id=120 }; //Sæt Id for ønskede spillested
            venueevent = vstester.getVenue(venueevent); //Hent spillested med arrangement fra venueservice 
            //Use Case 7
            List<Commingevent> allevents = vstester.getAllEvent();
            //That's all folks



        }
    }
}
