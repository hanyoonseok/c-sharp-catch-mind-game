using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net.Sockets;

namespace Client
{
	public partial class Form2 : Form
	{
		private bool pencil;
		private bool line;
		private bool rect;
		private bool circle;
		private Point start;
		private Point finish;
		private Pen pen;
		private SolidBrush brush;
		private int nline;
		private int nrect;
		private int ncircle;
		private Color color1;
		private Color color2;
		private int i;
		private int thick;
		private bool isFill;
		private MyLines[] mylines;
		private MyRect[] myrect;
		private MyCircle[] mycircle;
		private List<MyPencil> mypencil;
		public Form2()
		{
			InitializeComponent();
			SetupVar();
			EnableDoubleBuffering();
		}
		public void EnableDoubleBuffering()
		{
			this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
			this.UpdateStyles();
		}
		private void SetupVar()
		{
			i = 0;
			thick = 1;
			isFill = false;
			pencil = true;
			line = false;
			rect = false;
			circle = false;
			color1 = Color.Black;
			color2 = Color.White;
			start = new Point(0, 0);
			finish = new Point(0, 0);
			pen = new Pen(Color.Black);
			brush = new SolidBrush(Color.Black);
			mylines = new MyLines[100];
			myrect = new MyRect[100];
			mycircle = new MyCircle[100];
			mypencil = new List<MyPencil>();
			nline = 0;
			nrect = 0;
			ncircle = 0;
			SetupMine();
			toolStripDropDownButton1.Image = PencilItem.Image;
			btn_fill.ForeColor = Color.Red;
			toolStripDropDownButton2.Image = line1.Image;
			toolStripButton3.BackColor = Color.Black;
			toolStripButton4.BackColor = Color.White;

		}
		private void SetupMine()
		{
			for (i = 0; i < 100; i++)
				mylines[i] = new MyLines();
			for (i = 0; i < 100; i++)
				myrect[i] = new MyRect();
			for (i = 0; i < 100; i++)
				mycircle[i] = new MyCircle();
		}
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			pencil = true;
			line = false;
			rect = false;
			circle = false;
			toolStripDropDownButton1.Image = PencilItem.Image;
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			pencil = false;
			line = true;
			rect = false;
			circle = false;
			toolStripDropDownButton1.Image = LineItem.Image;
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			pencil = false;
			line = false;
			rect = false;
			circle = true;
			toolStripDropDownButton1.Image = CirItem.Image;
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			pencil = false;
			line = false;
			rect = true;
			circle = false;
			toolStripDropDownButton1.Image = RectItem.Image;
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e) //1
		{
			thick = 1;
			toolStripDropDownButton2.Image = line1.Image;
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			thick = 2;
			toolStripDropDownButton2.Image = line2.Image;
		}

		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			thick = 3;
			toolStripDropDownButton2.Image = line3.Image;
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			thick = 4;
			toolStripDropDownButton2.Image = line4.Image;
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			thick = 5;
			toolStripDropDownButton2.Image = line5.Image;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			if (isFill == true)
			{
				isFill = false;
				btn_fill.ForeColor = Color.Red;
			}
			else if (isFill == false)
			{
				isFill = true;
				btn_fill.ForeColor = Color.Green;
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e) //초기화
		{
			SetupVar();
			doubleBuf1.Refresh();
		}

		private void toolStripButton3_Click(object sender, EventArgs e) //선
		{
			cld.Color = BackColor;
			cld.ShowDialog();
			color1 = cld.Color;
			toolStripButton3.BackColor = cld.Color;
		}
		private void toolStripButton4_Click_1(object sender, EventArgs e)
		{
			cld.Color = BackColor;
			cld.ShowDialog();
			color2 = cld.Color;
			toolStripButton4.BackColor = cld.Color;
		}

		private void doubleBuf1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			for (i = 0; i < mypencil.Count; i++)
			{
				pen.Color = mypencil[i].getColor();
				pen.Width = mypencil[i].getThick();
				pen.DashStyle = DashStyle.Solid;
				e.Graphics.DrawLine(pen, mypencil[i].getPoint1(), mypencil[i].getPoint2());
			}
			for (i = 0; i <= nline; i++)
			{
				pen.Color = mylines[i].getColor();
				pen.Width = mylines[i].getThick();
				pen.DashStyle = DashStyle.Solid;

				e.Graphics.DrawLine(pen, mylines[i].getPoint1(), mylines[i].getPoint2());
			}
			for (i = 0; i <= nrect; i++)
			{
				pen.Color = myrect[i].getColor1();
				brush.Color = myrect[i].getColor2();
				pen.Width = myrect[i].getThick();
				pen.DashStyle = DashStyle.Solid;

				if (isFill == true)
				{					
					e.Graphics.DrawRectangle(pen, myrect[i].getRectC());				
					e.Graphics.FillRectangle(brush, myrect[i].getRectC());					
				}
				else
					e.Graphics.DrawRectangle(pen, myrect[i].getRectC());
			}

