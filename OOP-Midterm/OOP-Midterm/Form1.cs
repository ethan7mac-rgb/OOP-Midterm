using System.Runtime.InteropServices.Marshalling;

namespace OOP_Midterm
{
    public partial class Form1 : Form
    {
        //declare global list called cars
        List<Vehicle> cars = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
        }
        //opens the add vehicle form and pulls the object it makes out of it
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.ShowDialog();
            cars.Add((Vehicle)addVehicle.Tag);
            UpdateList();
        }
        //removes a vehicle thats selectes from our cars list
        private void btnRemoveVehicle_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstDisplay.SelectedIndex;
            Vehicle chosenVehicle = cars[selectedIndex];
            cars.RemoveAt(selectedIndex);
            UpdateList();
        }
        //Updates the list box with the list cars
        private void UpdateList()
        {
            lstDisplay.Items.Clear();
            foreach (Vehicle car in cars)
            {
                lstDisplay.Items.Add(car.ToString());
            }
        }
        //charges the battery if you select a electric car
        private void btnChargeBattery_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstDisplay.SelectedIndex;
            Vehicle chosenVehicle = cars[selectedIndex];
            if (chosenVehicle is ElectricCar car)
            {
                string rString = car.ChargeBattery();
                MessageBox.Show(rString);
            }
            UpdateList();
        }
    }
}
