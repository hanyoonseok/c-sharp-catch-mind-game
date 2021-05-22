using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Client
{
	public class MyRect
	{
		private Rectangle rect;
		private int thick;
		private Color color1; //pen color
		private Color color2;

		public MyRect()
		{
			rect = new Rectangle();
			thick = 1;
			color1 = Color.Black;
			color2 = Color.Black;
		}
		public void setRect(Point start, Point finish, int thick, Color color1, Color color2)
		{
			rect.X = Math.Min(start.X, finish.X);
			rect.Y = Math.Min(start.Y, finish.Y);
			rect.Width = Math.Abs(finish.X - start.X);
			rect.Height = Math.Abs(finish.Y - start.Y);
			this.thick = thick;
			this.color2 = color2;
			this.color1 = color1;
		}
		public Rectangle getRectC()
		{			
			return rect;
		}

		public int getThick()
		{
			return thick;
		}
		public Color getColor1()
		{
			return color1;
		}
		public Color getColor2()
		{
			return color2;
		}
	}
}
