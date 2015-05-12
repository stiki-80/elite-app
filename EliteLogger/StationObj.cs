using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EliteLogger
{
    [Serializable]
    public class StationObj
    {
        public int id { get; set; }
        public string name { get; set; }
        public int system_id { get; set; }
        public string max_landing_pad_size { get; set; }
        public int? distance_to_star { get; set; }
        public string faction { get; set; }
        public object government { get; set; }
        public object allegiance { get; set; }
        public object state { get; set; }
        public string type { get; set; }
        public int? has_blackmarket { get; set; }
        public int? has_commodities { get; set; }
        public object has_refuel { get; set; }
        public object has_repair { get; set; }
        public object has_rearm { get; set; }
        public object has_outfitting { get; set; }
        public object has_shipyard { get; set; }
        public List<object> import_commodities { get; set; }
        public List<object> export_commodities { get; set; }
        public List<object> prohibited_commodities { get; set; }
        public List<object> economies { get; set; }
        public int updated_at { get; set; }

        public override string ToString()
        {
            String stationID = system_id + name;
            return stationID;

        }
    }
}
