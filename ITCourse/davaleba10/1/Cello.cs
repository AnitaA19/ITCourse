using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.davaleba10._1
{
    public class Cello : MusicalInstrument
    {
        public Cello()
            : base(
                "Cello",
                "A large string instrument from the violin family.",
                "The cello was developed in Europe during the 16th century.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Cello sound: Voooom Voooom");
        }
    }
}
