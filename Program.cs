using System;
using RestSharp;
using RestSharp.Authenticators;

namespace Bus_Board
{
    class Program
    {
        static void Main(string[] args)
        {
            var transportApiClient = new TransportApiClient();

            var departures = transportApiClient.GetBusDeparturesForStop("490008660N");
            Console.Write(departures);
        }
    }
}


