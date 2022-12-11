namespace YouTubePlayer_Framework
{
    partial class Player
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.WebYouTube = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.url_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlay.Location = new System.Drawing.Point(0, 34);
            this.btnPlay.MaximumSize = new System.Drawing.Size(0, 35);
            this.btnPlay.MinimumSize = new System.Drawing.Size(0, 35);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(882, 35);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // urlBox
            // 
            this.urlBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.urlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlBox.HideSelection = false;
            this.urlBox.Location = new System.Drawing.Point(0, 0);
            this.urlBox.MaximumSize = new System.Drawing.Size(4, 20);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(4, 20);
            this.urlBox.TabIndex = 3;
            this.urlBox.Text = "YouTube - Link, hier eingeben.";
            this.urlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WebYouTube
            // 
            this.WebYouTube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebYouTube.Location = new System.Drawing.Point(0, 0);
            this.WebYouTube.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebYouTube.Name = "WebYouTube";
            this.WebYouTube.Size = new System.Drawing.Size(882, 434);
            this.WebYouTube.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.WebYouTube);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.url_box);
            this.splitContainer1.Panel2.Controls.Add(this.btnPlay);
            this.splitContainer1.Panel2.Controls.Add(this.urlBox);
            this.splitContainer1.Size = new System.Drawing.Size(884, 511);
            this.splitContainer1.SplitterDistance = 436;
            this.splitContainer1.TabIndex = 4;
            // 
            // url_box
            // 
            this.url_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.url_box.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.url_box.Location = new System.Drawing.Point(0, 20);
            this.url_box.MinimumSize = new System.Drawing.Size(880, 0);
            this.url_box.Name = "url_box";
            this.url_box.Size = new System.Drawing.Size(882, 20);
            this.url_box.TabIndex = 4;
            this.url_box.Text = "YouTube - URL";
            this.url_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Player";
            this.Text = "YouTube Player";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.WebBrowser WebYouTube;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox url_box;
    }
}

