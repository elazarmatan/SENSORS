using System;
using System.Collections.Generic;

public static  class Investigation
{
    
    public static IranianAgent investRank1(string name)
    {
        IranianAgent age = new agentRank1(name);
        return age;
    }


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



    public static bool contains(IranianAgent agent, List<string> weakness)
    {


            Dictionary<string, int> weaknesDict = convertListToDictionary(weakness);
        int required = agent.id;
        int count = 0;
        foreach (Sensor s in agent.Pinned) 
        {
            if (weaknesDict.ContainsKey(s.Activate()))
            {
                if (weaknesDict[s.Activate()] != 0)
                {
                    weaknesDict[s.Activate()] --;
                    count++;
                    Console.WriteLine($"succes {count}/{required}");
                    if(count == required)
                    {
                        return true;
                        
                    }
                }
            }
        }
        return false;
    }
}