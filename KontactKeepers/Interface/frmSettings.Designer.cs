namespace Interface
{
    partial class frmSettings
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
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.cbFullscreen = new System.Windows.Forms.CheckBox();
            this.cbDarkMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Location = new System.Drawing.Point(56, 12);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(75, 23);
            this.btnFullscreen.TabIndex = 0;
            this.btnFullscreen.Text = "Fullscreen";
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Location = new System.Drawing.Point(56, 41);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(75, 23);
            this.btnDarkMode.TabIndex = 1;
            this.btnDarkMode.Text = "Dark Mode";
            this.btnDarkMode.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(56, 81);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cbFullscreen
            // 
            this.cbFullscreen.AutoSize = true;
            this.cbFullscreen.Location = new System.Drawing.Point(35, 17);
            this.cbFullscreen.Name = "cbFullscreen";
            this.cbFullscreen.Size = new System.Drawing.Size(15, 14);
            this.cbFullscreen.TabIndex = 3;
            this.cbFullscreen.UseVisualStyleBackColor = true;
            // 
            // cbDarkMode
            // 
            this.cbDarkMode.AutoSize = true;
            this.cbDarkMode.Location = new System.Drawing.Point(35, 46);
            this.cbDarkMode.Name = "cbDarkMode";
            this.cbDarkMode.Size = new System.Drawing.Size(15, 14);
            this.cbDarkMode.TabIndex = 4;
            this.cbDarkMode.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 116);
            this.Controls.Add(this.cbDarkMode);
            this.Controls.Add(this.cbFullscreen);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.btnFullscreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.CheckBox cbFullscreen;
        private System.Windows.Forms.CheckBox cbDarkMode;
    }
}