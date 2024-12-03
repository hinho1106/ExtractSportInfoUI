using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SportInfoUI
{
    internal static class HTTPHandler
    {
        

        public static async Task<string> GETNonIceSportGeneralResponse()
        {
            HttpClient client = new HttpClient();

            const string url = "https://services3.arcgis.com/b9WvedVPoizGfvfD/arcgis/rest/services/COT_Sports_DropIn_View/FeatureServer/0/query?f=json&where=show_on_sports_map%20=%20%27Yes%27&returnGeometry=true&spatialRel=esriSpatialRelIntersects&outFields=*&outSR=102100&resultOffset=0&resultRecordCount=4000";

            HttpResponseMessage response = await client.GetAsync(url);


            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine("Request Success");
                return await response.Content.ReadAsStringAsync();

            }
            else
            {
                MessageBox.Show("Request failed with status code: " + response.StatusCode);
                return "";

            }

        }

        public static async Task<string> GETNonIceSportInfo(int centreID, string week)
        {
            HttpClient client = new HttpClient();


            string url = "https://www.toronto.ca/data/parks/live/locations/" + centreID + "/sports/week" + week + ".json";

            HttpResponseMessage response = await client.GetAsync(url);


            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine("Request Success");
                //Console.WriteLine();
                return await response.Content.ReadAsStringAsync();

            }
            else
            {
                MessageBox.Show("Request failed with status code: " + response.StatusCode);
                return "";

            }
        }

        public static async Task<string> GETIceSportGeneralResponse()
        {
            HttpClient client = new HttpClient();

            const string url = "https://services3.arcgis.com/b9WvedVPoizGfvfD/arcgis/rest/services/Skate_Locations_v2/FeatureServer/0/query?f=json&where=Show_On_Map%20=%20%27Yes%27&returnGeometry=true&spatialRel=esriSpatialRelIntersects&outFields=*&outSR=102100&resultOffset=0&resultRecordCount=4000";

            HttpResponseMessage response = await client.GetAsync(url);


            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine("Request Success");
                return await response.Content.ReadAsStringAsync();

            }
            else
            {
                MessageBox.Show("Request failed with status code: " + response.StatusCode);
                return "";

            }


        }

        public static async Task<string> GETIceSportInfo(int locationID, string week)
        {
            HttpClient client = new HttpClient();

            string url = "https://www.toronto.ca/data/parks/live/locations/" + locationID + "/skate/week" + week + ".json";

            HttpResponseMessage response = await client.GetAsync(url);


            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine("Request Success");
                return await response.Content.ReadAsStringAsync();

            }
            else
            {
                //MessageBox.Show("Request failed with status code: " + response.StatusCode +"\nLocationID: " + locationID);
                return "";

            }



        }
    }
}
