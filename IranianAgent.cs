public abstract class IranianAgent
{
    protected string name;
    protected string rank;
    protected Sensor[] weaknes;
    protected Sensor[] empty;

    public IranianAgent(string name,string rank)
    {
        this.name = name;
        this.rank = rank;
    }
}