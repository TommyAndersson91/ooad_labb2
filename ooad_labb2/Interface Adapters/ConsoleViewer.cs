    using System;
    using System.Collections.Generic;

    namespace ooad_labb2
    {
        public class ConsoleViewer
        {

            private IAstronautServices services;

            public ConsoleViewer(IAstronautServices iAstronautServices)
            {
                services = iAstronautServices;
            }

            public void Load()
            {
                printCurrentAstronauts(services.GetAstronauts());
                // printNumberOfAstronauts(services.GetNumbers());
                printNumberOfAstronautsObj(services.GetAstronautsTwo()); 
            }

            public void printCurrentAstronauts(List<Person> CurrentAstronauts)
            {
                //Console.WriteLine("Number of persons in space: {0}", CurrentAstronauts.Count);
                foreach (var astronaut in CurrentAstronauts)
                {
                    Console.WriteLine("Name: {0}, Craft: {1}", astronaut.name, astronaut.craft);
                }
            }

            public void printNumberOfAstronauts(object number)
            {
                Console.WriteLine("Number of persons in space: {0}", number);
       
            }

            public void printNumberOfAstronautsObj(AstronautHelper astronautHelper)
            {
                Console.WriteLine("Number of persons in space: {0}", astronautHelper.number);

            }
        }
    }
