using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class ClownCar : RaceCar
    {
        public ClownCar()
        {
            Name = "Clown Car";
            TopSpeed = 150;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} backfires ballons out of the tailpipe as it starts");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} has no brake lines!");
            base.Brake();
        }

    }
}
