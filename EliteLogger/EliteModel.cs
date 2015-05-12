using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EliteLogger
{
    class EliteModel
    {
        private List<SysObj> systemList;
        private List<StationObj> stationList;

        public EliteModel()
        {

            systemList = new List<SysObj>();
            stationList = new List<StationObj>();

        }

        // Load .json files, convert to appropriate object types and save as binary

        public void generateData()
        {

            // Reader local var

            StreamReader reader;
           
            // Generate SysObj's from systems.json

            reader = new StreamReader("systems.json"); // local access until URL defined
            string json = reader.ReadToEnd();
            systemList = JsonConvert.DeserializeObject<List<SysObj>>(json);

            // Generate StationObj's from stations.json

            reader = new StreamReader("stations.json"); // local access until URL defined
            string stationJson = reader.ReadToEnd();
            stationList = JsonConvert.DeserializeObject<List<StationObj>>(stationJson);

        }

        // Get systems method for populating comboboxes
        
        public List<SysObj> getSystems()
        {
            return this.systemList;
        }

        // get stations methods for populating comboboxes

        public List<StationObj> getStations()
        {
            return this.stationList;
        }

        // Parse commodities.txt and return List

        public List<string> getCommodities()
        {

            List<string> commodities = new List<string>();

            using (StreamReader r = new StreamReader("commodities.txt"))
            {

                string line;
                while ((line = r.ReadLine()) != null)
                {

                    commodities.Add(line.Substring(1, line.Length - 2));
                }
            }

            // Sort list & return

            commodities.Sort();
            return commodities;
        }

    }
}

