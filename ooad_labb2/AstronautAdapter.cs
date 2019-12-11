    using System;
    namespace ooad_labb2
    {
        public class AstronautAdapter: Person
        {
            private AstronautServices _astronautServices;

            public AstronautAdapter(string name)
                :base(name)
            {
            }

            public override void LoadData()
            {  
                _astronautServices = new AstronautServices();
              //ifall det behövs ändringar av AstronautServices som kan behövas framöver.
       
            }
        }
    }
