namespace WillowWoods
{
    partial class Form2
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
            this.intronamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intronamelbl
            // 
            this.intronamelbl.AutoSize = true;
            this.intronamelbl.BackColor = System.Drawing.Color.White;
            this.intronamelbl.Location = new System.Drawing.Point(191, 203);
            this.intronamelbl.Name = "intronamelbl";
            this.intronamelbl.Size = new System.Drawing.Size(38, 13);
            this.intronamelbl.TabIndex = 0;
            this.intronamelbl.Text = "label 1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 460);
            this.Controls.Add(this.intronamelbl);
            this.Name = "Form2";
            this.Text = "Title page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intronamelbl;
    }
}