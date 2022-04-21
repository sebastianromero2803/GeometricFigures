using System;
using System.Collections.Generic;

namespace GeometricFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu(LoadFigures());
        }

        static List<Figure> LoadFigures()
        {
            List<Figure> figureList = new();
            figureList.Add(new Circle(3));
            figureList.Add(new Elipse(3, 3));
            figureList.Add(new Rectangle(4, 5));
            figureList.Add(new Square(5));
            figureList.Add(new Triangle(3, 5));
            return figureList;
        }

        public static void ShowMenu(List<Figure> figureList)
        {
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("**** MENU ****");
                Console.WriteLine();
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine();

                figureList.ForEach(figure => Console.WriteLine(figure.GetType().ToString().Split('.')[1]));

                Console.WriteLine();
                Console.WriteLine("Salir");
                Console.WriteLine();
                Console.Write("Opcion: ");
                option = Console.ReadLine();
                Console.WriteLine();


                switch (option)
                {
                    case "Circle":
                        Console.WriteLine("Ingrese el radio del circulo: ");
                        int radio = int.Parse(Console.ReadLine());
                        Circle circle = new Circle(radio);
                        Console.WriteLine(circle.CalculateArea());
                        break;
                    case "Elipse":
                        Console.WriteLine("Ingrese los radios del elipse: ");
                        int radio1 = int.Parse(Console.ReadLine());
                        int radio2 = int.Parse(Console.ReadLine());
                        Elipse elipse = new Elipse(radio1, radio2);
                        Console.WriteLine(elipse.CalculateArea());
                        break;
                    case "Rectangle":
                        Console.WriteLine("Ingrese los lados del rectangulo: ");
                        int lado1 = int.Parse(Console.ReadLine());
                        int lado2 = int.Parse(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(lado1, lado2);
                        Console.WriteLine(rectangle.CalculateArea());
                        break;
                    case "Square":
                        Console.WriteLine("Ingrese el lado del cuadrado: ");
                        int lado = int.Parse(Console.ReadLine());
                        Square square = new Square(lado);
                        Console.WriteLine(square.CalculateArea());
                        break;
                    case "Triangle":
                        Console.WriteLine("Ingrese la base y la altura del triángulo: ");
                        int @base = int.Parse(Console.ReadLine());
                        int height = int.Parse(Console.ReadLine());
                        Triangle triangle = new Triangle(@base, height);
                        Console.WriteLine(triangle.CalculateArea());
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            while (option != "Salir");
        }
    }
}
