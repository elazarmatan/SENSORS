using System.Collections.Generic;
using System.Runtime.InteropServices;

public static class GameManager
{
    public static void game()
    {
        Audio a = new Audio();
        List<string> sensorname = new List<string>() { "audio" };
        List<Sensor> sensors = new List<Sensor>() { a };
        IranianAgent age = Investigation.investRank1(sensorname, sensors);
        age.getSensor(sensors, age.id);
        Investigation.contains(age);
    }
}