using System;

class MainKode
{
    static void Main()
    {
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        string kodePos = KodePos.GetKodePos(kelurahan);
        Console.WriteLine($"Kode pos untuk {kelurahan} adalah: {kodePos}");
    }
}
