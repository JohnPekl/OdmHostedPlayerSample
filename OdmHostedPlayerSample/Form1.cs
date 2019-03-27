using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdmHostedPlayerSample
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ptBox.SizeMode = PictureBoxSizeMode.Zoom;
            OdmPlayer player = new OdmPlayer(ptBox);
            string user = "user";
            string password = "password";
            string uri = "rtsp://192.168.0.111/video1+audio1";
            System.Net.NetworkCredential account = new System.Net.NetworkCredential(user, password);

            player.InitPlayer(uri, account, new Size(1280,720));
        }
    }
}
