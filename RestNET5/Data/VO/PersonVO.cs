using RestNET5.Hypermedia;
using RestNET5.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestNET5.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public bool Enabled { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
