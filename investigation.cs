using System.Collections.Generic;

public static  class Investigation
{
    public static void invest()
    {
        List<string> sensors = new List<string>() { "audio" };
        IranianAgent age = new agentRank1("faruk");
        List<string> weaknes = age.createWeaknes(sensors,2);
    }
}