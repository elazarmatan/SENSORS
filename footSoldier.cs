using System;
using System.Collections.Generic;

public class footSoldier: IranianAgent
{
    public footSoldier(string name, List<Sensor> sensors) : base(name,"foot soldier") 
    {
        Random rand = new Random();
        int weak1 = rand.Next(sensors.Count);
        int weak2 = rand.Next(sensors.Count);
        this.weaknes = new Sensor[] { sensors[weak1], sensors[weak2] };
        this.empty = new Sensor[2];
    }
}