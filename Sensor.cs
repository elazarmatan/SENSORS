public abstract class Sensor
{
    string name { get; }
    public Sensor(string name)
    {
        this.name = name;
    }

    public abstract bool Activate();
}