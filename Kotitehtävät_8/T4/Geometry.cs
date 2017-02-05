using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public abstract class Shape
    {
        public string Nimi { get; set; }
        public Shape(string name)
        {
            Nimi = name;
        }
        public abstract double Area();
        public abstract double Circumference();
        public abstract override string ToString();
    }
    public class Circle : Shape
    {
        private int Radius { get; set; }
        public Circle(string name, int radius) : base(name)
        {
            Radius = radius;
        }
        public override double Area()
        {
            
            double areafull = Math.PI * Math.Pow(Radius, 2);
            return areafull = Math.Round(areafull, 2, MidpointRounding.AwayFromZero);
        }
        public override double Circumference()
        {
            double circumferencefull = 2 * Math.PI * Radius;
            return circumferencefull = Math.Round(circumferencefull, 2, MidpointRounding.AwayFromZero);
        }
        public override string ToString()
        {
            return Nimi + ", Radius: " + Radius;
        }
    }
    public class Rectangle : Shape
    {
        private int Width { get; set; }
        private int Height { get; set; }
        public Rectangle(string name, int width, int height) : base(name)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            double areafull = Width * Height;
            return areafull = Math.Round(areafull, 2, MidpointRounding.AwayFromZero);
        }
        public override double Circumference()
        {
            double circumferencefull = Width + Width + Height + Height;
            return circumferencefull = Math.Round(circumferencefull, 2, MidpointRounding.AwayFromZero);
        }
        public override string ToString()
        {
            return Nimi + ", Width: " + Width + ", Height: " + Height;
        }
    }

    public class Shapes
    {
        public List<Shape> Kuviot { get; }
        public Shapes()
        {
            Kuviot = new List<Shape>();
        }
        public void LisaaKuvio(Shape kuvio)
        {
            Kuviot.Add(kuvio);
        }
    }
}
