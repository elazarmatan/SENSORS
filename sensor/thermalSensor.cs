using System;
using System.Collections.Generic;

public class Thermal:Sensor
{
    public Thermal() : base("thermal") { }

    public override bool Activate()
    {
        return this.active = true;
    }

    public void action(List<string>weaknes)
    {
        Random rand = new Random();
        int weak = rand.Next(weaknes.Count);
        Console.WriteLine(weaknes[weak]);

    }
}