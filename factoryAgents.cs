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
     {"agentRank1",typeof(agentRank1)},
     //{ "Rank4Agent",typeof(Rank4Agent)},
     //{ "Rank6Agent",typeof(Rank6Agent)},
     //{ "Rank8Agent",typeof(Rank8Agent)}


    };

    public static IranianAgent createAgent(string nameAgent,string name)
    {
        Type type = FactoryAgents.Agents[nameAgent];
        IranianAgent agent = (IranianAgent)Activator.CreateInstance(type,name);
        return agent;
    }
}