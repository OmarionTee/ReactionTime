using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReactionTime
{
    public partial class Form1 : Form
    {
        Random random = new Random(); // Generates random delay time
        Stopwatch stopwatch = new Stopwatch(); // Measures elapsed time since green
        Timer gameTimer = new Timer(); // Controls when panels turn green

        bool waitingForGreen = false; // true when waiting (panels are red)
        bool canShoot = false; // true when panels are green and valid to shoot

        long player1Time = -1;
        long player2Time = -1;
        bool player1Shot = false;
        bool player2Shot = false;

        public Form1()
        {
            InitializeComponent();
            gameTimer.Tick += GameTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void StartRound()
        {
            // Set both panels to waiting state (red)
            player1Panel.BackColor = Color.Red;
            player2Panel.BackColor = Color.Red;
            player1Label.Text = "Wait for green...";
            player2Label.Text = "Wait for green...";
            player1Time = -1;
            player2Time = -1;
            player1Shot = false;
            player2Shot = false;
            canShoot = false;
            waitingForGreen = true;

            int delay = random.Next(1500, 4000); // 1.5–4s
            gameTimer.Interval = delay;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTimer.Stop();
            // Turn both panels green and allow shooting
            player1Panel.BackColor = Color.Green;
            player2Panel.BackColor = Color.Green;
            player1Label.Text = "SHOOT!";
            player2Label.Text = "SHOOT!";
            stopwatch.Restart();
            canShoot = true;
            waitingForGreen = false;
        }

        private void EndRound(string resultMessage)
        {
            canShoot = false;
            waitingForGreen = false;
            stopwatch.Reset();

            // Reset visuals after round; show result on labels
            player1Label.Text = resultMessage;
            player2Label.Text = resultMessage;

            // set panels to neutral color so user can start next round by clicking
            player1Panel.BackColor = Color.Blue;
            player2Panel.BackColor = Color.DarkRed;
        }

        private void HandlePlayerInput(int player)
        {
            // If waiting to start (not in an active round), start a new round
            if (!waitingForGreen && !canShoot && !player1Shot && !player2Shot)
            {
                StartRound();
                return;
            }

            // Early shot
            if (waitingForGreen)
            {
                gameTimer.Stop();
                stopwatch.Reset();
                canShoot = false;
                waitingForGreen = false;

                int other = (player == 1) ? 2 : 1;
                string msg = $"Player {player} shot early! Player {other} wins!";
                EndRound(msg);
                return;
            }

            // If panels are green and shooting is allowed
            if (canShoot)
            {
                long time = stopwatch.ElapsedMilliseconds;

                if (player == 1 && !player1Shot)
                {
                    player1Time = time;
                    player1Shot = true;
                    player1Label.Text = $"Time: {player1Time} ms";
                }
                else if (player == 2 && !player2Shot)
                {
                    player2Time = time;
                    player2Shot = true;
                    player2Label.Text = $"Time: {player2Time} ms";
                }

                // If both shot, decide winner
                if ((player1Shot && player2Shot) || (player1Shot && !player2Shot && player == 1 && !player2Shot && player2Time == -1 && player1Shot && !canShoot) == false)
                {
                    // both shot?
                }

                if (player1Shot && player2Shot)
                {
                    canShoot = false;
                    string result;
                    if (player1Time < player2Time)
                    {
                        result = $"Player 1 wins! {player1Time} ms vs {player2Time} ms";
                    }
                    else if (player2Time < player1Time)
                    {
                        result = $"Player 2 wins! {player2Time} ms vs {player1Time} ms";
                    }
                    else
                    {
                        result = $"Tie! Both {player1Time} ms";
                    }
                    EndRound(result);
                }
                else
                {
                            // If only one player shot so far, keep allowing the other to shoot for a short time.
                    // Optionally end after both click; here we allow remaining player to still shoot.
                }
            }
        }

        private void PlayerPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var panel = sender as Panel;
            if (panel == null) return;
            int player = (int)panel.Tag;
            HandlePlayerInput(player);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) // Player 1
            {
                HandlePlayerInput(1);
            }
            else if (e.KeyCode == Keys.L) // Player 2
            {
                HandlePlayerInput(2);
            }
        }
    }
}