			for (i = 0; i <= ncircle; i++)
			{
				pen.Color = mycircle[i].getColor1();
				brush.Color = mycircle[i].getColor2();
				pen.Width = mycircle[i].getThick();
				pen.DashStyle = DashStyle.Solid;
				if (isFill == true)
				{					
					e.Graphics.DrawEllipse(pen, mycircle[i].getRectC());				
					e.Graphics.FillEllipse(brush, mycircle[i].getRectC());					
				}
				else
					e.Graphics.DrawEllipse(pen, mycircle[i].getRectC());
			}
			pen.Color = color1;
			brush.Color = color2;
			pen.Width = thick;
			pen.DashStyle = DashStyle.Solid;
		}

		private void doubleBuf1_MouseDown(object sender, MouseEventArgs e)
		{
			start.X = e.X;
			start.Y = e.Y;
		}

		private void doubleBuf1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if ((start.X == 0) && (start.Y == 0))
					return;
				
				finish.X = e.X;
				finish.Y = e.Y;
				if (pencil == true)
				{
					byte[] SendByte = null;
					MyPencil m = new MyPencil();
					m.setPoint(start, finish, thick, color1);
					mypencil.Add(m);


					byte[] byte_Color = BitConverter.GetBytes(m.getColor().ToArgb());
					byte[] byte_Width = BitConverter.GetBytes(m.getThick());
					byte[] byte_x1 = BitConverter.GetBytes(m.getPoint1().X);
					byte[] byte_y1 = BitConverter.GetBytes(m.getPoint1().Y);
					byte[] byte_x2 = BitConverter.GetBytes(m.getPoint2().X);
					byte[] byte_y2 = BitConverter.GetBytes(m.getPoint2().Y);
					SendByte = new byte[2 + byte_Color.Length + byte_Width.Length + byte_x1.Length + byte_y1.Length + byte_x2.Length + byte_y2.Length];
					SendByte[0] = 0xff;
					SendByte[1] = 0x01;
					Buffer.BlockCopy(byte_Color, 0, SendByte, 2, byte_Color.Length);                // Pen색 값
					Buffer.BlockCopy(byte_Width, 0, SendByte, 6, byte_Width.Length);                // Pen두께 값
					Buffer.BlockCopy(byte_x1, 0, SendByte, 10, byte_x1.Length);                      // 선의 시작점 x축 x1
					Buffer.BlockCopy(byte_y1, 0, SendByte, 14, byte_y1.Length);                     // 선의 시작점 y축 y1
					Buffer.BlockCopy(byte_x2, 0, SendByte, 18, byte_x2.Length);                     // 선의   끝점 x축 x2
					Buffer.BlockCopy(byte_y2, 0, SendByte, 22, byte_y2.Length);                     // 선의   끝점 y축 y2

					Global.stream.Write(SendByte, 0, SendByte.Length);
					start = new Point(e.X, e.Y);
				}
				if (line == true)
				{
					mylines[nline].setPoint(start, finish, thick, color1);
				}
				if (rect == true)
				{
					myrect[nrect].setRect(start, finish, thick, color1, color2);					

				}
				if (circle == true)
				{
					mycircle[ncircle].setRectC(start, finish, thick, color1, color2);
				}
				doubleBuf1.Invalidate(true);
				doubleBuf1.Update();
			}
		}

		private void doubleBuf1_MouseUp(object sender, MouseEventArgs e)
		{
			byte[] SendByte;
			if (line == true)
			{
				byte[] byte_Color = BitConverter.GetBytes(mylines[nline].getColor().ToArgb());
				byte[] byte_Width = BitConverter.GetBytes(mylines[nline].getThick());
				byte[] byte_x1 = BitConverter.GetBytes(mylines[nline].getPoint1().X);
				byte[] byte_y1 = BitConverter.GetBytes(mylines[nline].getPoint1().Y);
				byte[] byte_x2 = BitConverter.GetBytes(mylines[nline].getPoint2().X);
				byte[] byte_y2 = BitConverter.GetBytes(mylines[nline].getPoint2().Y);
				SendByte = new byte[2 + byte_Color.Length + byte_Width.Length + byte_x1.Length + byte_y1.Length + byte_x2.Length + byte_y2.Length];
				SendByte[0] = 0xff;
				SendByte[1] = 0x02;
				Buffer.BlockCopy(byte_Color, 0, SendByte, 2, byte_Color.Length);                // Pen색 값
				Buffer.BlockCopy(byte_Color, 0, SendByte, 2, byte_Color.Length);                // Pen색 값
				Buffer.BlockCopy(byte_Width, 0, SendByte, 6, byte_Width.Length);                // Pen두께 값
				Buffer.BlockCopy(byte_x1, 0, SendByte, 10, byte_x1.Length);                      // 선의 시작점 x축 x1
				Buffer.BlockCopy(byte_y1, 0, SendByte, 14, byte_y1.Length);                     // 선의 시작점 y축 y1
				Buffer.BlockCopy(byte_x2, 0, SendByte, 18, byte_x2.Length);                     // 선의   끝점 x축 x2
				Buffer.BlockCopy(byte_y2, 0, SendByte, 22, byte_y2.Length);                     // 선의   끝점 y축 y2

				Global.stream.Write(SendByte, 0, SendByte.Length);
				nline++;
			}			
			if (rect == true)
			{
				byte[] byte_Color = BitConverter.GetBytes(myrect[nrect].getColor1().ToArgb());
				byte[] byte_BrushColor = BitConverter.GetBytes(myrect[nrect].getColor2().ToArgb());
				byte[] byte_Width = BitConverter.GetBytes(myrect[nrect].getThick());
				byte[] byte_x1 = BitConverter.GetBytes(myrect[nrect].getRectC().X);
				byte[] byte_y1 = BitConverter.GetBytes(myrect[nrect].getRectC().Y);
				byte[] byte_rectWidth = BitConverter.GetBytes(myrect[nrect].getRectC().Width);
				byte[] byte_rectHeight = BitConverter.GetBytes(myrect[nrect].getRectC().Height);
				
				SendByte = new byte[2 + byte_Color.Length + byte_BrushColor.Length + byte_Width.Length + byte_x1.Length + byte_y1.Length + byte_rectWidth.Length + byte_rectHeight.Length + 1];
				SendByte[0] = 0xff;
				SendByte[1] = 0x03;
				Buffer.BlockCopy(byte_Color, 0, SendByte, 2, byte_Color.Length);                // Pen색 값
				Buffer.BlockCopy(byte_BrushColor, 0, SendByte, 6, byte_BrushColor.Length);                // BrushPen색 값
				Buffer.BlockCopy(byte_Width, 0, SendByte, 10, byte_Width.Length);                // Pen두께 값
				Buffer.BlockCopy(byte_x1, 0, SendByte, 14, byte_x1.Length);                      // 선의 시작점 x축 x1
				Buffer.BlockCopy(byte_y1, 0, SendByte, 18, byte_y1.Length);                     // 선의 시작점 y축 y1
				Buffer.BlockCopy(byte_rectWidth, 0, SendByte, 22, byte_rectWidth.Length);                     // 선의   끝점 x축 x2
				Buffer.BlockCopy(byte_rectHeight, 0, SendByte, 26, byte_rectHeight.Length);                     // 선의   끝점 y축 y2
				if (isFill == true)
					SendByte[SendByte.Length - 1] = 0x01;
				else
					SendByte[SendByte.Length - 1] = 0x00;

				Global.stream.Write(SendByte, 0, SendByte.Length);
				
				nrect++;
			}
				
			if (circle == true)
			{
				byte[] byte_Color = BitConverter.GetBytes(mycircle[ncircle].getColor1().ToArgb());
				byte[] byte_BrushColor = BitConverter.GetBytes(mycircle[ncircle].getColor2().ToArgb());
				byte[] byte_Width = BitConverter.GetBytes(mycircle[ncircle].getThick());
				byte[] byte_x1 = BitConverter.GetBytes(mycircle[ncircle].getRectC().X);
				byte[] byte_y1 = BitConverter.GetBytes(mycircle[ncircle].getRectC().Y);
				byte[] byte_rectWidth = BitConverter.GetBytes(mycircle[ncircle].getRectC().Width);
				byte[] byte_rectHeight = BitConverter.GetBytes(mycircle[ncircle].getRectC().Height);

				SendByte = new byte[2 + byte_Color.Length + byte_BrushColor.Length + byte_Width.Length + byte_x1.Length + byte_y1.Length + byte_rectWidth.Length + byte_rectHeight.Length + 1];
				SendByte[0] = 0xff;
				SendByte[1] = 0x04;
				Buffer.BlockCopy(byte_Color, 0, SendByte, 2, byte_Color.Length);                // Pen색 값
				Buffer.BlockCopy(byte_BrushColor, 0, SendByte, 6, byte_BrushColor.Length);                // BrushPen색 값
				Buffer.BlockCopy(byte_Width, 0, SendByte, 10, byte_Width.Length);                // Pen두께 값
				Buffer.BlockCopy(byte_x1, 0, SendByte, 14, byte_x1.Length);                      // 선의 시작점 x축 x1
				Buffer.BlockCopy(byte_y1, 0, SendByte, 18, byte_y1.Length);                     // 선의 시작점 y축 y1
				Buffer.BlockCopy(byte_rectWidth, 0, SendByte, 22, byte_rectWidth.Length);                     // 선의   끝점 x축 x2
				Buffer.BlockCopy(byte_rectHeight, 0, SendByte, 26, byte_rectHeight.Length);                     // 선의   끝점 y축 y2
				if (isFill == true)
					SendByte[SendByte.Length - 1] = 0x01;
				else
					SendByte[SendByte.Length - 1] = 0x00;

				Global.stream.Write(SendByte, 0, SendByte.Length);
				ncircle++;
			}
			
			start.X = 0;
			start.Y = 0;
			finish.X = 0;
			finish.Y = 0;


		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.ExitThread();
			Environment.Exit(0);
		}
	}
}
