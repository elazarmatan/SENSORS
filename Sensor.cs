public abstract class Sensor
{
    protected string name;
    protected bool active = false;
    public Sensor(string name)
    {
        this.name = name;
    }

    public abstract string Activate();

   
}