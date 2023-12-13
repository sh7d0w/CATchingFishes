using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CATchingFish
{
    public class Player
    {
        private Button player1Score;

        public int PlayerScore { get; set; }
        public Button PlayerScoreBoard { get; set; }

        public Player(int playerScore, Button playerScoreBoard)
        {
            PlayerScore = playerScore;
            PlayerScoreBoard = playerScoreBoard;
        }

        public Player()
        {
        }

        // Getters and Setters
        public int GetPlayerScore()
        {
            return PlayerScore;
        }
        public Button GetPlayerScoreBoard()
        {
            return PlayerScoreBoard;
        }

        public void SetPlayerScore(int value)
        {
            PlayerScore = value;
        }

        public void SetPlayerScoreBoard(Button value)
        {
            PlayerScoreBoard = value;
        }

        public void SetScoreBoardText(string value)
        {
            PlayerScoreBoard.Text = value;
        }

        public void ScoreControl(Food f)
        {

            if (!f.FillFishesInthePlate.Enabled && f.GetFish().Visible)
            {
                PlayerScore++;
                SetScoreBoardText(PlayerScore.ToString());

                f.FillFishesInthePlate.Start();
                f.SetVisibleFish(false);
            }
            else if (!f.FillFishesInthePlate.Enabled && !f.GetFish().Visible)
            {
                PlayerScore--;
                if (PlayerScore < 0) SetScoreBoardText("-" + (Math.Abs(PlayerScore).ToString()));
                else SetScoreBoardText(PlayerScore.ToString());

                f.FillFishesInthePlate.Start();
                f.SetVisibleBone(false);
            }
            else
            {
            }

        }

        // self check if the player score is 3 and show congratulations message box and stop the game
        public void CheckPlayerScore()
        {
            if (PlayerScore == 3)
            {
                MessageBox.Show("Congratulations! You have won the game!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

    }
}
