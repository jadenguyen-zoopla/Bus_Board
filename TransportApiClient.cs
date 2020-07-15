using RestSharp;
​
namespace Bus_Board
{
    public class TransportApiClient //Class that goes and makes our API call and returns our objects (fetches all data)
    {
        private RestClient client;
​
        public TransportApiClient() //Created a constructor that says when you create a new one of these classes the first thing it does is goes and creats a new client
        {
            //Every instance of this class is owned by client itself and is centered on this URL
            client = new RestClient("https://transportapi.com/"); //host path
        }
​
        // https://transportapi.com/v3/uk/bus/stop/490008660N/live.json?app_id=3d4e7caf&app_key=d6e85b063f40ecaa367a39324004c466&group=no&nextbuses=yes
        public BusDepartureResponse GetBusDeparturesForStop(string stopcode) 
        //Created a method that makes the call for us and return the object we created
        //If user gives the stop code, it will give back the buses for that stop
        {
            //make new Rest Request
            var request = new RestRequest("v3/uk/bus/stop/490008660N/live.json") // path to my endpoint
                .AddQueryParameter("app_id", "3d4e7caf") //query parameter
                .AddQueryParameter("app_key", "d6e85b063f40ecaa367a39324004c466") //query parameter
                .AddQueryParameter("group", "no") //query parameter
                .AddQueryParameter("nextbuses", "yes"); //query parameter
​
            //return the value of making this request
            var response = client.Get<BusDepartureResponse>(request);
            return response.Data;
        }
    }
}