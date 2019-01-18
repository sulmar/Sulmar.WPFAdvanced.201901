using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Sulmar.WPF.Advanced.WPFClient.CustomControls
{
    public class MyShape : Shape
    {
        protected override Geometry DefiningGeometry => GetMyShapeGeometry();


        private Geometry GetMyShapeGeometry()
        {
            StreamGeometry geometry = new StreamGeometry();

            using (StreamGeometryContext context = geometry.Open())
            {
                context.BeginFigure(new Point(0, 0), true, true);
                context.LineTo(new Point(50, 50), false, true);
                context.LineTo(new Point(75, 25), true, true);
            }

            geometry.Freeze();

            return geometry;
        }

    }
}
