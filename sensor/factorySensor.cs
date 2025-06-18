using System;
using System.Collections.Generic;

public static class FactorySensor
{
    public static List<string> listSensorName()
    {
        List<string> sensorname = new List<string>() { "audio" ,"thermal", "pulse" , "motion" };
        return sensorname;
    }

    

    public static Dictionary<string, Type> Sensors = new Dictionary<string, Type>
    {
        {"audio",typeof(Audio)},
        {"thermal",typeof(Thermal)},
        {"pulse",typeof(Pulse)},
        {"motion",typeof(Motion)},
    };

    public static Sensor createSensor(string name)
    {
        Type type = FactorySensor.Sensors[name];
        Sensor sensor = (Sensor)Activator.CreateInstance(type);
        return sensor;
    }
}