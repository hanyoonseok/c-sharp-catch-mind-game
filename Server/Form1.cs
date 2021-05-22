using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Server
{
	public partial class Form1 : Form
	{
		TcpListener server = null; // 서버
		TcpClient clientSocket = null; // 소켓
					       // 각 클라이언트 마다 리스트에 추가
		
		NetworkStream stream = default(NetworkStream);

		public Form1()
		{
			InitializeComponent();
		}
		private void InitSocket()
		{
			int port = int.Parse(txt_port.Text);

			server = new TcpListener(port);
			clientSocket = default(TcpClient);
			server.Start();
			while (true)
			{
				try
				{
					clientSocket = server.AcceptTcpClient();//클라이언트가 소켓에 접속하는 것을 허용

					NetworkStream stream = clientSocket.GetStream();
					byte[] buffer = new byte[1024];
					int bytes = stream.Read(buffer, 0, buffer.Length);
					string nickname = Encoding.Unicode.GetString(buffer, 0, bytes);

					Global.clientList.Add(clientSocket, nickname); // 클라이언트 리스트에 추가
					handle h_client = new handle(); // 클라이언트 추가
					h_client.OnDisconnected += new handle.DisconnectedHandler(h_client_OnDisconnected);
					h_client.startClient(clientSocket);
				}
				catch (SocketException e) { break; }
				catch (Exception e) { break; }
			}
			clientSocket.Close();
			server.Stop();

		}
		void h_client_OnDisconnected(TcpClient c) // 클라이언트 접속 해제 되었을 때 리스트에서 삭제
		{
			if (Global.clientList.ContainsKey(c))
				Global.clientList.Remove(c);
		}

		private void btn_start_Click(object sender, EventArgs e)
		{
			Thread t = new Thread(InitSocket);
			t.IsBackground = true;
			t.Start();
			this.Hide();
			Global.frm2 = new Form2();
			Global.frm2.ShowDialog();
			this.Close();
		}
	}
}
