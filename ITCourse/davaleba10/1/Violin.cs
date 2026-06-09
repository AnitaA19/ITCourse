using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.davaleba10._1
{
    public class Violin : MusicalInstrument
    {
        public Violin()
            : base(
                "Violin",
                "A string instrument played with a bow.",
                "The violin originated in Italy during the 16th century.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Violin sound: Viiiin Viiiin");
        }
    }
}
