public class Audio : Sensor
{
    
    public Audio() : base("audio") { }

    public override string Activate()
    {
       
        return this.name;
    }
}