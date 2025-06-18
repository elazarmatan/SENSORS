public class Audio : Sensor
{
    
    public Audio() : base("audio") { }

    public override bool Activate()
    {      
        return this.active = true;
    }
}