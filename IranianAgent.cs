using System;
using System.Collections.Generic;

public abstract class IranianAgent
{
    public string name;
    protected string rank;
    public int id;
    public List<string> weaknes = new List<string>();
    public List<Sensor> Pinned = new List<Sensor>();
    public Dictionary<string, int> weaknesDict;

    public IranianAgent(string name,string rank,int id)
    {
        this.name = name;
        this.rank = rank;
        this.id = id;
    }

    public List<Sensor> getSensor(List<Sensor> sensors, int range)
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

        printList(Pinned);
        return Pinned;
    }


    public  List<Sensor> pinnedSensor(Sensor s)
    {
        Pinned.Add(s);
        return Pinned;
    }

    public Dictionary<string, int> convertListToDictionary(List<string> weakness)
    {
        Dictionary<string, int> weaknesDict = new Dictionary<string, int>();
        for (int i = 0; i < weakness.Count; i++)
        {
            string key = weakness[i];

            if (weaknesDict.ContainsKey(key))
            {
                weaknesDict[key]++; 
            }
            else
            {
                weaknesDict[key] = 1;
            }
        }

        foreach(var sens in weaknesDict)
        {
            Console.WriteLine($"{sens.Key}:{sens.Value}");
        }
        

        return weaknesDict;
    }

    public void f()
    {
        this.weaknesDict = convertListToDictionary(weaknes);
    }



    public List<string> createWeaknes(List<string> sensors,int range)
    {
        
        Random rand = new Random();
        for(int i = 0;i < range;i++)
        {
            int weak1 = rand.Next(sensors.Count);
            this.weaknes.Add(sensors[weak1]);
        }
        return this.weaknes;
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