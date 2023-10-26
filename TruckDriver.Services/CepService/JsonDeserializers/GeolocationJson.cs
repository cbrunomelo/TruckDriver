using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Services.CepService.JsonDeserializers
{

    internal class Feature
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<double> bbox { get; set; }
        public Geometry geometry { get; set; }
    }

    internal class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    internal class Properties
    {
        public int place_id { get; set; }
        public string osm_type { get; set; }
        public int osm_id { get; set; }
        public int place_rank { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public double importance { get; set; }
        public string addresstype { get; set; }
        public string name { get; set; }
        public string display_name { get; set; }
    }

    internal class GeolocationJson
    {
        public string type { get; set; }
        public string licence { get; set; }
        public List<Feature> features { get; set; }
    }


}
