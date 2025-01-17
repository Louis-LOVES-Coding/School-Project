using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Football_Penalty_Shootout_Game
{
    public partial class Form1 : Form
    {
        // Random object voor willekeurige keeperbewegingen
        Random rnd = new Random();

        // Posities waar de keeper kan staan
        List<string> keeperPosition = new List<string> { "left", "right", "top", "topLeft", "topRight" };

        // Lijst van doelwitten (de vijf verschillende doelplaatsen)
        List<PictureBox> goalTarget;

        // Variabelen voor het spel
        int ballX = 0;
        int ballY = 0;
        int goal = 0;
        int miss = 0;
        string state;
        string playerTarget;
        bool aimset = false;
        bool shotProcessed = false;

        // Geluidsobjecten voor het doelpunt en misser
        private SoundPlayer goalSound;
        private SoundPlayer missSound;

        // Timer om het geluid na een paar seconden te stoppen
        private Timer stopSoundTimer;
        private bool isGoalSoundPlaying = false;

        // Interval van de timers, verandert de snelheid van de animaties
        private const int TimerInterval = 30;

        public Form1()
        {
            InitializeComponent();

            // Initialiseer doelwitten
            goalTarget = new List<PictureBox> { left, right, top, topLeft, topRight };

            // Zet tags voor doelwitten om te herkennen waar de speler heeft geschoten
            left.Tag = "left";
            right.Tag = "right";
            top.Tag = "top";
            topLeft.Tag = "topLeft";
            topRight.Tag = "topRight";

            // Voeg event handlers toe voor de klikbare doelwitten
            foreach (var target in goalTarget)
            {
                target.Click += new EventHandler(SetGoalTargetEvent);
                target.Visible = true;
            }

            // Zet de timers en hun interval
            ballTimer.Tick += BallTimerEvent;
            KeeperTimer.Tick += KeeperTimerEvent;
            ballTimer.Interval = TimerInterval;
            KeeperTimer.Interval = TimerInterval;

            // Laad de geluiden voor doelpunt en misser
            LoadGoalSound();
            LoadMissSound();

            // Stel een timer in om het doelpuntgeluid te stoppen na 3 seconden
            stopSoundTimer = new Timer();
            stopSoundTimer.Interval = 3000;
            stopSoundTimer.Tick += StopSoundTimerElapsed;
        }

        // Laadt het doelpuntgeluid
        private void LoadGoalSound()
        {
            try
            {
                string soundFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "goalSound.wav");

                if (!File.Exists(soundFilePath))
                    throw new FileNotFoundException($"Het bestand 'goalSound.wav' is niet gevonden op {soundFilePath}");

                goalSound = new SoundPlayer(soundFilePath);
                goalSound.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij het laden van geluid: {ex.Message}", "Error");
            }
        }

        // Laadt het missergeluid
        private void LoadMissSound()
        {
            try
            {
                string soundFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "missSound.wav");

                if (!File.Exists(soundFilePath))
                    throw new FileNotFoundException($"Het bestand 'missSound.wav' is niet gevonden op {soundFilePath}");

                missSound = new SoundPlayer(soundFilePath);
                missSound.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij het laden van geluid: {ex.Message}", "Error");
            }
        }

        // Speelt het doelpuntgeluid af
        private void PlayGoalSound()
        {
            if (goalSound != null && !isGoalSoundPlaying)
            {
                isGoalSoundPlaying = true;
                goalSound.Play();
                stopSoundTimer.Start();
            }
        }

        // Speelt het missergeluid af
        private void PlayMissSound()
        {
            if (missSound != null)
            {
                missSound.Play();
            }
        }

        // Stop het doelpuntgeluid na 3 seconden
        private void StopSoundTimerElapsed(object sender, EventArgs e)
        {
            if (goalSound != null)
            {
                goalSound.Stop();
            }
            stopSoundTimer.Stop();
            isGoalSoundPlaying = false;
        }

        // Beheert de beweging van de keeper
        private void KeeperTimerEvent(object sender, EventArgs e)
        {
            if (isGoalSoundPlaying) return;

            int reactionSpeed = 6;
            int goalkeeperSpeed = Math.Max(Math.Min(goalKeeper.Left + reactionSpeed, 700), 100);

            // Beweging van de keeper
            switch (state)
            {
                case "left":
                    goalKeeper.Left = goalkeeperSpeed;
                    goalKeeper.Top = 204;

                    if (football.Bounds.IntersectsWith(goalKeeper.Bounds))
                    {
                        // Miss wanneer de bal boven of onder de keeper gaat
                        if (football.Top < goalKeeper.Top || football.Bottom > goalKeeper.Bottom)
                        {
                            KeeperTimer.Stop();
                            ballTimer.Stop();
                            PlayMissSound();
                            miss++;
                            ShowResult("Gemist! De keeper heeft de bal gestopt!", Color.Red);
                            ResetGame();
                            return;
                        }
                    }
                    break;

                case "right":
                    goalKeeper.Left = goalkeeperSpeed;
                    goalKeeper.Top = 204;
                    break;

                case "topLeft":
                    goalKeeper.Left = goalkeeperSpeed;
                    goalKeeper.Top = Math.Max(goalKeeper.Top - reactionSpeed / 2, 50);
                    break;

                case "topRight":
                    goalKeeper.Left = goalkeeperSpeed;
                    goalKeeper.Top = Math.Max(goalKeeper.Top - reactionSpeed / 2, 50);
                    break;

                case "top":
                    goalKeeper.Top = Math.Max(goalKeeper.Top - reactionSpeed, 50);
                    break;
            }

            // Controleer of de bal de keeper raakt
            if (football.Bounds.IntersectsWith(goalKeeper.Bounds))
            {
                if (state == "left")
                {
                    KeeperTimer.Stop();
                    ballTimer.Stop();
                    PlayMissSound();
                    miss++;
                    ShowResult("Gemist! De keeper heeft de bal gestopt!", Color.Red);
                    ResetGame();
                    return;
                }
            }
        }

        // Beheert de balbeweging
        private void BallTimerEvent(object sender, EventArgs e)
        {
            if (isGoalSoundPlaying) return;

            football.Left -= ballX;
            football.Top -= ballY;

            foreach (PictureBox target in goalTarget)
            {
                if (target != null && football.Bounds.IntersectsWith(target.Bounds) && !shotProcessed)
                {
                    shotProcessed = true;
                    football.Visible = false;
                    target.Visible = false;

                    if (playerTarget == state)
                    {
                        miss++;
                        PlayMissSound();
                        ShowResult("Gemist! De keeper heeft de bal gestopt!", Color.Red);
                    }
                    else
                    {
                        goal++;
                        PlayGoalSound();
                        ShowResult("DOELPUNT!", Color.Green);
                    }

                    ResetGame();
                    return;
                }
            }

            if (football.Top < 0 || football.Left < 0 || football.Right > this.ClientSize.Width)
            {
                ballTimer.Stop();
                ShowResult("Gemist! De bal ging uit de grenzen!", Color.Red);
                ResetGame();
            }
        }

        // Event handler voor het kiezen van het doelwit
        private void SetGoalTargetEvent(object sender, EventArgs e)
        {
            if (isGoalSoundPlaying || aimset) return;

            ballTimer.Start();
            KeeperTimer.Start();
            ChangeGoalKeeperImage();

            var senderObject = (PictureBox)sender;
            senderObject.BackColor = Color.Beige;

            // Bepaal de richting en snelheid van de bal afhankelijk van het doelwit
            switch (senderObject.Tag.ToString())
            {
                case "topRight":
                    ballX = -7;
                    ballY = 15;
                    break;
                case "right":
                    ballX = -11;
                    ballY = 15;
                    break;
                case "top":
                    ballX = 0;
                    ballY = 20;
                    break;
                case "topLeft":
                    ballX = 8;
                    ballY = 15;
                    break;
                case "left":
                    ballX = 7;
                    ballY = 11;
                    break;
            }

            playerTarget = senderObject.Tag.ToString();
            aimset = true;
        }

        // Verandert de afbeelding van de keeper
        private void ChangeGoalKeeperImage()
        {
            if (isGoalSoundPlaying) return;

            KeeperTimer.Start();
            double saveChance = 0.8;

            // De keeper kan soms de bal missen afhankelijk van een willekeurige kans
            if (rnd.NextDouble() < saveChance)
            {
                state = playerTarget;
            }
            else
            {
                state = keeperPosition[rnd.Next(0, keeperPosition.Count)];
            }

            // Verander de afbeelding van de keeper op basis van zijn positie
            switch (state)
            {
                case "left":
                    goalKeeper.Image = Properties.Resources.left_save_small;
                    break;
                case "right":
                    goalKeeper.Image = Properties.Resources.right_save_small;
                    break;
                case "top":
                    goalKeeper.Image = Properties.Resources.top_save_small;
                    break;
                case "topLeft":
                    goalKeeper.Image = Properties.Resources.top_left_save_small;
                    break;
                case "topRight":
                    goalKeeper.Image = Properties.Resources.top_right_save_small;
                    break;
            }

        }

        // Toont het resultaat van het schot
        private void ShowResult(string message, Color color)
        {
            ballTimer.Stop();
            KeeperTimer.Stop();

            lblResult.Text = message;
            lblResult.ForeColor = color;

            lblResult.Font = message.Contains("Gemist")
                ? new Font(lblResult.Font.FontFamily, 24)
                : new Font(lblResult.Font.FontFamily, 56);

            lblResult.Location = new Point(
                (this.ClientSize.Width - lblResult.Width) / 2,
                (this.ClientSize.Height - lblResult.Height) / 2
            );

            lblResult.Visible = true;
        }

        // Reset het spel voor een nieuwe poging
        private void ResetGame()
        {
            football.Location = new Point(430, 500);
            football.Visible = true;
            goalKeeper.Location = new Point(418, 169);
            aimset = false;
            ballX = 0;
            ballY = 0;
            shotProcessed = false;

            foreach (var target in goalTarget)
            {
                target.Visible = true;
            }

            lblGoal.Text = $"Goals: {goal}";
            lblMissed.Text = $"Gemist: {miss}";
        }
    }
}
