using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj czas w sekundach: ");
        if (int.TryParse(Console.ReadLine(), out int czas))
        {
            string sformatowanyCzas = FormatujCzas(czas);
            Console.WriteLine("Sformatowany czas: " + sformatowanyCzas);
        }
        else
        {
            Console.WriteLine("Niepoprawna wartość.");
        }
    }

    static string FormatujCzas(int czas)
    {
        int godziny = czas / 3600;
        int minuty = (czas % 3600) / 60;
        int sekundy = czas % 60;

        string sGodziny = godziny.ToString("D2");
        string sMinuty = minuty.ToString("D2");
        string sSekundy = sekundy.ToString("D2");

        string sformatowanyCzas = $"{sGodziny}:{sMinuty}:{sSekundy}";

        return sformatowanyCzas;
    }
}