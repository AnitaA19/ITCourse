using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.davaleba10._1
{
    public class Trombone : MusicalInstrument
    {
        public Trombone()
            : base(
                "Trombone",
                "A brass wind instrument with a movable slide.",
                "The trombone appeared during the 15th century.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Trombone sound: Bwaaah Bwaaah");
        }
    }
}
