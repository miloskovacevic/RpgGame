namespace RpgGameApp
{
    partial class CharacterID
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
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Gender = new System.Windows.Forms.Label();
            this.Lbl_Class = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(51, 20);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Name";
            // 
            // Lbl_Gender
            // 
            this.Lbl_Gender.AutoSize = true;
            this.Lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Gender.Location = new System.Drawing.Point(13, 53);
            this.Lbl_Gender.Name = "Lbl_Gender";
            this.Lbl_Gender.Size = new System.Drawing.Size(63, 20);
            this.Lbl_Gender.TabIndex = 1;
            this.Lbl_Gender.Text = "Gender";
            // 
            // Lbl_Class
            // 
            this.Lbl_Class.AutoSize = true;
            this.Lbl_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Class.Location = new System.Drawing.Point(13, 93);
            this.Lbl_Class.Name = "Lbl_Class";
            this.Lbl_Class.Size = new System.Drawing.Size(122, 20);
            this.Lbl_Class.TabIndex = 2;
            this.Lbl_Class.Text = "Character Class";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(13, 333);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // CharacterID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 382);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lbl_Class);
            this.Controls.Add(this.Lbl_Gender);
            this.Controls.Add(this.Lbl_Name);
            this.Name = "CharacterID";
            this.Text = "Character Stats";
            this.Load += new System.EventHandler(this.CharacterID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Gender;
        private System.Windows.Forms.Label Lbl_Class;
        private System.Windows.Forms.Button Btn_Close;
    }
}