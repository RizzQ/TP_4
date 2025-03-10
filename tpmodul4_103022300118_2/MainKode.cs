using System;

class Program
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine();

        while (true) 
        {
            Console.WriteLine("\nKetik 'buka' untuk membuka pintu, 'kunci' untuk mengunci pintu, atau 'exit' untuk keluar:");
            Console.Write("Masukkan perintah: ");
            string input = Console.ReadLine().ToLower();

            if (input == "buka")
            {
                pintu.BukaPintu();
            }
            else if (input == "kunci")
            {
                pintu.KunciPintu();
            }
            else if (input == "exit")
            {
                Console.WriteLine("Program selesai.");
                break;
            }
            else
            {
                Console.WriteLine("Perintah tidak dikenal. Silakan ketik 'buka', 'kunci', atau 'exit'.");
            }
        }
    }
}
