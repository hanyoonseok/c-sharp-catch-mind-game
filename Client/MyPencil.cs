using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Client
{
    class MyPencil
    {
        private Point[] point = new Point[2];
        private int thick;
        private Color color;
        public MyPencil()
        {
            point[0] = new Point();
            point[1] = new Point();
            thick = 1;
            color = Color.Black;
        }

        public void setPoint(Point start, Point finish, int thick, Color color)
        {
            point[0] = start;
            point[1] = finish;
            this.thick = thick;
            this.color = color;
        }

        public Point getPoint1()
        {
            return point[0];
        }

        public Point getPoint2()
        {
            return point[1];
        }
        public Color getColor()
        {
            return color;
        }
        public int getThick()
        {
            return thick;
        }
    }
}
