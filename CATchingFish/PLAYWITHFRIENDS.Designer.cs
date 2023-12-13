using CATchingFish.Entities;

namespace CATchingFish
{
    public partial class PLAYWITHFRIENDS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLAYWITHFRIENDS));
            
            this.Table = new System.Windows.Forms.TableLayoutPanel(); // Table layout panel
            this.Table.SuspendLayout();

            this.FirstHandPanel = new System.Windows.Forms.Panel(); //Short hand
            this.SecondHand = new System.Windows.Forms.Panel(); //Short hand
            this.ThirdHand = new System.Windows.Forms.Panel(); //Short hand
            this.FourthHand = new System.Windows.Forms.Panel(); 

            this.FirstLongHand = new System.Windows.Forms.Panel(); 
            this.SecondLongHand = new System.Windows.Forms.Panel();
            this.ThirdLongHand = new System.Windows.Forms.Panel();
            this.FourthLongHand = new System.Windows.Forms.Panel();
          
            this.Plate = new System.Windows.Forms.Panel();
            this.Bone = new System.Windows.Forms.Panel();
            this.Fishes = new System.Windows.Forms.Panel();
            
            this.Player1Score = new System.Windows.Forms.Button();
            this.Player2Score = new System.Windows.Forms.Button();
            this.Player4Score = new System.Windows.Forms.Button();
            this.Player3Score = new System.Windows.Forms.Button();
            
            this.Plate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.ColumnCount = 5;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));

            this.Table.Controls.Add(this.FirstHandPanel, 0, 0);
            this.Table.Controls.Add(this.SecondHand, 4, 0);
            this.Table.Controls.Add(this.ThirdHand, 0, 2);
            this.Table.Controls.Add(this.FourthHand, 4, 2);
            
            
            this.Table.Controls.Add(this.Player1Score, 1, 0);
            this.Table.Controls.Add(this.Player2Score, 3, 0);
            this.Table.Controls.Add(this.Player4Score, 3, 2);
            this.Table.Controls.Add(this.Player3Score, 1, 2);

            this.Table.Controls.Add(this.Plate, 2, 1);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 3;
            this.Table.Size = new System.Drawing.Size(971, 595);
            this.Table.TabIndex = 1;

            // 
            // FirstHandPanel-------------------------
            // 
            this.FirstHandPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstHandPanel.BackgroundImage")));
            this.FirstHandPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FirstHandPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirstHandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstHandPanel.Location = new System.Drawing.Point(0, 0);
            this.FirstHandPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FirstHandPanel.Name = "FirstHandPanel";
            this.FirstHandPanel.Size = new System.Drawing.Size(194, 198);
            this.FirstHandPanel.TabIndex = 4;
            // 
            // FirstLongHand
            // 
            this.FirstLongHand.BackColor = System.Drawing.Color.Transparent;
            this.FirstLongHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstLongHand.BackgroundImage")));
            this.FirstLongHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirstLongHand.Location = new System.Drawing.Point(3, 0);
            this.FirstLongHand.Name = "FirstLongHand";
            this.FirstLongHand.Size = new System.Drawing.Size(467, 300);
            this.FirstLongHand.TabIndex = 7;

            this.Cat1_top_left = new Cat(FirstHandPanel, FirstLongHand);
            // 
            // SecondHand---------------------
            // 
            this.SecondHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondHand.BackgroundImage")));
            this.SecondHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SecondHand.Dock = System.Windows.Forms.DockStyle.Right;
            this.SecondHand.Location = new System.Drawing.Point(776, 0);
            this.SecondHand.Margin = new System.Windows.Forms.Padding(0);
            this.SecondHand.Name = "SecondHand";
            this.SecondHand.Size = new System.Drawing.Size(195, 198);
            this.SecondHand.TabIndex = 5;
            // 
            // SecondLongHand
            // 
            this.SecondLongHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondLongHand.BackColor = System.Drawing.Color.Transparent;
            this.SecondLongHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondLongHand.BackgroundImage")));
            this.SecondLongHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SecondLongHand.Location = new System.Drawing.Point(499, 0);
            this.SecondLongHand.Name = "SecondLongHand";
            this.SecondLongHand.Size = new System.Drawing.Size(472, 300);
            this.SecondLongHand.TabIndex = 7;

            this.Cat2_top_right = new Cat(SecondHand, SecondLongHand);
            // 
            // ThirdHand----------------------------
            // 
            this.ThirdHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThirdHand.BackgroundImage")));
            this.ThirdHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ThirdHand.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThirdHand.Location = new System.Drawing.Point(3, 399);
            this.ThirdHand.Name = "ThirdHand";
            this.ThirdHand.Size = new System.Drawing.Size(188, 193);
            this.ThirdHand.TabIndex = 3;
            // 
            // ThirdLongHand
            // 
            this.ThirdLongHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThirdLongHand.BackColor = System.Drawing.Color.Transparent;
            this.ThirdLongHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThirdLongHand.BackgroundImage")));
            this.ThirdLongHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThirdLongHand.Location = new System.Drawing.Point(0, 306);
            this.ThirdLongHand.Name = "ThirdLongHand";
            this.ThirdLongHand.Size = new System.Drawing.Size(470, 289);
            this.ThirdLongHand.TabIndex = 7;

            this.Cat3_bottom_left = new Cat(ThirdHand, ThirdLongHand);

            // 
            // FourthHand-----------------------------------------
            // 
            this.FourthHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FourthHand.BackgroundImage")));
            this.FourthHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FourthHand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourthHand.Location = new System.Drawing.Point(779, 399);
            this.FourthHand.Name = "FourthHand";
            this.FourthHand.Size = new System.Drawing.Size(189, 193);
            this.FourthHand.TabIndex = 4;
            // 
            // FourthLongHand
            // 
            this.FourthLongHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FourthLongHand.BackColor = System.Drawing.Color.Transparent;
            this.FourthLongHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FourthLongHand.BackgroundImage")));
            this.FourthLongHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FourthLongHand.Location = new System.Drawing.Point(499, 306);
            this.FourthLongHand.Name = "FourthLongHand";
            this.FourthLongHand.Size = new System.Drawing.Size(472, 289);
            this.FourthLongHand.TabIndex = 7;
            
            this.Cat4_bottom_right = new Cat(FourthHand, FourthLongHand);

            // 
            // Plate-------------------------------
            // 
            this.Plate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Plate.BackgroundImage")));
            this.Plate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Plate.Controls.Add(this.Bone);
            this.Plate.Controls.Add(this.Fishes);
            this.Plate.Location = new System.Drawing.Point(391, 201);
            this.Plate.Name = "Plate";
            this.Plate.Size = new System.Drawing.Size(188, 192);
            this.Plate.TabIndex = 6;
            // 
            // Bone
            // 
            this.Bone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bone.BackgroundImage")));
            this.Bone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bone.Location = new System.Drawing.Point(0, 0);
            this.Bone.Name = "Bone";
            this.Bone.Size = new System.Drawing.Size(188, 192);
            this.Bone.TabIndex = 1;
            // 
            // Fishes
            // 
            this.Fishes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fishes.BackgroundImage")));
            this.Fishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fishes.Location = new System.Drawing.Point(0, 0);
            this.Fishes.Name = "Fishes";
            this.Fishes.Size = new System.Drawing.Size(188, 192);
            this.Fishes.TabIndex = 0;
            
            this.food = new Food(Fishes, Bone);
            
            // 
            // Player1Score-------------------
            // 
            this.Player1Score.BackColor = System.Drawing.Color.Transparent;
            this.Player1Score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player1Score.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Score.ForeColor = System.Drawing.Color.Red;
            this.Player1Score.Location = new System.Drawing.Point(197, 3);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(97, 61);
            this.Player1Score.TabIndex = 7;
            this.Player1Score.Text = "0";
            this.Player1Score.UseVisualStyleBackColor = false;

            this.player1 = new Player(0, Player1Score);
            // 
            // Player2Score
            // 
            this.Player2Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2Score.BackColor = System.Drawing.Color.Transparent;
            this.Player2Score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player2Score.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Score.ForeColor = System.Drawing.Color.DarkOrange;
            this.Player2Score.Location = new System.Drawing.Point(676, 3);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(97, 61);
            this.Player2Score.TabIndex = 8;
            this.Player2Score.Text = "0";
            this.Player2Score.UseVisualStyleBackColor = false;

            this.player2 = new Player(0, Player2Score);
            // 
            // Player3Score
            // 
            this.Player3Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player3Score.BackColor = System.Drawing.Color.Transparent;
            this.Player3Score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player3Score.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3Score.ForeColor = System.Drawing.Color.Green;
            this.Player3Score.Location = new System.Drawing.Point(197, 531);
            this.Player3Score.Name = "Player3Score";
            this.Player3Score.Size = new System.Drawing.Size(97, 61);
            this.Player3Score.TabIndex = 10;
            this.Player3Score.Text = "0";
            this.Player3Score.UseVisualStyleBackColor = false;

            this.player3 = new Player(0, Player3Score);
            // 
            // Player4Score
            // 
            this.Player4Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player4Score.BackColor = System.Drawing.Color.Transparent;
            this.Player4Score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player4Score.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4Score.ForeColor = System.Drawing.Color.Blue;
            this.Player4Score.Location = new System.Drawing.Point(676, 531);
            this.Player4Score.Name = "Player4Score";
            this.Player4Score.Size = new System.Drawing.Size(97, 61);
            this.Player4Score.TabIndex = 9;
            this.Player4Score.Text = "0";
            this.Player4Score.UseVisualStyleBackColor = false;

            this.player4 = new Player(0,Player4Score);
            
            // 
            // PLAYWITHFRIENDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 595);

            this.Controls.Add(this.Cat1_top_left.GetLong_Hand());
            this.Controls.Add(this.SecondLongHand);
            this.Controls.Add(this.ThirdLongHand);
            this.Controls.Add(this.FourthLongHand);
            this.Controls.Add(this.Table);
            
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PLAYWITHFRIENDS";
            this.Text = "PLAY WITH FRIENDS";
            this.Table.ResumeLayout(false);
            this.Plate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;

        private Cat Cat1_top_left;
        private Cat Cat2_top_right;
        private Cat Cat3_bottom_left;
        private Cat Cat4_bottom_right;

        private Food food;

        private Player player1;
        private Player player2;
        private Player player3;
        private Player player4;

        private System.Windows.Forms.Panel FirstHandPanel;
        private System.Windows.Forms.Panel SecondHand;
        private System.Windows.Forms.Panel ThirdHand;
        private System.Windows.Forms.Panel FourthHand;

        private System.Windows.Forms.Panel FirstLongHand;
        private System.Windows.Forms.Panel SecondLongHand;
        private System.Windows.Forms.Panel ThirdLongHand;
        private System.Windows.Forms.Panel FourthLongHand;

        private System.Windows.Forms.Panel Plate;
        private System.Windows.Forms.Panel Bone;
        private System.Windows.Forms.Panel Fishes;
        
        private System.Windows.Forms.Button Player1Score;
        public System.Windows.Forms.Button Player2Score;
        public System.Windows.Forms.Button Player3Score;
        private System.Windows.Forms.Button Player4Score;
    }
}

