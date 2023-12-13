using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CATchingFish.AutoGenerate;

namespace CATchingFish
{
    public class Food
    {
        // Add the timer and set its properties
        public Timer panelTimer = new Timer(); // Timer to make the panel invisible after 2 seconds

        public Timer FillFishesInthePlate = new Timer(); // Timer to fill the plate with fishes

        public Timer NoFishesInthePlate = new Timer(); // Timer to make the fishes disappear from the plate
        public Panel Fishes, Bones;

        public AutoGenerate autoGenerate = new AutoGenerate();
        // get and set the panel of fishes
        public Panel Fishes1
        {
            get { return Fishes; }
            set { Fishes = value; }
        }
        // get and set the panel of bones
        public Panel Bones1
        {
            get { return Bones; }
            set { Bones = value; }
        }
        public void DisplayFishesOrBone(object sender, EventArgs e)
        {
            object Food = generateRandomFishesOrBone();
            if (Food == Fishes)
            {
                // set fishes in the front of the plate
                Bones.Visible = false;
                Fishes.Visible = true;
                Fishes.BringToFront();
            }
            else
            {
                Fishes.Visible = false;
                Bones.Visible = true;
                Bones.BringToFront();
            }
            FillFishesInthePlate.Stop();
            NoFishesInthePlate.Start();
        }

        public void FillFoodOnPlate() // fill the plate with fishes
        {
            FillFishesInthePlate = new Timer();
            FillFishesInthePlate.Interval = autoGenerate.generateRandomNumber(); // generate a random number from 2 to 3 seconds
            FillFishesInthePlate.Tick += DisplayFishesOrBone; // event handler
            FillFishesInthePlate.Start();// start the timer
        }
        public void DisappearFoodOnPlate()
        {
            NoFishesInthePlate = new Timer();
            NoFishesInthePlate.Interval = autoGenerate.generateRandomNumber();
            NoFishesInthePlate.Tick += Disappear;
            NoFishesInthePlate.Start();
        }
        public object generateRandomFishesOrBone() // generate a random number from 0 to 1 to choose between fishes or bone
        {
            Random rnd = new Random();
            object[] Food = { Fishes, Bones };
            int num = rnd.Next(Food.Length);
            return Food[num];
        }
        public void Disappear(object sender, EventArgs e)
        {
            Bones.Visible = false;
            Fishes.Visible = false;
            NoFishesInthePlate.Stop();
            FillFishesInthePlate.Start();
        }
    }
}
