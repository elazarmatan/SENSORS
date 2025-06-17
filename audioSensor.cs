public class Audio : Sensor
{
    
    public Audio() : base("audio") { }

    public override string Activate()
    {
        this.active = true;
        return this.name;
    }
}