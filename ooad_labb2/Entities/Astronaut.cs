    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    namespace ooad_labb2
    {

        public class Person
        {
            public string name { get; set; }
            public string craft { get; set; }
            public string number { get; set; }

            public Person(string name)
            {
                this.name = name;
            }

            public virtual void LoadData()
            {
                Console.WriteLine("\nAstronaut: {0} - ", name);
            }
        }

        public class RootObject
        {
            [JsonProperty("people")]
            public List<Person> people { get; set; }
            public int number { get; set; }
            public string message { get; set; }
        }
    }

