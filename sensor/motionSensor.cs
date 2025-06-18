public class Motion : Sensor
{

    public Motion() : base("motion") { }

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