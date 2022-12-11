using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubePlayer_Framework
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='590' frameborder='0' allowfullscreen>  </iframe> ";
            html += "</body> </html> ";
            this.WebYouTube.DocumentText = string.Format(html, url_box.Text.Split('=')[1]);
        }
    }
}
