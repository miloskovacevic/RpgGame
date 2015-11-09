namespace RpgGameApp
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Lbl_GameTitle = new System.Windows.Forms.Label();
            this.Btn_CreateCharacter = new System.Windows.Forms.Button();
            this.Btn_LoadGame = new System.Windows.Forms.Button();
            this.Btn_Options = new System.Windows.Forms.Button();
            this.Btn_HighScores = new System.Windows.Forms.Button();
            this.Btn_Credits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_GameTitle
            // 
            this.Lbl_GameTitle.AutoSize = true;
            this.Lbl_GameTitle.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GameTitle.Location = new System.Drawing.Point(13, 13);
            this.Lbl_GameTitle.Name = "Lbl_GameTitle";
            this.Lbl_GameTitle.Size = new System.Drawing.Size(107, 21);
            this.Lbl_GameTitle.TabIndex = 0;
            this.Lbl_GameTitle.Text = "Game Title";
            // 
            // Btn_CreateCharacter
            // 
            this.Btn_CreateCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_CreateCharacter.Location = new System.Drawing.Point(17, 194);
            this.Btn_CreateCharacter.Name = "Btn_CreateCharacter";
            this.Btn_CreateCharacter.Size = new System.Drawing.Size(103, 44);
            this.Btn_CreateCharacter.TabIndex = 1;
            this.Btn_CreateCharacter.Text = "Create Character";
            this.Btn_CreateCharacter.UseVisualStyleBackColor = true;
            // 
            // Btn_LoadGame
            // 
            this.Btn_LoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_LoadGame.Location = new System.Drawing.Point(159, 194);
            this.Btn_LoadGame.Name = "Btn_LoadGame";
            this.Btn_LoadGame.Size = new System.Drawing.Size(103, 44);
            this.Btn_LoadGame.TabIndex = 2;
            this.Btn_LoadGame.Text = "Load Game";
            this.Btn_LoadGame.UseVisualStyleBackColor = true;
            // 
            // Btn_Options
            // 
            this.Btn_Options.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Options.Location = new System.Drawing.Point(17, 254);
            this.Btn_Options.Name = "Btn_Options";
            this.Btn_Options.Size = new System.Drawing.Size(103, 44);
            this.Btn_Options.TabIndex = 3;
            this.Btn_Options.Text = "Options";
            this.Btn_Options.UseVisualStyleBackColor = true;
            // 
            // Btn_HighScores
            // 
            this.Btn_HighScores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_HighScores.Location = new System.Drawing.Point(159, 254);
            this.Btn_HighScores.Name = "Btn_HighScores";
            this.Btn_HighScores.Size = new System.Drawing.Size(103, 44);
            this.Btn_HighScores.TabIndex = 4;
            this.Btn_HighScores.Text = "High Scores";
            this.Btn_HighScores.UseVisualStyleBackColor = true;
            // 
            // Btn_Credits
            // 
            this.Btn_Credits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Credits.Location = new System.Drawing.Point(294, 254);
            this.Btn_Credits.Name = "Btn_Credits";
            this.Btn_Credits.Size = new System.Drawing.Size(103, 44);
            this.Btn_Credits.TabIndex = 5;
            this.Btn_Credits.Text = "Credits";
            this.Btn_Credits.UseVisualStyleBackColor = true;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 310);
            this.Controls.Add(this.Btn_Credits);
            this.Controls.Add(this.Btn_HighScores);
            this.Controls.Add(this.Btn_Options);
            this.Controls.Add(this.Btn_LoadGame);
            this.Controls.Add(this.Btn_CreateCharacter);
            this.Controls.Add(this.Lbl_GameTitle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.Text = "RPG Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GameTitle;
        private System.Windows.Forms.Button Btn_CreateCharacter;
        private System.Windows.Forms.Button Btn_LoadGame;
        private System.Windows.Forms.Button Btn_Options;
        private System.Windows.Forms.Button Btn_HighScores;
        private System.Windows.Forms.Button Btn_Credits;
    }
}

