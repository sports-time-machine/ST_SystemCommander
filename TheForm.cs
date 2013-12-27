using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SystemCommander
{
	public partial class TheForm : Form
	{
		const int UDP_REBOOT_PORT = 37501;
		UdpClient udp_send;

		public TheForm()
		{
			InitializeComponent();
			udp_send = new UdpClient();
			udp_send.Connect("255.255.255.255", UDP_REBOOT_PORT);
		}

		void broadcast(string s)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(s+"\n");
			udp_send.Send(bytes, bytes.Length);
		}

		private void buttonReboot_Click(object sender, EventArgs e)
			{ broadcast("shutdown|/r /t 1"); }
		private void buttonShutdown_Click(object sender, EventArgs e)
			{ broadcast("shutdown|/s /t 1"); }
		private void buttonExitClient_Click(object sender, EventArgs e)
			{ broadcast("cmd|/c //ST_SERVER/st/SystemDaemon/ExitClient.cmd"); }
		private void buttonCommand1_Click(object sender, EventArgs e)
			{ broadcast("cmd|/c //ST_SERVER/st/SystemDaemon/command1.cmd"); }
		private void buttonCommand2_Click(object sender, EventArgs e)
			{ broadcast("cmd|/c //ST_SERVER/st/SystemDaemon/command2.cmd"); }
		private void buttonCommand3_Click(object sender, EventArgs e)
			{ broadcast("cmd|/c //ST_SERVER/st/SystemDaemon/command3.cmd"); }
		private void buttonBye_Click(object sender, EventArgs e)
			{ broadcast("bye"); }
		private void buttonExec_Click(object sender, EventArgs e)
			{ broadcast("cmd|/c "+textBoxCommandLine.Text); }
		private void buttonHaifu_Click(object sender, EventArgs e)
			{ broadcast("cmd|/c //st_server/ST/Client/_copy.cmd"); }
	}
}
