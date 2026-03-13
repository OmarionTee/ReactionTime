namespace ReactionTime
{
    partial class Form1
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
            this.player1Panel = new System.Windows.Forms.Panel();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Panel = new System.Windows.Forms.Panel();
            this.player2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1Panel
            // 
            this.player1Panel.BackColor = System.Drawing.Color.Blue;
            this.player1Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.player1Panel.Location = new System.Drawing.Point(0, 0);
            this.player1Panel.Name = "player1Panel";
            this.player1Panel.Size = new System.Drawing.Size(400, 450);
            this.player1Panel.TabIndex = 0;
            this.player1Panel.Tag = 1;
            this.player1Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerPanel_MouseClick);
            // 
            // player1Label
            // 
            this.player1Label.BackColor = System.Drawing.Color.Transparent;
            this.player1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.player1Label.ForeColor = System.Drawing.Color.White;
            this.player1Label.Location = new System.Drawing.Point(0, 0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(400, 450);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "Player 1\nClick or press A to start";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player1Panel.Controls.Add(this.player1Label);
            // 
            // player2Panel
            // 
            this.player2Panel.BackColor = System.Drawing.Color.DarkRed;
            this.player2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player2Panel.Location = new System.Drawing.Point(400, 0);
            this.player2Panel.Name = "player2Panel";
            this.player2Panel.Size = new System.Drawing.Size(400, 450);
            this.player2Panel.TabIndex = 2;
            this.player2Panel.Tag = 2;
            this.player2Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerPanel_MouseClick);
            // 
            // player2Label
            // 
            this.player2Label.BackColor = System.Drawing.Color.Transparent;
            this.player2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.player2Label.ForeColor = System.Drawing.Color.White;
            this.player2Label.Location = new System.Drawing.Point(0, 0);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(400, 450);
            this.player2Label.TabIndex = 3;
            this.player2Label.Text = "Player 2\nClick or press L to start";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player2Panel.Controls.Add(this.player2Label);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player2Panel);
            this.Controls.Add(this.player1Panel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Reaction Time - Duel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel player1Panel;
        private System.Windows.Forms.Panel player2Panel;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
    }
}

