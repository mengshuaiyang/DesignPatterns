using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class ShapeFactory
    {
        public static IShape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circular:
                    return new Circular();
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Square:
                    return new Square();
                default:
                    throw new Exception("不存在此类型");
            }
        }

        public enum ShapeType
        {
            Circular,
            Rectangle,
            Square
        }
    }
}
