using System;
using System.Collections.Generic;

public static class FactorySensor
{
    public static List<string> listSensorName()
    {
        List<string> sensorname = new List<string>() { "audio" };
        return sensorname;
    }

    

    public static Dictionary<string, Type> Sensors = new Dictionary<string, Type>
    {
     {"audio",typeof(Audio)},
     //{ "Rank4Agent",typeof(Rank4Agent)},
     //{ "Rank6Agent",typeof(Rank6Agent)},
     //{ "Rank8Agent",typeof(Rank8Agent)}


    };

    public static Sensor createSensor(string name)
    {
        Type type = FactorySensor.Sensors[name];
        Sensor sensor = (Sensor)Activator.CreateInstance(type);
        return sensor;
    }
}