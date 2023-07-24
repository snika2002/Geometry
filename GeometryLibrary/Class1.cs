using System;

namespace GeometryLibrary
{
        //Класс описывающий окружность
    public class Circle
    {
        //Радиус окружности
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        //Площадь
        public double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }

    //Класс описывающий треугольник
    public class Triangle
    {
        //Стороны треугольника
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //Площадь
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //Проверка является ли треугольник прямоугольным
        public bool ThisRectangular()
        {
            double Hypotenuse;
            double sum = 0;
            if (a > b)
            {
                Hypotenuse = a;
                sum += Math.Pow(b, 2);
            }
            else
            {
                Hypotenuse = b;
                sum += Math.Pow(a, 2);
            }
            if(Hypotenuse > c)
            {
                sum += Math.Pow(c, 2);
            }
            else
            {
                sum += Math.Pow(Hypotenuse, 2);
                Hypotenuse = c;
                
            }
            if (Math.Pow(Hypotenuse, 2) == sum)
            {
                return true;
            }
            else return false;
        }
    }

    //Класс производящий действия над фигурами
    public static class Calculation{

        //Выполняет операцию над фигурой, если у ее класса есть метод Area
        public static double CalculateTheArea(Object figure)
        {
            var type = figure.GetType();
            if (type.GetMethod("Area") != null)
            {
                return (double)type.GetMethod("Area").Invoke(figure, null);
            }
            else return -1;
        }

        //Выполняет операцию над фигурой, если у ее класса есть метод ThisRectangular
        public static bool ThisRectangular(object figure)
        {
            var type = figure.GetType();
            if (type.GetMethod("ThisRectangular") != null)
            {
                return (bool)type.GetMethod("ThisRectangular").Invoke(figure, null);
            }
            else return false;
        }

    }
}
