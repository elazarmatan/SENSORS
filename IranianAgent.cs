using System;
using System.Collections.Generic;

public abstract class IranianAgent
{
    public string name;
    protected string rank;
    public int id;
    public List<Sensor> Pinned = new List<Sensor>();

    public IranianAgent(string name,string rank,int id)
    {
        this.name = name;
        this.rank = rank;
        this.id = id;
    }

    public void getSensor(List<Sensor> sensors, int range)
    {
        for (int i = 0; i < sensors.Count; i++)
        {
            Console.WriteLine($"{sensors[i].Activate()} {i + 1}");
        }
        for (int i = 0; i < range; i++)
        {
            Console.WriteLine("enter your choice");
            int id = int.Parse(Console.ReadLine());
            pinnedSensor(sensors[id - 1]);
        }     
    }


    public  void pinnedSensor(Sensor s)
    {
        Pinned.Add(s);     
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