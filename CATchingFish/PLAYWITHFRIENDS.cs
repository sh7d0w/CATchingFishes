using System;
using System.Media;
using System.Security.Policy;
using System.Windows.Forms;
using CATchingFish.Properties;

namespace CATchingFish
{
    public partial class PLAYWITHFRIENDS : Form
    {
        private Timer panelTimer; // Timer to make the panel invisible after 2 seconds

        public PLAYWITHFRIENDS()
        {
            InitializeComponent();
            // Add the timer and set its properties
            panelTimer = new Timer();
            panelTimer.Interval = 350;
            // Add the event handler for the timer
            panelTimer.Tick += PanelTimer_Tick;
            // Play background music
            LoopMusic();

            Cat1_top_left.setVisiblLongHand(false);
            Cat2_top_right.setVisiblLongHand(false);
            Cat3_bottom_left.setVisiblLongHand(false);
            Cat4_bottom_right.setVisiblLongHand(false);

            //Food
            food.SetVisibleFish(false);
            food.SetVisibleBone(false);

            food.FillFoodOnPlate();
            food.DisappearFoodOnPlate();

        }
        private void LoopMusic()
        {
            string musicFilePath = Application.StartupPath + "\\BGMusic.wav";
            SoundPlayer BGMusic = new SoundPlayer(musicFilePath);
            BGMusic.PlayLooping();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Q)
            {

                Cat1_top_left.SetVisibleShortHand(false);
                Cat1_top_left.setVisiblLongHand(true);

                player1.ScoreControl(food);
                player1.CheckPlayerScore();

                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.E)
            {
                Cat2_top_right.SetVisibleShortHand(false);
                Cat2_top_right.setVisiblLongHand(true);

                player2.ScoreControl(food);
                player2.CheckPlayerScore();

                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.Z)
            {
                Cat3_bottom_left.SetVisibleShortHand(false);
                Cat3_bottom_left.setVisiblLongHand(true);

                player3.ScoreControl(food);
                player3.CheckPlayerScore();


                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.C)
            {
                Cat4_bottom_right.SetVisibleShortHand(false);
                Cat4_bottom_right.setVisiblLongHand(true);
                player4.ScoreControl(food);
                player4.CheckPlayerScore();
                panelTimer.Start();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
                return false;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Timer event handler
        private void PanelTimer_Tick(object sender, EventArgs e)
        {
            panelTimer.Stop(); // Stop the timer
            Cat1_top_left.HandControl(Cat1_top_left.GetShort_Hand(), Cat1_top_left.GetLong_Hand());
            Cat2_top_right.HandControl(Cat2_top_right.GetShort_Hand(), Cat2_top_right.GetLong_Hand());
            Cat3_bottom_left.HandControl(Cat3_bottom_left.GetShort_Hand(), Cat3_bottom_left.GetLong_Hand());
            Cat4_bottom_right.HandControl(Cat4_bottom_right.GetShort_Hand(), Cat4_bottom_right.GetLong_Hand());
        }




    }
}
