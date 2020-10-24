using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;

namespace dz_3
{

    public abstract class GeometricFigure
    {
        public abstract float Area();
        
        public abstract float Perimetr();
    }
    class Triangle : GeometricFigure
    {
        private int side_a;
        private int side_b;
        private int side_c;

        Triangle(int Side_a, int Side_b, int Side_c)
        {
            this.side_a = Side_a;
            this.side_b = Side_b;
            this.side_c = Side_c;
        }
        public override float Area()
        {
            return side_a + side_b + side_c * 2;
        }
        public override float Perimetr()
        {
            return side_a + side_b + side_c;
        }
    }
    class Square : GeometricFigure
    {
        private int side_a;
        Square(int Side_a)
        {
            this.side_a = Side_a;
        }

        public override float Area()
        {
            return side_a * side_a;
        }

        public override float Perimetr()
        {
            return side_a * 4;
        }
    }
    class Rhombus : GeometricFigure
    {
        private int side_a;
        Rhombus(int Side_a)
        {
            this.side_a = Side_a;
        }

        public override float Area()
        {
            return side_a * 2;
        }

        public override float Perimetr()
        {
            return side_a * 4;
        }
    }
    class Rectangle : GeometricFigure
    {
        private int side_a;
        private int side_b;

        Rectangle(int Side_a, int Side_b)
        {
            this.side_a = Side_a;
            this.side_b = Side_b;
        }

        public override float Area()
        {
            return side_b * side_a;
        }

        public override float Perimetr()
        {
            return side_a * 2 + side_b * 2;
        }
    }
    class Circle : GeometricFigure
    {
        private float radius;

        public Circle(float Radius)
        {
            this.radius = Radius;
        }

        public override float Area()
        {
            return (float)(3.1415 * (radius * 2));
        }

        public override float Perimetr()
        {
            return (float)(2 * 3.14 * radius);
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {

            Circle Planet = new Circle(4);

            Console.WriteLine(Planet.Perimetr());
        }
    }
}
