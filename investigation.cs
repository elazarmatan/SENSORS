using System;
using System.Collections.Generic;

public static  class Investigation
{
    
    public static IranianAgent investRank1(List<string> sensorname, List<Sensor> sensors)
    {
        IranianAgent age = new agentRank1("faruk");
        List<string> weaknes = age.createWeaknes(sensorname,2);
        
        Dictionary<string, int> weaknesDict = age.convertListToDictionary(weaknes);
        return age;
    }


    
    

    public static bool contains(IranianAgent agent)
    {
        int required = agent.id;
        int count = 0;
        foreach (Sensor s in agent.Pinned) 
        {
            if (agent.weaknesDict.ContainsKey(s.Activate()))
            {
                Console.WriteLine("a");
                if (agent.weaknesDict[s.Activate()] != 0)
                {
                    Console.WriteLine("b");
                    agent.weaknesDict[s.Activate()] --;
                    count++;
                    Console.WriteLine($"succes {count} / {required}");
                    if(count == required)
                    {
                        Console.WriteLine("c");
                        return true;
                        
                    }
                }
            }
        }
        return false;
    }
}