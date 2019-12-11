    using System;
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json;

    namespace ooad_labb2
    {
        public class AstronautServices: IAstronautServices
        {
            public List<Person> GetAstronauts()
            {
                var baseUrl = "http://api.open-notify.org/astros.json";
                var client = new WebClient();
                var json = client.DownloadString(baseUrl);
                client.Dispose();
                return JsonConvert.DeserializeObject<AstronautHelper>(json).People;
            }

            public object GetNumbers()
            {
                var baseUrl = "http://api.open-notify.org/astros.json";
                var client = new WebClient();
                var json = client.DownloadString(baseUrl);
                client.Dispose();
                return JsonConvert.DeserializeObject<AstronautHelper>(json).number;
            }

            public AstronautHelper GetAstronautsTwo()
            {
                var baseUrl = "http://api.open-notify.org/astros.json";
                var client = new WebClient();
                var json = client.DownloadString(baseUrl);
                client.Dispose();
                return JsonConvert.DeserializeObject<AstronautHelper>(json);
            }
        }


    }

    //MIN GAMLA LÖSNING
    //public class AstronautServices: IAstronautServices
    //{



    //    public dynamic GetDynamic()
    //    {
    //        string json = new WebClient().DownloadString("http://api.open-notify.org/astros.json");
    //        dynamic parsed = JsonConvert.DeserializeObject(json);
    //        return parsed;
    //    }

    //    public dynamic GetData(dynamic obj)
    //    {
    //        string json = new WebClient().DownloadString("http://api.open-notify.org/astros.json");
    //        dynamic parsed = JsonConvert.DeserializeObject(json);
    //        return parsed; 

    //    }


    //}

