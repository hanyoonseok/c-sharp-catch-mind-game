using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Client
{
    public class MyCircle
    {
        private Rectangle rectC;
        private int thick;
        private Color color1;
        private Color color2;

        public MyCircle()
        {
            rectC = new Rectangle();
            thick = 1;
            color1 = Color.Black;
            color2 = Color.Black;
        }
        public void setRectC(Point start, Point finish, int thick, Color color1, Color color2)
        {
            rectC.X = Math.Min(start.X, finish.X);
            rectC.Y = Math.Min(start.X, finish.Y);
            rectC.Width = Math.Abs(start.X - finish.X);
            rectC.Height = Math.Abs(start.Y - finish.Y);
            this.thick = thick;
            this.color2 = color2;
            this.color1 = color1;
        }

        public Rectangle getRectC()
        {
            return rectC;
        }
        public Color getColor1()
        {
            return color1;
        }
        public Color getColor2()
        {
            return color2;
        }
        public int getThick()
        {
            return thick;
        }
    }
}
