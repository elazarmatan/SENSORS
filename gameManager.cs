using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public static class GameManager
{
    public static void game()
    {
        List<string> sensorname = FactorySensor.listOfweaknes();
        List<Sensor> sensors = FactorySensor.listOfpinned();
        Console.WriteLine("name");
        string name = Console.ReadLine();
        IranianAgent age = Investigation.investRank1(name);
        List<string> weaknes = Investigation.createWeaknes(sensorname, age.id);
        age.getSensor(sensors, age.id);
        Investigation.contains(age,weaknes);
    }

    public static void menu()
    {
        Console.WriteLine(
            "=======================\n"+
            "      SENSORS GAME\n"+
            "=======================\n"
            );

        Console.WriteLine("LEVEL 1");
        GameManager.game();
    }
}