using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.davaleba10._1
{
    public class MusicalInstrument
    {
        protected string Name;
        protected string Description;
        protected string HistoryInfo;

        public MusicalInstrument(string name, string description, string historyInfo)
        {
            Name = name;
            Description = description;
            HistoryInfo = historyInfo;

            Console.WriteLine($"Musical instrument created: {Name}");
        }

        public virtual void Sound()
        {
            Console.WriteLine("Instrument sound.");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }

        public virtual void History()
        {
            Console.WriteLine($"History: {HistoryInfo}");
        }
    }
}
