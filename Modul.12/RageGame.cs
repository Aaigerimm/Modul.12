using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul._12
{
    public class RaceGame
    {
        public event CarEventHandler RaceFinished;

        public void StartRace(Car[] cars)
        {
            foreach (var car in cars)
            {
                car.StartRace += Car_StartRace;
                car.FinishRace += Car_FinishRace;
            }

            Console.WriteLine("Гонка началась!");

            foreach (var car in cars)
            {
                car.Race();
            }
        }
        private void Car_StartRace(object sender, EventArgs e)
        {
            var car = sender as Car;
            Console.WriteLine($"{car.Name} начал гонку!");
        }

        private void Car_FinishRace(object sender, EventArgs e)
        {
            var car = sender as Car;
            Console.WriteLine($"{car.Name} финиш!");
            OnRaceFinished();
        }

        protected virtual void OnRaceFinished()
        {
            RaceFinished?.Invoke(this, EventArgs.Empty);
        }

