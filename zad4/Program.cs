using System;

class Program
{
    static void Main()
    {
        int[,] tablica = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        ZnajdzNajbardziejZblizoneWiersze(tablica, out int pierwszyWiersz, out int drugiWiersz);

        Console.WriteLine("Najbardziej zbliżone wiersze: {0} i {1}", pierwszyWiersz, drugiWiersz);
    }

    static void ZnajdzNajbardziejZblizoneWiersze(int[,] tablica, out int pierwszyWiersz, out int drugiWiersz)
    {
        int iloscWierszy = tablica.GetLength(0);

        int najmniejszaRoznica = int.MaxValue;
        pierwszyWiersz = 0;
        drugiWiersz = 0;

        for (int i = 0; i < iloscWierszy - 1; i++)
        {
            for (int j = i + 1; j < iloscWierszy; j++)
            {
                int roznica = ObliczMiareZroznicowania(tablica, i, j);

                if (roznica < najmniejszaRoznica)
                {
                    najmniejszaRoznica = roznica;
                    pierwszyWiersz = i;
                    drugiWiersz = j;
                }
            }
        }
    }

    static int ObliczMiareZroznicowania(int[,] tablica, int i, int j)
    {
        int iloscKolumn = tablica.GetLength(1);

        int roznica = 0;

        for (int k = 0; k < iloscKolumn; k++)
        {
            int aik = tablica[i, k];
            int ajk = tablica[j, k];
            roznica += (aik - ajk) * (aik - ajk);
        }

        return roznica;
    }
}
