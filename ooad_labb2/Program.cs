using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace ooad_labb2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press a key to fetch the astronauts currently in space");
            Console.ReadKey();
            ConsoleViewer consoleViewer = new ConsoleViewer(new AstronautServices());
            consoleViewer.Load();
            //GAMLA LÖSNINGEN
            // IAstronautServices astronautServices = new AstronautServices();
            //var dynamic = astronautServices.GetDynamic();
            // //Console.WriteLine(dynamic.GetData());


            // foreach (var result in dynamic)
            // {
            //     Console.WriteLine(result);
            //  }
            //Console.WriteLine("Number of people in space: " + );





            //RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(json);
            //var astronaut = JsonConvert.DeserializeObject<List<Person>>(json);
            //var root = JsonConvert.DeserializeObject<RootObject>(json);
            //foreach (var data in astronaut)
            //{
            //    Console.WriteLine(rootObject);
            //}
            //Console.WriteLine(root);

        }


    }

}
