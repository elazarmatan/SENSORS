public class Pulse : Sensor
{

    public Pulse() : base("pulse") { }

    public override bool Activate()
    {
        int counter = 0;
        if (counter % 3 == 0)
        {
            return this.active = false;
        }
        counter++;
        return this.active = true;
    }
}