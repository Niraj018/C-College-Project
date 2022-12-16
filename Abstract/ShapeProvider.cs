using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class ShapeProvider
    {
        public Shape GetShapeObject(string shapeType)
        {
            switch (shapeType)
            {
                case "circle":
                    return new Circle(4);
                case "retangle":
                    return new Rectangle(5, 4);
                default:
                    return new Circle(4);
                    break;
            }
        }
    }
}
