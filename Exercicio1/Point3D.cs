namespace Exercicio1.Models;

public class Point3D : Point
{
    public int z;

    public Point3D(int x, int y, int z) : base(x, y)
    {
        this.z = z;
    }

    new public string GetPoint()
    {
        return base.GetPoint() + $"e z:{z}\n";
    }



}

/* Sobrecarga mesmo nome do método com parametros dif / sobrescrita - interface/abstratas - polimorfismo */