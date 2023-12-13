using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATchingFish
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
                                    

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PLAYWITHFR_btn_Click(object sender, EventArgs e)
        {
            PLAYWITHFRIENDS playwithfriends = new PLAYWITHFRIENDS();
            playwithfriends.Show();
            this.Hide();

        }

        private void PLAYWITHTEAM_btn_Click(object sender, EventArgs e)
        {
            PLAYWITHTEAM playwitTeam = new PLAYWITHTEAM();
            playwitTeam.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContainerBTN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
