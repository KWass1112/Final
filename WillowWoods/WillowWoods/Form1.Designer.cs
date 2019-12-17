namespace WillowWoods
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
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.GameNamelbl = new System.Windows.Forms.Label();
            this.welcomebtm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelbl.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.ForeColor = System.Drawing.Color.White;
            this.Welcomelbl.Location = new System.Drawing.Point(150, 151);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(288, 34);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "Welcome to ";
            // 
            // GameNamelbl
            // 
            this.GameNamelbl.AutoSize = true;
            this.GameNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.GameNamelbl.Font = new System.Drawing.Font("Engravers MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNamelbl.ForeColor = System.Drawing.Color.White;
            this.GameNamelbl.Location = new System.Drawing.Point(131, 194);
            this.GameNamelbl.Name = "GameNamelbl";
            this.GameNamelbl.Size = new System.Drawing.Size(337, 34);
            this.GameNamelbl.TabIndex = 1;
            this.GameNamelbl.Text = "Willow Woods";
            // 
            // welcomebtm
            // 
            this.welcomebtm.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomebtm.Location = new System.Drawing.Point(241, 282);
            this.welcomebtm.Name = "welcomebtm";
            this.welcomebtm.Size = new System.Drawing.Size(119, 55);
            this.welcomebtm.TabIndex = 2;
            this.welcomebtm.Text = "Click me to start!";
            this.welcomebtm.UseVisualStyleBackColor = true;
            this.welcomebtm.Click += new System.EventHandler(this.welcomebtm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WillowWoods.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 460);
            this.Controls.Add(this.welcomebtm);
            this.Controls.Add(this.GameNamelbl);
            this.Controls.Add(this.Welcomelbl);
            this.Name = "Form1";
            this.Text = "Willow Woods Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Label GameNamelbl;
        private System.Windows.Forms.Button welcomebtm;
    }
}

