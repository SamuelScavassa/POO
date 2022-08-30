namespace Exercicio1.Models;
using inteiro = System.Int32; /* Para dar apelidos*/

public class Point
{
    protected inteiro x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public string GetPoint()
    {
        return $"A posição de x:{x} e y:{y} ";
    }

    public double DistanceTo(Point other)
    {
        return Math.Sqrt(Math.Pow((x - other.x), 2) + Math.Pow((y - other.y), 2));
    }

}

