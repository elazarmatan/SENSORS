using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENSORS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Audio a = new Audio();
            List<string> sensorname = new List<string>() {"audio"};
            List<Sensor> sensors = new List<Sensor>() {a};
            IranianAgent age = Investigation.investRank1(sensorname, sensors);
            age.getSensor(sensors, 2);
        }
    }
}
