using System;

public class agentRank2 : IranianAgent
{
    public agentRank2() : base("agentRank2", 4)
    {

    }

    public override string atack(IranianAgent agent)
    {
        Random rand = new Random();
        int idx = rand.Next(agent.Pinned.Count);
        string sens = agent.Pinned[idx].name;
        agent.Pinned.RemoveAt(idx);
        return $"the sensor :{sens} deleted";
    }
}