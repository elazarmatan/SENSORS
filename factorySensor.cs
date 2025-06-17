using System.Collections.Generic;

public static class FactorySensor
{
    public static List<string> listOfweaknes()
    {
        List<string> sensorname = new List<string>() { "audio" };
        return sensorname;
    }

    public static List<Sensor> listOfpinned()
    {
        Audio a = new Audio();

        List<Sensor> sensors = new List<Sensor>() { a };
        return sensors;
    }
}