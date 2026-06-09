using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.davaleba10._1
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele()
            : base(
                "Ukulele",
                "A small string instrument similar to a guitar.",
                "The ukulele was developed in Hawaii in the 1880s.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Ukulele sound: Strum Strum");
        }
    }
}
