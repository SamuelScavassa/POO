using Exercicio1.Models;  /* --> importa classe fora do name space, executar uma ultima função e como um "alias" para dar 
apelidos */

namespace Exercicio1;

public class Program
{

    public static void Main()
    {

        Point point1 = new Point(1, 2);
        Console.WriteLine(point1.GetPoint());

        Point point2 = new Point(2, 4);
        Console.WriteLine(point2.GetPoint());

        Console.Write($"A distacia do P1 para P2 é:{point1.DistanceTo(point2)} \n");

        Point3D point3 = new Point3D(1, 2, 4);
        Console.WriteLine(point3.GetPoint());

        Point point4 = new Point3D(3, 4, 5);
        Console.WriteLine(point4.GetPoint());

        Point3D point5 = (Point3D)point4; /*<-Força conversão*/
        Console.WriteLine(point5.GetPoint());


    }

}