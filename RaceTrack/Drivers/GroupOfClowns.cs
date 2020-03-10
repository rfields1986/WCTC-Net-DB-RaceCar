using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class GroupOfClowns : Driver
    {
        public GroupOfClowns(RaceCar car) : base(car)
        {
            Name = "Group of Clowns";
            SkillLevel = 1;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
