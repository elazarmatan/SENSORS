using System;
using System.Collections.Generic;

public static  class Investigation
{
    
    public static void invest(string typeAgent)
    {
        List<string> sensorname = FactorySensor.listSensorName();
        Console.WriteLine("name");
        string name = Console.ReadLine();
        IranianAgent age = FactoryAgents.createAgent(typeAgent, name);
        List<string> weaknes = Investigation.createWeaknes(sensorname, age.sensorSlots);
       
        bool flag = false;
        while (!flag)
        {
            age.pinnedSensor(sensorname, age.sensorSlots);
            if (checkActive(age.Pinned))
            {
                flag = Investigation.contains(age, weaknes, flag);
            }
        }
    }



    public static bool checkActive(List<Sensor> pinned)
    {
        bool flag = true;
        foreach(Sensor s in pinned)
        {
            if (s.Activate())
            {
                return flag;
            }
        }
        return flag = false;
    }


    //public static void activeSensor(List<Sensor> pinned)
    //{
        
    //    foreach(Sensor s in pinned)
    //    {
    //        s.Activate();
    //    }
    //}


    public static List<string> createWeaknes(List<string> sensors, int range)
    {
        List<string> weaknes = new List<string>();
        Random rand = new Random();
        for (int i = 0; i < range; i++)
        {
            int weak1 = rand.Next(sensors.Count);
            weaknes.Add(sensors[weak1]);
        }
        return weaknes;
    }

    public static Dictionary<string, int> convertListToDictionary(List<string> weakness)
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

        foreach (var sens in weaknesDict)
        {
            Console.WriteLine($"{sens.Key}:{sens.Value}");
        }


        return weaknesDict;
    }



    public static bool contains(IranianAgent agent, List<string> weakness,bool flag)
    {


            Dictionary<string, int> weaknesDict = convertListToDictionary(weakness);
        int required = agent.sensorSlots;
        int count = 0;
        foreach (Sensor s in agent.Pinned) 
        {
            if (weaknesDict.ContainsKey(s.name))
            {
                if (weaknesDict[s.name] != 0)
                {
                    weaknesDict[s.name] --;
                    count++;
                    Console.WriteLine($"succes {count}/{required}");
                    if(count == required)
                    {
                        flag = true;
                        return flag;
                        
                    }
                }
            }
        }
        return false;
    }
}