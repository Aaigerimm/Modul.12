using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Modul._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sportsCar = new SportsCar("Спортивная машина");
            var sedanCar = new SedanCar("Легковая машина");
            var truck = new Truck("Грузовик");
            var bus = new Bus("Автобус");

            var raceGame = new RaceGame();
            raceGame.RaceFinished += RaceGame_RaceFinished;

            var cars = new Car[] { sportsCar, sedanCar, truck, bus };
            raceGame.StartRace(cars);

            Console.ReadKey();
        }
        private static void RaceGame_RaceFinished(object sender, EventArgs e)
        {
            Console.WriteLine("Гонка завершена!");
        }
    }
        
}
