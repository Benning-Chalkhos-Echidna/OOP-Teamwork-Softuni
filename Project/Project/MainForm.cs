using System;
using System.ServiceModel;
using System.Windows.Forms;
using GameInterfaces;

namespace Project
{
    public partial class MainForm : Form
    {
        //public static IGameServic ProxyGameServic;
        public MainForm()
        {
            InitializeComponent();
            ChannelFactory<IWcfGameService> channelFactory = new ChannelFactory<IWcfGameService>("ClientSerEndpoint");
            IWcfGameService proxyService = channelFactory.CreateChannel();
            MessageBox.Show(proxyService.SayHello());
        }

        private void tabHero_Click(object sender, EventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
