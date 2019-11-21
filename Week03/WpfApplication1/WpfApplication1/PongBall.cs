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
                throw new NotImplementedException();
            }
        }
        public double X
        {
            get
            {
                return this.DefiningGeometry.Bounds.Location.X;
            }
        }
    }
}
