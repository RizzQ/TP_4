using System;

public class DoorMachine
{
    public enum DoorState
    {
        Terkunci,
        Terbuka
    }

    private DoorState currentState;

    public DoorMachine()
    {
        currentState = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (currentState == DoorState.Terkunci)
        {
            currentState = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka!");
        }
    }

    public void KunciPintu()
    {
        if (currentState == DoorState.Terbuka)
        {
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci!");
        }
    }
}
