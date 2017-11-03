using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookServiceRequester.Model.JSON;
using BookServiceRequester.Util.JSON;


namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hej du dær, ellers OK?");
            ST3ITS3ExServiceTesterJson requester23 = new ST3ITS3ExServiceTesterJson();
            requester23.TestExService();
            //TestJSONService requester1 = new TestJSONService();
            //requester1.testBookService();
            //TestXMLService requester2 = new TestXMLService();
            //requester2.testBookService();  
            //TestJSONASEECEVenueService requester3 = new TestJSONASEECEVenueService();
            //requester3.Testvenueservice();          
        }
        
    }
}
