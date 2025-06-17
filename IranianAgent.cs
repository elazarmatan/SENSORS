using System;
using System.Collections.Generic;

public abstract class IranianAgent
{
    public string name;
    protected string rank;
    
    public List<string> weaknes = new List<string>();
    protected List<Sensor> Pinned { get; set; }

    public IranianAgent(string name,string rank)
    {
        this.name = name;
        this.rank = rank;
        
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
}