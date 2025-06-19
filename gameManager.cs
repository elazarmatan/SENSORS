using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public static class GameManager
{
    


    public static int roomRandom()
    {
        Random rand = new Random();
        int room = rand.Next(1, 10);
        return room;
    }
    public static void menu()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(
            "=======================\n"+
            "      SENSORS GAME\n"+
            "=======================\n"
            );
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("LEVEL 1");
        Console.WriteLine($"The agent continues in room {roomRandom()}");
        Console.ResetColor();
        Investigation.invest("agentRank1");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("LEVEL 2");
        Console.WriteLine($"The agent continues in room {roomRandom()}");
        Console.ResetColor();
        Investigation.invest("agentRank2");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("LEVEL 3");
        Console.WriteLine($"The agent continues in room {roomRandom()}");
        Console.ResetColor();
        Investigation.invest("agentRank3");


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("LEVEL 4");
        Console.WriteLine($"The agent continues in room {roomRandom()}");
        Console.ResetColor();
    }
}