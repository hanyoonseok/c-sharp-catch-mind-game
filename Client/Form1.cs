using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Drawing;

namespace Client
{
	public partial class Form1 : Form
	{
		TcpClient clientSocket = new TcpClient(); // 소켓

		public Form1()
		{
			InitializeComponent();
		}
		private void Receive()
		{
			Global.stream = clientSocket.GetStream();
			while (true)
			{
				int BUFFERSIZE = clientSocket.ReceiveBufferSize;
				byte[] buffer = new byte[BUFFERSIZE];
				int bytes = Global.stream.Read(buffer, 0, buffer.Length);
				if(bytes > 0)
				{
					if (buffer[0] == 0xff)                                                // 그림데이터 인 경우
					{
						if (buffer[1] == 0x01)                                           // 펜인 경우
						{
							using (Graphics g = Global.frm2.doubleBuf1.CreateGraphics())
							{
								byte[] byte_Color = new byte[4];
								byte[] byte_Width = new byte[4];
								byte[] byte_x1 = new byte[4];
								byte[] byte_y1 = new byte[4];
								byte[] byte_x2 = new byte[4];
								byte[] byte_y2 = new byte[4];

								Buffer.BlockCopy(buffer, 2, byte_Color, 0, byte_Color.Length);           // 받은 데이터의 [1]번지부터 4만큼 byte_Color 에 복사
								Buffer.BlockCopy(buffer, 6, byte_Width, 0, byte_Width.Length);           // 받은 데이터의 [5]번지부터 4만큼 byte_Width 에 복사
								Buffer.BlockCopy(buffer, 10, byte_x1, 0, byte_x1.Length);                 // 받은 데이터의 [9]번지부터 4만큼 byte_x1 에 복사
								Buffer.BlockCopy(buffer, 14, byte_y1, 0, byte_y1.Length);                // 받은 데이터의 [13]번지부터 4만큼 byte_y1 에 복사
								Buffer.BlockCopy(buffer, 18, byte_x2, 0, byte_x2.Length);                // 받은 데이터의 [17]번지부터 4만큼 byte_x2 에 복사
								Buffer.BlockCopy(buffer, 22, byte_y2, 0, byte_y2.Length);                     // 받은 데이터의 [21]번지부터 4만큼 byte_y2 에 복사

								Color SetPenColor = Color.FromArgb(BitConverter.ToInt32(byte_Color, 0));      // byte_Color 값을 Int형으로 변환하여 펜 칼라값에 대입
								int SetPenWidth = BitConverter.ToInt32(byte_Width, 0);                      // SetPenWidth 값을 Int형으로 변환하여 펜 두께값에 대입
								Pen SetPen = new Pen(SetPenColor, SetPenWidth);                             // byte_Color, SetPenWidth을 통하여 Pen을 만듬

								int x1 = BitConverter.ToInt32(byte_x1, 0);                              // byte_x1 을 int형으로 변환하여 x1 에 대입
								int y1 = BitConverter.ToInt32(byte_y1, 0);                              // byte_y1 을 int형으로 변환하여 x2 에 대입
								int x2 = BitConverter.ToInt32(byte_x2, 0);                              // byte_x2 을 int형으로 변환하여 y1 에 대입
								int y2 = BitConverter.ToInt32(byte_y2, 0);                              // byte_y2 을 int형으로 변환하여 y2 에 대입

								g.DrawLine(SetPen, x1, y1, x2, y2);                                     // 위에서 변환한 데이터를 그림을 그리기 시작
							}
						}
						else if (buffer[1] == 0x02)                                           // 선 인 경우
						{
							using (Graphics g = Global.frm2.doubleBuf1.CreateGraphics())
							{
								byte[] byte_Color = new byte[4];
								byte[] byte_Width = new byte[4];
								byte[] byte_x1 = new byte[4];
								byte[] byte_y1 = new byte[4];
								byte[] byte_x2 = new byte[4];
								byte[] byte_y2 = new byte[4];

								Buffer.BlockCopy(buffer, 2, byte_Color, 0, byte_Color.Length);           // 받은 데이터의 [1]번지부터 4만큼 byte_Color 에 복사
								Buffer.BlockCopy(buffer, 6, byte_Width, 0, byte_Width.Length);           // 받은 데이터의 [5]번지부터 4만큼 byte_Width 에 복사
								Buffer.BlockCopy(buffer, 10, byte_x1, 0, byte_x1.Length);                 // 받은 데이터의 [9]번지부터 4만큼 byte_x1 에 복사
								Buffer.BlockCopy(buffer, 14, byte_y1, 0, byte_y1.Length);                // 받은 데이터의 [13]번지부터 4만큼 byte_y1 에 복사
								Buffer.BlockCopy(buffer, 18, byte_x2, 0, byte_x2.Length);                // 받은 데이터의 [17]번지부터 4만큼 byte_x2 에 복사
								Buffer.BlockCopy(buffer, 22, byte_y2, 0, byte_y2.Length);                     // 받은 데이터의 [21]번지부터 4만큼 byte_y2 에 복사

								Color SetPenColor = Color.FromArgb(BitConverter.ToInt32(byte_Color, 0));      // byte_Color 값을 Int형으로 변환하여 펜 칼라값에 대입
								int SetPenWidth = BitConverter.ToInt32(byte_Width, 0);                      // SetPenWidth 값을 Int형으로 변환하여 펜 두께값에 대입
								Pen SetPen = new Pen(SetPenColor, SetPenWidth);                             // byte_Color, SetPenWidth을 통하여 Pen을 만듬

								int x1 = BitConverter.ToInt32(byte_x1, 0);                              // byte_x1 을 int형으로 변환하여 x1 에 대입
								int y1 = BitConverter.ToInt32(byte_y1, 0);                              // byte_y1 을 int형으로 변환하여 x2 에 대입
								int x2 = BitConverter.ToInt32(byte_x2, 0);                              // byte_x2 을 int형으로 변환하여 y1 에 대입
								int y2 = BitConverter.ToInt32(byte_y2, 0);                              // byte_y2 을 int형으로 변환하여 y2 에 대입

								g.DrawLine(SetPen, x1, y1, x2, y2);                                     // 위에서 변환한 데이터를 그림을 그리기 시작
							}
						}
						else if (buffer[1] == 0x03)                                           // 
						{
							using (Graphics g = Global.frm2.doubleBuf1.CreateGraphics())
							{
								byte[] byte_Color = new byte[4];
								byte[] byte_BrushColor = new byte[4];
								byte[] byte_Width = new byte[4];
								byte[] byte_x1 = new byte[4];
								byte[] byte_y1 = new byte[4];
								byte[] byte_RectWidth = new byte[4];
								byte[] byte_RectHeight = new byte[4];

								Buffer.BlockCopy(buffer, 2, byte_Color, 0, byte_Color.Length);           // 받은 데이터의 [2]번지부터 4만큼 byte_Color 에 복사
								Buffer.BlockCopy(buffer, 6, byte_BrushColor, 0, byte_BrushColor.Length);           // 받은 데이터의 [6]번지부터 4만큼 byte_Color 에 복사
								Buffer.BlockCopy(buffer, 10, byte_Width, 0, byte_Width.Length);           // 받은 데이터의 [10]번지부터 4만큼 byte_Width 에 복사
								Buffer.BlockCopy(buffer, 14, byte_x1, 0, byte_x1.Length);                 // 받은 데이터의 [14]번지부터 4만큼 byte_x1 에 복사
								Buffer.BlockCopy(buffer, 18, byte_y1, 0, byte_y1.Length);                // 받은 데이터의 [18]번지부터 4만큼 byte_y1 에 복사
								Buffer.BlockCopy(buffer, 22, byte_RectWidth, 0, byte_RectWidth.Length);                // 받은 데이터의 [22]번지부터 4만큼 byte_x2 에 복사
								Buffer.BlockCopy(buffer, 26, byte_RectHeight, 0, byte_RectHeight.Length);                     // 받은 데이터의 [26]번지부터 4만큼 byte_y2 에 복사

								Color SetPenColor = Color.FromArgb(BitConverter.ToInt32(byte_Color, 0));      // byte_Color 값을 Int형으로 변환하여 펜 칼라값에 대입
								int SetPenWidth = BitConverter.ToInt32(byte_Width, 0);                      // SetPenWidth 값을 Int형으로 변환하여 펜 두께값에 대입
								Brush SetBrushColor = new SolidBrush(Color.FromArgb(BitConverter.ToInt32(byte_BrushColor, 0)));
								Pen SetPen = new Pen(SetPenColor, SetPenWidth)
								{
									DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
								};// byte_Color, SetPenWidth을 통하여 Pen을 만듬

								int x1 = BitConverter.ToInt32(byte_x1, 0);                              // byte_x1 을 int형으로 변환하여 x1 에 대입
								int y1 = BitConverter.ToInt32(byte_y1, 0);                              // byte_y1 을 int형으로 변환하여 x2 에 대입
								int RectWidth = BitConverter.ToInt32(byte_RectWidth, 0);                              // byte_x2 을 int형으로 변환하여 y1 에 대입
								int RectHeight = BitConverter.ToInt32(byte_RectHeight, 0);                              // byte_y2 을 int형으로 변환하여 y2 에 대입

								Rectangle rect = new Rectangle()
								{
									X = x1,
									Y = y1,
									Width = RectWidth,
									Height = RectHeight
								};
								if (buffer[bytes - 1] == 0x01)
								{
									g.FillRectangle(SetBrushColor, rect);
									g.DrawRectangle(SetPen, rect);                                     // 위에서 변환한 데이터를 그림을 그리기 시작6										
								}
								else
								{
									g.DrawRectangle(SetPen, rect);                                     // 위에서 변환한 데이터를 그림을 그리기 시작
								}
							}

						}
						else if (buffer[1] == 0x04)                                           //
						{
							using (Graphics g = Global.frm2.doubleBuf1.CreateGraphics())
							{
								byte[] byte_Color = new byte[4];
								byte[] byte_BrushColor = new byte[4];
								byte[] byte_Width = new byte[4];
								byte[] byte_x1 = new byte[4];
								byte[] byte_y1 = new byte[4];
								byte[] byte_RectWidth = new byte[4];
								byte[] byte_RectHeight = new byte[4];

								Buffer.BlockCopy(buffer, 2, byte_Color, 0, byte_Color.Length);           // 받은 데이터의 [2]번지부터 4만큼 byte_Color 에 복사
								Buffer.BlockCopy(buffer, 6, byte_BrushColor, 0, byte_BrushColor.Length);           // 받은 데이터의 [6]번지부터 4만큼 byte_Color 에 복사
								Buffer.BlockCopy(buffer, 10, byte_Width, 0, byte_Width.Length);           // 받은 데이터의 [10]번지부터 4만큼 byte_Width 에 복사
								Buffer.BlockCopy(buffer, 14, byte_x1, 0, byte_x1.Length);                 // 받은 데이터의 [14]번지부터 4만큼 byte_x1 에 복사
								Buffer.BlockCopy(buffer, 18, byte_y1, 0, byte_y1.Length);                // 받은 데이터의 [18]번지부터 4만큼 byte_y1 에 복사
								Buffer.BlockCopy(buffer, 22, byte_RectWidth, 0, byte_RectWidth.Length);                // 받은 데이터의 [22]번지부터 4만큼 byte_x2 에 복사
								Buffer.BlockCopy(buffer, 26, byte_RectHeight, 0, byte_RectHeight.Length);                     // 받은 데이터의 [26]번지부터 4만큼 byte_y2 에 복사

								Color SetPenColor = Color.FromArgb(BitConverter.ToInt32(byte_Color, 0));      // byte_Color 값을 Int형으로 변환하여 펜 칼라값에 대입
								int SetPenWidth = BitConverter.ToInt32(byte_Width, 0);                      // SetPenWidth 값을 Int형으로 변환하여 펜 두께값에 대입
								Brush SetBrushColor = new SolidBrush(Color.FromArgb(BitConverter.ToInt32(byte_BrushColor, 0)));
								Pen SetPen = new Pen(SetPenColor, SetPenWidth)
								{
									DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
								};// byte_Color, SetPenWidth을 통하여 Pen을 만듬

								int x1 = BitConverter.ToInt32(byte_x1, 0);                              // byte_x1 을 int형으로 변환하여 x1 에 대입
								int y1 = BitConverter.ToInt32(byte_y1, 0);                              // byte_y1 을 int형으로 변환하여 x2 에 대입
								int RectWidth = BitConverter.ToInt32(byte_RectWidth, 0);                              // byte_x2 을 int형으로 변환하여 y1 에 대입
								int RectHeight = BitConverter.ToInt32(byte_RectHeight, 0);                              // byte_y2 을 int형으로 변환하여 y2 에 대입

								Rectangle rect = new Rectangle()
								{
									X = x1,
									Y = y1,
									Width = RectWidth,
									Height = RectHeight
								};
								if (buffer[bytes - 1] == 0x01)
								{
									g.FillEllipse(SetBrushColor, rect);
									g.DrawEllipse(SetPen, rect);                                     // 위에서 변환한 데이터를 그림을 그리기 시작6										
								}
								else
								{
									g.DrawEllipse(SetPen, rect);                                     // 위에서 변환한 데이터를 그림을 그리기 시작
								}
							}
						}

					}
				}
			}
		}
		private void btn_start_Click(object sender, EventArgs e)
		{
			try
			{
				int port = int.Parse(txt_port.Text); //포트번호 int형 변환
				clientSocket.Connect(txt_ip.Text, port); // 접속 IP 및 포트
				Global.stream = clientSocket.GetStream();
	
				Global.stream.Write(new byte[] { 0x00,0x01 }, 0, 1);

				Global.stream.Flush();
				//t_handler.IsBackground = true;
				Thread t_handler = new Thread(Receive);
				t_handler.Start();
				this.Hide();
				Global.frm2 = new Form2();
				Global.frm2.ShowDialog();
			}
			catch (Exception e2)
			{
				MessageBox.Show("서버가 실행중이지 않습니다..");
				Application.Exit();
			}

			

		}
	}
}
