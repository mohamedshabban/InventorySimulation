using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTesting;
using InventoryModels;

namespace InventorySimulation
{
    public partial class Inverntory_Problem : Form
    {
        public Inverntory_Problem()
        {
            InitializeComponent();
        }

        SimulationSystem sys;
        private void Inverntory_Problem_Load(object sender, EventArgs e)
        {
            sys = new SimulationSystem();
        }

        private void rd_data_Click(object sender, EventArgs e)
        {
            Inputs_Read File_Obj = new Inputs_Read();

            sys = File_Obj.Read_fromFile();

            MessageBox.Show("Done");
        }

        private void run_program_Click(object sender, EventArgs e)
        {
            Simulate sim = new Simulate(sys);
            sys.SimulationTable = sim.get_table();
            sys.PerformanceMeasures = sim.get_perfomances();

            MessageBox.Show("Done");
        }

        private void show_outputs_Click(object sender, EventArgs e)
        {
            Ending_avg.Text = sys.PerformanceMeasures.EndingInventoryAverage.ToString();
            shortage_avg.Text = sys.PerformanceMeasures.ShortageQuantityAverage.ToString();

            sim_table.DataSource = sys.SimulationTable;

            string testing = TestingManager.Test(sys, Constants.FileNames.TestCase2);
            MessageBox.Show(testing);
        }
    }
}
