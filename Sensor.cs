public abstract class Sensor
{
    protected string name;
    public Sensor(string name)
    {
        this.name = name;
    }

    public abstract string Activate();

   
}