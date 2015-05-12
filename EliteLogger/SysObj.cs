using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteLogger
{

    [Serializable]
    public class SysObj
    {
        public int id { get; set; }
        public string name { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public string faction { get; set; }
        public object population { get; set; }
        public object government { get; set; }
        public string allegiance { get; set; }
        public object state { get; set; }
        public object security { get; set; }
        public object primary_economy { get; set; }
        public string needs_permit { get; set; }
        public int updated_at { get; set; }

        public SysObj() { }

        public override string ToString()
        {
            String readme = id + ", " + name + " | " + "x coord: " + x + "y coord: " + y + "z coord" + z + "need permit? " + needs_permit;
            return readme;

        }
    }
}
