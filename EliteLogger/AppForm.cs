using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteLogger
{
    public partial class AppForm : Form
    {
        // Reference to model class 

        private EliteModel model;

        private List<SysObj> startSystems;
        private List<SysObj> endSystems;

        
        public AppForm()
        {
            InitializeComponent();
            model = new EliteModel();
            model.generateData();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            
            // Splashscreen show

            SplashScreen splash = new SplashScreen();
            splash.Show();

            
            // Setup combobox data

            // *Trade tab* 

            // System combobox data

            startSystems = new List<SysObj>(model.getSystems());
            startSystemCombo.DataSource = startSystems;
            startSystemCombo.DisplayMember = "Name";

            endSystems = new List<SysObj>(model.getSystems());
            endSystemCombo.DataSource = endSystems;
            endSystemCombo.DisplayMember = "Name";

            // Commodities combobox data

            commodityCombo.DataSource = model.getCommodities();

            // *Bounty tab*

            bountyCombo.DataSource = model.getSystems();
            bountyCombo.DisplayMember = "Name";

            // Splashscreen close
            splash.Close();

            
        }

        private void startSystemCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate start station combobox

            var startStations = model.getStations();
            SysObj currentStartSystem = (SysObj)startSystemCombo.SelectedItem;
            var filteredStations = startStations.FindAll(id => id.system_id.Equals(currentStartSystem.id));

            bool isEmpty = !filteredStations.Any();

            if (isEmpty)
            {

                startStationCombo.DataSource = null;
                startStationCombo.Text = "== NONE FOUND ==";


            }

            else
            {

                startStationCombo.DataSource = filteredStations;
                startStationCombo.DisplayMember = "Name";

            }
            
        }

        private void endSystemCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate end station combobox

            var startStations = model.getStations();
            SysObj currentStartSystem = (SysObj)endSystemCombo.SelectedItem;
            var filteredStations = startStations.FindAll(id => id.system_id.Equals(currentStartSystem.id));

            bool isEmpty = !filteredStations.Any();

            if (isEmpty)
            {

                endStationCombo.DataSource = null;
                endStationCombo.Text = "== NONE FOUND ==";


            }

            else
            {

                endStationCombo.DataSource = filteredStations;
                endStationCombo.DisplayMember = "Name";

            }
            
        }
    }
}


