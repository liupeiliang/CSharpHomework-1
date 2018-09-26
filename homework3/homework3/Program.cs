using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public abstract class Graph
    {
        public abstract double size();
    }
    public class Triangle : Graph   //三角形类
    {
        private int side1, side2, side3;
        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double size()
        {
            double p = 0.5 * (side1 + side2 + side3);
            return System.Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
    }
    public class Circle : Graph     //圆形类
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double size()
        {
            return System.Math.PI * radius * radius;
        }
    }
    public class Square : Graph     //正方形类
    {
        private int side;
        public Square(int side)
        {
            this.side = side;
        }
        public override double size()
        {
            return side * side;
        }
    }
    public class Rectangle : Graph     //长方形类
    {
        private int length, height;
        public Rectangle(int length, int height)
        {
            this.length = length;
            this.height = height;
        }
        public override double size()
        {
            return length * height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Circle circle = new Circle(2);
            Square square = new Square(2);
            Rectangle rectangle = new Rectangle(4, 2);
            Console.Write("三角形面积：" + triangle.size() + "\n" + "圆形面积：" + circle.size() + "\n" + "正方形面积：" + square.size() + "\n" + "长方形面积：" + rectangle.size());
        }
    }
}
