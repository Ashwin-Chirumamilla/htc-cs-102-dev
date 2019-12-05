using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication1
{
    class PongBall : Shape
    {
        protected override Geometry DefiningGeometry
        {
            get
            {
                return new EllipseGeometry(new System.Windows.Point(X,Y), 10, 10);
            }
        }

        public double xVelocity = 20;
        public double yVelocity = 20;
        public double X = 257;
        public double Y = 162;

        
    }
}
