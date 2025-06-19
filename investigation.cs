using System;
using System.Collections.Generic;

public static  class Investigation
{
    
    public static void invest(string typeAgent)
    {
        List<string> sensorname = FactorySensor.listSensorName();
        IranianAgent age = FactoryAgents.createAgent(typeAgent);
        List<string> weaknes = Investigation.createWeaknes(sensorname, age.sensorSlots);
        int required = age.sensorSlots;
        
        int counter = 0;
        bool flag = false;
        age.pinnedSensor(sensorname, age.sensorSlots);
        while (!flag)
        {
            int succes;
            counter++;
            if (age is IAttack attacker) 
            {
                if (counter % 3 == 0 && counter != 0)
                {
                    attacker.Attack(age);
                }
            }
            if (checkActive(age.Pinned))
            {
                succes = Investigation.contains(age, weaknes,sensorname);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"succes {succes}/{required}");
                Console.ResetColor();
                if (succes == required)
                {
                    flag = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(
                                      "WELL DONE, YOU EXPOSED THE AGENT!\n"+
                                      "================================="
                        );
                    Console.ResetColor();
                }
                else
                {
                    age.changePinned(age.sensorSlots, succes, sensorname);
                }
            }
            else
            {
                Console.WriteLine("THE SENSOR BREAK");
                invest($"agentRank{age.sensorSlots}");
                flag = true;
            }
        }
    }

    






    public static bool checkActive(List<Sensor> pinned)
    {
        foreach (Sensor s in pinned)
        {
            if (!s.Activate())
                return false;
        }
        return true; 
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

        


        return weaknesDict;
    }



    public static int contains(IranianAgent agent, List<string> weakness,List<string>sensors)
    {


        Dictionary<string, int> weaknesDict = convertListToDictionary(weakness);
        int succes = 0;
        for(int i = 0;i< agent.Pinned.Count;i++)
        {
            if (weaknesDict.ContainsKey(agent.Pinned[i].name))
            {
                if (weaknesDict[agent.Pinned[i].name] != 0)
                {
                    weaknesDict[agent.Pinned[i].name] --;
                    succes++;
                    
                }
            }

        }

        return succes;
    }
    
}