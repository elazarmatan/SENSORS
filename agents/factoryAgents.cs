using System.Collections.Generic;
using System;

public static class FactoryAgents
{
    public static List<string> listAgentsName()
    {
        List<string> Agentsame = new List<string>() { "agentRank1" };
        return Agentsame;
    }



    public static Dictionary<string, Type> Agents = new Dictionary<string, Type>
    {
     {"agentRank2",typeof(agentRank2)},
    };

    public static IranianAgent createAgent(string nameAgent)
    {
        Type type = FactoryAgents.Agents[nameAgent];
        IranianAgent agent = (IranianAgent)Activator.CreateInstance(type);
        return agent;
    }
}