using System;
using System.ServiceModel;
using System.Windows.Forms;
using GameInterfaces;

namespace Project
{
    public partial class MainForm : Form
    {
        private readonly IWcfGameService _proxyService;
        readonly ChannelFactory<IWcfGameService> _channelFactory = new ChannelFactory<IWcfGameService>("ClientSerEndpoint");
        //public static IGameServic ProxyGameServic;
        public MainForm()
        {
            InitializeComponent();
            
            _proxyService = _channelFactory.CreateChannel();
            
        }

        private void tabHero_Click(object sender, EventArgs e)
        {
            
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_proxyService.SayHello());
        }
    }
}
