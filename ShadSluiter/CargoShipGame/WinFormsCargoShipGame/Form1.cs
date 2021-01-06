using LibCargoShip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCargoShipGame
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateUI()
        {
            // Match controlls to the ships properties
            progressBar1.Maximum = ship.Capacity;

            if (ship.GetShipLoad() <= ship.Capacity)
                progressBar1.Value = ship.GetShipLoad();

            label_shipLabel.Text = ship.ToString();
            label_cycleCount.Text = ship.CycleCount.ToString();
            label_carCount.Text = ship.CarCount.ToString();
            label_truckCount.Text = ship.TruckCount.ToString();
            label_trainCarCount.Text = ship.TrainCarCount.ToString();

            if (ship.OverUnder() == 0)
            {
                progressBar1.ForeColor = Color.Green;
            }
            else if (ship.OverUnder() > 0)
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            else if (ship.OverUnder() < 0)
            {
                progressBar1.ForeColor = Color.Red;
            }
        }

        private void btn_newShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            UpdateUI();
        }

        private void track_motorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycles.Value;
            UpdateUI();
        }

        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_cars.Value;
            UpdateUI();
        }

        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_trucks.Value;
            UpdateUI();
        }

        private void track_trainCars_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_trainCars.Value;
            UpdateUI();
        }
    }
}
