using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;

namespace LibrarieTestUnitaires
{
    public class Swapi
    {
        private List<string> films;

        public Swapi() 
        {
            films = new List<string>();
        }

        public List<string> Films
        {
            get { return films; }
            set { films = value; }
        }

        public void AvoirFilmsAvecLuke()
        {
            string json = new WebClient().DownloadString("https://swapi.dev/api/people/1");

            var root = JObject.Parse(json);
            string[] UrlFilms = root["films"].ToObject<string[]>();

            foreach(string urlFilm in UrlFilms)
            {
                json = new WebClient().DownloadString(urlFilm);
                root = JObject.Parse(json);

                films.Add(root["title"].ToObject<string>());

            }
        }
    }
}
