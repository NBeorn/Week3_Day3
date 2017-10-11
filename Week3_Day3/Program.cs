using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle baseVehicle = new Vehicle(4, 2000, "Green", 55.0d);

            //baseVehicle.Move();
            //Console.WriteLine(baseVehicle.DistanceTraveled);

            Automobile herbie = new Automobile(4, 13, 2, 4, 1500, "white", 88.0d);
            herbie.Move();
            herbie.Move();
            Console.WriteLine("Automobile Distance Travelled: " + herbie.DistanceTraveled);

            Boat boaty = new Boat(2, 500, "red", 88.0d, 0.9d);
            boaty.Move();
            boaty.Move();
            Console.WriteLine("Boat Distance Travelled: " + boaty.DistanceTraveled);
        }
    }
}
