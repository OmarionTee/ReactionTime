using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReactionTime
{
    public partial class Form1 : Form
    {

        Random random = new Random(); // Generates random delay time
        Stopwatch stopwatch = new Stopwatch(); // Measures reaction speed
        Timer gameTimer = new Timer(); // Controls when the button turns green
        bool waitingForClick = false; // True when player has started a round (button is red)
        bool canClick = false; // True when button is green and valid to click

        public Form1()
        {
            InitializeComponent();
            gameTimer.Tick += GameTimer_Tick;
        }

        private void Reaction_Button_MouseClick(object sender, MouseEventArgs e)
        {
            // If button is green and player clicked in time
            if (canClick)
            {
                stopwatch.Stop(); // Stop measuring time         
                Reaction_Button.Text = $"Your time: {stopwatch.ElapsedMilliseconds} ms\nClick to try again"; // Show reaction time in milliseconds
                Reaction_Button.BackColor = Color.Blue; // Reset background colour
                canClick = false; // Not allowed to click until next round
                waitingForClick = false; // Round is over 
            } 
            else
            {
                // If player clicks while waiting (button is red)
                if (waitingForClick)
                {
                    gameTimer.Stop(); // Stop timer 
                    Reaction_Button.Text = "Too early!\nTry again."; // Early click message
                    Reaction_Button.BackColor = Color.Blue; // Reset background colour
                    waitingForClick = false; // Reset round 
                }
                else
                {
                    // Start a new round

                    Reaction_Button.BackColor = Color.Red; // Show waiting state 
                    int delay = random.Next(2000, 5000); // Random delay (2–5 seconds) so user can't predict when to click
                    gameTimer.Interval = delay; // Set timer delay 
                    gameTimer.Start(); // Start countdown 
                    waitingForClick = true; // Now waiting for green 
                    Reaction_Button.Text = "Wait for green..."; 
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTimer.Stop(); // Stop timer once triggered
            Reaction_Button.BackColor = Color.Green; // Signal player to click
            stopwatch.Restart(); // Start measuring reaction time
            canClick = true; // Now player is allowed to click
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reaction_Button_KeyPress(object sender, KeyPressEventArgs e)
        {

            // If button is green and player clicked in time
            if (canClick)
            {
                stopwatch.Stop(); // Stop measuring time         
                Reaction_Button.Text = $"Your time: {stopwatch.ElapsedMilliseconds} ms\nClick to try again"; // Show reaction time in milliseconds
                Reaction_Button.BackColor = Color.Blue; // Reset background colour
                canClick = false; // Not allowed to click until next round
                waitingForClick = false; // Round is over 
            }
            else
            {
                // If player clicks while waiting (button is red)
                if (waitingForClick)
                {
                    gameTimer.Stop(); // Stop timer 
                    Reaction_Button.Text = "Too early!\nTry again."; // Early click message
                    Reaction_Button.BackColor = Color.Blue; // Reset background colour
                    waitingForClick = false; // Reset round 
                }
                else
                {
                    // Start a new round

                    Reaction_Button.BackColor = Color.Red; // Show waiting state 
                    int delay = random.Next(2000, 5000); // Random delay (2–5 seconds) so user can't predict when to click
                    gameTimer.Interval = delay; // Set timer delay 
                    gameTimer.Start(); // Start countdown 
                    waitingForClick = true; // Now waiting for green 
                    Reaction_Button.Text = "Wait for green...";
                }
            }

        }
    }
}