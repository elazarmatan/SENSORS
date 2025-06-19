using System.Collections.Generic;
using System;

public static class FactoryAgents
{
   



    public static Dictionary<string, Type> Agents = new Dictionary<string, Type>
    {
     {"agentRank2",typeof(agentRank2)},
     {"agentRank3",typeof(agentRank3)},
    };

    public static IranianAgent createAgent(string nameAgent)
    {
        Type type = FactoryAgents.Agents[nameAgent];
        IranianAgent agent = (IranianAgent)Activator.CreateInstance(type);
        return agent;
    }
}