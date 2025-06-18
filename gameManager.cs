using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public static class GameManager
{
    public static void game()
    {
        Investigation.invest("agentRank1");
    }



    public static void menu()
    {
        Console.WriteLine(
            "=======================\n"+
            "      SENSORS GAME\n"+
            "=======================\n"
            );

        Console.WriteLine("LEVEL 1");
    }
}