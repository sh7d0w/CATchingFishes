using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATchingFish
{
    public class Food
    {
        Food() { }

        public Timer FillFishesInthePlate = new Timer(); // Timer to fill the plate with fishes
        public Timer NoFishesInthePlate = new Timer(); // Timer to make the fishes disappear from the plate

        private Panel fish;
        private Panel bone;

        public Food(Panel fish, Panel bone)
        {
            SetFish(fish);
            SetBone(bone);
        }

        public Panel GetFish()
        {
            return fish;
        }
        public Panel GetBone()
        {
            return bone;
        }

        public void SetFish(Panel value)
        {
            fish = value;
        }

        public void SetBone(Panel value)
        {
            bone = value;
        }

        public void SetVisibleFish(bool value)
        {
            fish.Visible = value;
        }
        public void SetVisibleBone(bool value)
        {
            bone.Visible = value;
        }

        public void FoodControl(Panel Fish, Panel Bone)
        {
            Fish.Visible = true;
            Bone.Visible = false;
        }

        public void BringFishToFront(Panel Fish)
        {
            Fish.BringToFront();
        }

        public void BringBoneToFront(Panel Bone)
        {
            Bone.BringToFront();
        }

        public void FillFoodOnPlate() // fill the plate with fishes
        {
            FillFishesInthePlate = new Timer();
            FillFishesInthePlate.Interval = generateRandomNumber(); // generate a random number from 2 to 3 seconds
            FillFishesInthePlate.Tick += DisplayFishesOrBone; // event handler
            FillFishesInthePlate.Start();// start the timer
        }

        public void DisplayFishesOrBone(object sender, EventArgs e)
        {
            object Food = generateRandomFishesOrBone();
            if (Food == fish)
            {
                SetVisibleBone(false);
                SetVisibleFish(true);
                BringFishToFront(fish);
            }
            else
            {
                SetVisibleFish(false);
                SetVisibleBone(true);
                BringBoneToFront(bone);
            }
            FillFishesInthePlate.Stop();
            NoFishesInthePlate.Start();
        }

        public void DisappearFoodOnPlate()
        {
            NoFishesInthePlate = new Timer();
            NoFishesInthePlate.Interval = generateRandomNumber();
            NoFishesInthePlate.Tick += Disappear;
            NoFishesInthePlate.Start();
        }

        public void Disappear(object sender, EventArgs e)
        {
            SetVisibleBone(false);
            SetVisibleFish(false);
            NoFishesInthePlate.Stop();
            FillFishesInthePlate.Start();
        }




        public object generateRandomFishesOrBone() // generate a random number from 0 to 1 to choose between fishes or bone
        {
            Random rnd = new Random();
            object[] Food = { fish, bone };
            int num = rnd.Next(Food.Length);
            return Food[num];
        }
        public int generateRandomNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(2000, 3500);
            return num;
        }
    }
}
