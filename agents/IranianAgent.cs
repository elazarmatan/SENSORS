using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;

public abstract class IranianAgent
{
    public string name;
    protected string rank;
    public int sensorSlots;
    public List<Sensor> Pinned = new List<Sensor>();

    public IranianAgent(string rank,int sensorSlots)
    {
        this.rank = rank;
        this.sensorSlots = sensorSlots;
    }

    public void pinnedSensor(List<string> sensors, int range)
    {
        for (int i = 0; i < sensors.Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{sensors[i]} : {i + 1}");
            Console.ResetColor();
        }
        for (int i = 0; i < range; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"You need {range} sensors to expose the agent\n" +
                "enter your choice");
            Console.ResetColor();
            int id = int.Parse(Console.ReadLine());
            Pinned.Add(FactorySensor.createSensor(sensors[id - 1]));
        }
    }


    public  void changePinned(int range,int succes, List<string> sensors)
    {
        for (int i = 0; i < Pinned.Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{Pinned[i]} : {i + 1}");
            Console.ResetColor();
        }
        for (int i = 0; i < range - succes; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("which sensor you want change enter your choice");
            Console.ResetColor();

            int idx = int.Parse(Console.ReadLine());
            for (int j = 0; j < sensors.Count; j++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{sensors[j]} : {j + 1}");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("enter your choice");
            Console.ResetColor();
            int idx2 = int.Parse(Console.ReadLine());
            Pinned[idx - 1] = FactorySensor.createSensor(sensors[idx2 - 1]);
        }

    }


   

}