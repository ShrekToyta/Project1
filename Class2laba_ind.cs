using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_ind
{
    internal class Ellipsoid
    {

        public Ellipsoid(string name, double a, double b, double c)
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Ellipsoid()
        {

        }
        public string name { set; get; }
        public double a { set; get; }
        public double b { set; get; }
        public double c { set; get; }
        public double V()
        {
            return ((4.0 / 3.0) * Math.PI * a * b * c);
        }
        public double Area()
        {
            return Math.PI * a * b;

        }
        public void Read()
        {
            Console.WriteLine("Введите название:  ");
            name = Console.ReadLine();
            Console.WriteLine("Введите первую полуось");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую полуось");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью полуось");
            c = double.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Форма фигуры: {name}");
            Console.WriteLine($"Объем: {V()}");
            Console.WriteLine($"Площадь: {Area()}");

        }
    }
}
