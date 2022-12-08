using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace LibrarieTestUnitaires
{
    public class Swapi
    {
        private string films;

        public Swapi() { }

        public string Films
        {
            get { return films; }
            set { films = value; }
        }

        public void AvoirFilmsAvecLuke()
        {
            string json = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/ticker/");

            List<Swapi> items = JsonConvert.DeserializeObject<List<Swapi>>(json);

            Console.WriteLine(items.Count);
        }
    }
}
