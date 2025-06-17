﻿using System;
using System.Collections.Generic;

public abstract class IranianAgent
{
    public string name;
    protected string rank;
    public int sensorSlots;
    public List<Sensor> Pinned = new List<Sensor>();

    public IranianAgent(string name,string rank,int sensorSlots)
    {
        this.name = name;
        this.rank = rank;
        this.sensorSlots = sensorSlots;
    }

    public void pinnedSensor(List<Sensor> sensors, int range)
    {
        for (int i = 0; i < sensors.Count; i++)
        {
            Console.WriteLine($"{sensors[i].Activate()} {i + 1}");
        }
        for (int i = 0; i < range; i++)
        {
            Console.WriteLine("enter your choice");
            int id = int.Parse(Console.ReadLine());
            Pinned.Add(sensors[id - 1]);

        }     
    }


   

    

    


    




    //לניסוי בלבד
    public static void printList(List<Sensor>l)
    {
        for(int i = 0; i < l.Count; i++)
        {
            Console.WriteLine(l[i].Activate());
        }
    }
}