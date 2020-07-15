using System;
using RestSharp;
using RestSharp.Authenticators;

namespace Bus_Board
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new RestClient("https://transportapi.com/v3/uk/bus/stop/490008660N/live.json?app_id=171db06a&app_key=ce4314169d53cd484b70d421f63d27d7&group=route&nextbuses=yes");
            client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

            var timeline = await client.GetAsync<ApiResponse>(request, cancellationToken);
        }
    }
}
