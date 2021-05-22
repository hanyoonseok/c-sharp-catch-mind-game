using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	public class Global
	{
		public static Form2 frm2;
		public static Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();
	}
}
