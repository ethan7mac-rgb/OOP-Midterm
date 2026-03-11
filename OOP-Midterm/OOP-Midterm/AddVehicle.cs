using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Midterm
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }
        //Accidentally clicked these ignore :)
        private void radElectric_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radGas_CheckedChanged(object sender, EventArgs e)
        {
        }
        
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            //makes generic vehicle and gets our values from text boxes
            Vehicle CurrentVehicle;
            string make = txtMake.Text;
            string model = txtModel.Text;
            int year = Convert.ToInt32(txtYear.Text);
            //checks which rad was chosen and makes CurrentVehicle a object of that type
            if (radElectric.Checked)
            {
                CurrentVehicle = new ElectricCar(make, model, year);
            }
            else if (radGas.Checked)
            {
                CurrentVehicle = new GasCar(make, model, year);
            }
            else
            {
                //Little error handling incase you dont pick one
                MessageBox.Show("Please Select a Vehicle type!");
                return;
            }
            //Tells you the fuel efficiency and sends the object to form1
            double fuelEff = CurrentVehicle.CaculateFuelEfficiency();
            string mBoxString = $"Fuel Efficiency: {fuelEff}";
            MessageBox.Show(mBoxString);
            Tag = CurrentVehicle;
            this.Close();
        }
    }
}
