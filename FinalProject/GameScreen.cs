using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FinalProject
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys
        Boolean leftArrowDown, rightArrowDown, upArorrowDown, downArrowDown, exitButtonDown;
        SolidBrush gameBrush = new SolidBrush(Color.DarkRed);
        List<MonsterClass> monsters = new List<MonsterClass>();
        List<Block> blocks = new List<Block>();
        int levleBlocX = 5;
        int levleBlocY = 40;
        int x = 120;
        int y = 120;
        int lives; 
        public  Random random = new Random();
        public Image heroImage = Properties.Resources.MainCharecter;
        public Image zombie = Properties.Resources.Zombie;
        public Image ghost = Properties.Resources.Ghost;
        public Image vampire = Properties.Resources.Vampire;
        Hero hero = new Hero(5,5,10,22,7,1);
        SoundPlayer player = new SoundPlayer(Properties.Resources.creepy_background_daniel_simon);
        SoundPlayer dead = new SoundPlayer(Properties.Resources.Piano_brokencrash_Brandondorf_1164520478); 
        public GameScreen()
        {
            InitializeComponent();
            OnStart(); 
        }

        public void OnStart()
        {
            lives = 1;
            MonsterClass m = new MonsterClass(30,120, 20, 7, zombie);
            MonsterClass m1 = new MonsterClass(600, 340, 20, -7, vampire);
            MonsterClass m2 = new MonsterClass(30, 410, 20, 7, ghost); 
            monsters.Add(m);
            monsters.Add(m1);
            monsters.Add(m2);
            player.Play();
        }

    
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArorrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Escape:
                    exitButtonDown = true;
                    break; 
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArorrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Escape:
                    exitButtonDown = false;
                    break;

            }
        }

        private void GameScreen_Enter(object sender, EventArgs e)
        {
            leftArrowDown = rightArrowDown = upArorrowDown = downArrowDown = false;
            Gametimer.Enabled = true; 
        }

        private void Gametimer_Tick(object sender, EventArgs e)
        {
            Form1.timer++;
            x = hero.x;
            y = hero.y;
           
         
            //update hero location 
            if (leftArrowDown)
            {
                hero.Move("left");
            }
            if (rightArrowDown)
            {
                hero.Move("right");
            }
            if (upArorrowDown)
            {
                hero.Move("up");
            }
            if (downArrowDown)
            {
                hero.Move("down");
            }
            // monster movement 
            foreach (MonsterClass m in monsters)
            {
                m.Move(); 
                if (m.x > 400)
                {
                    m.speed = -7; 
                }
                else if (m.x < 10)
                {
                    m.speed = 7; 
                }
            }
            //see if exit button is pressed 
            if (exitButtonDown)
            {
                Gametimer.Enabled = false;
                Form f = this.FindForm(); 
                PauseScreen cs = new PauseScreen();
                f.Controls.Add(cs);
                cs.BringToFront(); 
            }
            Rectangle heroRec = new Rectangle(hero.x, hero.y, hero.width, hero.height);
            foreach (Block b in blocks)
            {
                Rectangle block = new Rectangle(b.x, b.y, b.width, b.height);
                if (heroRec.IntersectsWith(block))
                {
                    rightArrowDown = false;
                    leftArrowDown = false;
                    upArorrowDown = false;
                    downArrowDown = false;
                    hero.x = x;
                    hero.y = y;
                 

                }
           
            }
            foreach (MonsterClass monster in monsters)

            {
                Rectangle monstRect = new Rectangle(monster.x, monster.y, monster.size, monster.size); 
                if (heroRec.IntersectsWith(monstRect))
                {
                    dead.Play(); 
                    lives--;
                    
                    GameOverScreen cs = new GameOverScreen();

                    Form f = this.FindForm();

                    f.Controls.Remove(this);
                    f.Controls.Add(cs);
                    Gametimer.Enabled = false;

                    return; 
                }
            }
            Win(); 
            Refresh();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //Spawning the maze blocks 
            Block newBlock = new Block(levleBlocX, levleBlocY);
            blocks.Add(newBlock);
            Block newBlock2 = new Block(levleBlocX, levleBlocY + 400);
            blocks.Add(newBlock2);
            Block newBlock3 = new Block(levleBlocX -300, levleBlocY + 50);
            blocks.Add(newBlock3);
            Block newBlock4 = new Block(levleBlocX + 400, levleBlocY + 50);
            blocks.Add(newBlock4);
            Block newBlock5 = new Block(levleBlocX, levleBlocY + 100);
            blocks.Add(newBlock5);
            Block newBlock6 = new Block(levleBlocX - 300, levleBlocY + 150);
            blocks.Add(newBlock6);
            Block newBlock7 = new Block(levleBlocX + 400, levleBlocY + 150);
            blocks.Add(newBlock7);
            Block newBlock8 = new Block(levleBlocX + 80, levleBlocY + 200);
            blocks.Add(newBlock8);
            Block newBlock9 = new Block(levleBlocX, levleBlocY + 250);
            blocks.Add(newBlock9);
            Block newBlock10 = new Block(levleBlocX, levleBlocY + 270);
            blocks.Add(newBlock10);
            Block newBlock13 = new Block(levleBlocX + 150, levleBlocY + 330);
            blocks.Add(newBlock13);

        }

        private void Win()
        {
            if (hero.x > 690 && hero.y > 480)
            {
                Gametimer.Enabled = false;
                HighScoreScreen cs = new HighScoreScreen();

                Form f = this.FindForm();

                f.Controls.Remove(this);

                f.Controls.Add(cs);
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            
            //Drawing the Hero, Monsters, and Blocks
            foreach (Block b in blocks)
            {
                e.Graphics.FillRectangle(gameBrush, b.x, b.y, b.width, b.height);
            }
            foreach (MonsterClass m in monsters)
            {
                e.Graphics.DrawImage(m.image, m.x, m.y); 
            }
            foreach (MonsterClass m1 in monsters)
            {
                e.Graphics.DrawImage(m1.image, m1.x, m1.y);
            }
            foreach (MonsterClass m2 in monsters)
            {
                e.Graphics.DrawImage(m2.image, m2.x, m2.y); 
            }
            e.Graphics.DrawImage(heroImage, hero.x, hero.y, hero.width, hero.height);
        }

       

    }
}
