public abstract class Sensor
{
    public string name;
    protected bool active = false;
    public Sensor(string name)
    {
        this.name = name;
    }

    public abstract bool Activate();

   
}