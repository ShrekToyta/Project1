using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khudyakova_Lab_3
{
    internal class Vector
    {
        public double[] elem;

        
        public Vector(int size)
        {
            elem = new double[size];
        }

        public Vector(double[] values)
        {
            elem = values;
        }

        public Vector(Vector vector)
        {
            elem = vector.elem;
        }

        // cвойство для доступа к элементам массива
        public double this[int index]
        {
            get { return elem[index]; }
            set { elem[index] = value; }
        }

        // ввод с консоли
        public void ReadFromConsole()
        {
            for (int i = 0; i < elem.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                elem[i] = double.Parse(Console.ReadLine());
            }
        }

        // вывод вектора в виде строки
        public override string ToString()
        {
            return string.Join(", ", elem);
        }

        // метод для вычисления модуля вектора
        public double GetMagnitude()
        {
            return Math.Sqrt(elem.Select(e => e * e).Sum());
        }

        // метод для получения max элемента вектора
        public double GetMaxElement()
        {
            return elem.Max();
        }

        // метод для получения индекса min элемента вектора
        public int GetMinElementIndex()
        {
            return Array.IndexOf(elem, elem.Min());
        }

        // новый вектор, состоящий только из положительных элементов вектора
        public Vector GetPositiveElementsVector()
        {
            return new Vector(elem.Where(e => e > 0).ToArray());
        }

        // метод для сложения двух векторов
        public static Vector Add(Vector vec1, Vector vec2)
        {
            if (vec1.elem.Length != vec2.elem.Length)
            {
                throw new ArgumentException("Векторы должны быть одинаковой длины");
            }

            double[] result = new double[vec1.elem.Length];
            for (int i = 0; i < vec1.elem.Length; i++)
            {
                result[i] = vec1.elem[i] + vec2.elem[i];
            }

            return new Vector(result);
        }

        // метод для вычисления скалярного произведения двух векторов
        public static double DotProduct(Vector vec1, Vector vec2)
        {
            if (vec1.elem.Length != vec2.elem.Length)
            {
                throw new ArgumentException("\"Векторы должны быть одинаковой длины");
            }

            double result = 0;
            for (int i = 0; i < vec1.elem.Length; i++)
            {
                result += vec1.elem[i] * vec2.elem[i];
            }

            return result;
        }

        //метод для проверки двух векторов на равенство
        public static bool AreEqual(Vector vec1, Vector vec2)
        {
            if (vec1.elem.Length != vec2.elem.Length)
            {
                return false;
            }

            for (int i = 0; i < vec1.elem.Length; i++)
            {
                if (vec1.elem[i] != vec2.elem[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
