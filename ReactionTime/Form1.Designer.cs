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
            this.Reaction_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reaction_Button
            // 
            this.Reaction_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Reaction_Button.BackColor = System.Drawing.Color.Blue;
            this.Reaction_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reaction_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reaction_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reaction_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reaction_Button.Location = new System.Drawing.Point(0, 0);
            this.Reaction_Button.Name = "Reaction_Button";
            this.Reaction_Button.Size = new System.Drawing.Size(800, 450);
            this.Reaction_Button.TabIndex = 0;
            this.Reaction_Button.Text = "Click to begin the test.";
            this.Reaction_Button.UseVisualStyleBackColor = false;
            this.Reaction_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Reaction_Button_KeyDown);
            this.Reaction_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Reaction_Button_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reaction_Button);
            this.Name = "Form1";
            this.Text = "Reaction Time";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reaction_Button;
    }
}

