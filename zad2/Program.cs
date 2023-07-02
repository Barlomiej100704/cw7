using System;

class Program
{
    static void Main()
    {
        // Przykładowe użycie
        double x1 = 2.5;
        double y1 = 3.8;
        double x2 = -1.5;
        double y2 = 2.1;

        double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine("Długość odcinka: " + dlugosc);
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;

        double dlugosc = Math.Sqrt(dx * dx + dy * dy);

        return dlugosc;
    }
}
