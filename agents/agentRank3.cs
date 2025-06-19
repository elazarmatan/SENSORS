using System;

public class agentRank3:IranianAgent , IAttack
{
    public agentRank3() : base("agentRank3", 4)
    {

    }

    public  string Attack(IranianAgent agent)
    {
        Random rand = new Random();
        int idx1 = rand.Next(agent.Pinned.Count);
        string sens1 = agent.Pinned[idx1].name;
        agent.Pinned.RemoveAt(idx1);
        int idx2 = rand.Next(agent.Pinned.Count);
        string sens2 = agent.Pinned[idx2].name;
        agent.Pinned.RemoveAt(idx2);
        return $"the sensors :{sens1}  {sens2} deleted";
    }
}