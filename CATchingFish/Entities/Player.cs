using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATchingFish
{
    internal class Player
    {
        // Score of the player
        private int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        // Score control method
        public void ScoreControl(ref int PlayerGOTFish, Button ScoreBoard)
        {
            // Check FillFishesInThePlate timer is running or DisappearFoodOnPlate timer is running
            // If FillFishesInThePlate timer is running, then score++
            // If DisappearFoodOnPlate timer is running, then score--
            if (!(FillFishesInthePlate.Enabled) && Fishes.Visible)
            {
                // Score++
                PlayerGOTFish++;
                ScoreBoard.Text = PlayerGOTFish.ToString();

                // Start the timer to fill the plate with fishes again
                FillFishesInthePlate.Start();
                Fishes.Visible = false;
            }
            else if (!FillFishesInthePlate.Enabled && !Fishes.Visible)
            {
                // Score--
                PlayerGOTFish--;
                if (PlayerGOTFish < 0) ScoreBoard.Text = "-" + (Math.Abs(PlayerGOTFish).ToString());
                else ScoreBoard.Text = PlayerGOTFish.ToString();
                FillFishesInthePlate.Start();
                Bone.Visible = false;
            }
            else
            {
                // Do nothing
            }
            if (PlayerGOTFish == 3)
            {
                // Stop the game
                FillFishesInthePlate.Stop();
                NoFishesInthePlate.Stop();
                panelTimer.Stop();

                // Show the winner message
                if (ScoreBoard == Player1Score)
                {
                    MessageBox.Show("Player 1 wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ScoreBoard == Player2Score)
                {
                    MessageBox.Show("Player 2 wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ScoreBoard == Player3Score)
                {
                    MessageBox.Show("Player 3 wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ScoreBoard == Player4Score)
                {
                    MessageBox.Show("Player 4 wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Do nothing
                }
                // Close the game

                Close();
            }
            else
            {
                // Do nothing
            }
        }
    }
}
