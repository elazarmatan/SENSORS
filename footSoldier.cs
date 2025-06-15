public class footSoldier: IranianAgent
{
    public footSoldier(string name) : base(name,"foot soldier") 
    {
        this.weaknes = new Sensor[2];
        this.empty = new Sensor[2];
    }
}