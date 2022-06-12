using Mars_Rover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMap marsMap;
            Rover rover;

            marsMap = new Map(4, 4);

            rover = new Rover(marsMap, 0, 0, "E", "ALARALARALA");

            Console.WriteLine("Rover's initial coordinates and direction: 0,0,E" );
            Console.WriteLine("Rover's instructions: ALARALARALA");
            Console.WriteLine("Orders are valid?, New Direction, New coordinates: " + rover.ValidateOrders());

            Console.ReadLine();

        }
    }
}
