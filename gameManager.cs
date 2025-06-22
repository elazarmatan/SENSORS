using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public static class GameManager
{

    public static void PrintGameIntro()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // For emoji support
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔═════════════════════════════════════════════════════╗");
        Console.Write("║"); Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("      📡  ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("   Welcome to");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("  📡      ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║");
        Console.WriteLine("╠═════════════════════════════════════════════════════╣");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("║                   🌟  SENSORS  🌟                   ║");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╚═════════════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🕵️‍♂️ Step into the shoes of a skilled investigator in a tense battle against enemy agents.");
        Console.WriteLine("🔎 Your mission: Attach sensors, gather intelligence, and uncover your enemy's weaknesses!");
        Console.WriteLine("💡 Plan your moves carefully, use your advanced tools wisely, and reveal hidden secrets.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Will you be able to crack the code and expose your rivals' vulnerabilities? ⏳");
        Console.WriteLine("Good luck, Investigator! 🤝");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Press any key to begin...");
        Console.ResetColor();
        Console.ReadKey();
    }
    public static int roomRandom()
    {
        Random rand = new Random();
        int room = rand.Next(1, 10);
        return room;
    }
    public static void menu()
    {
        PrintGameIntro();

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