using System;
using System.Collections.Generic;
using System.Text;

namespace SofaAppen.Models
{
    public class Event
    {

        public int IdEvent { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public List<EventAnimal> Animals { get; set; }
    }
}
