using System;
using System.Collections.Generic;
using System.Text;

namespace MyHowest
{

    enum Graad
    {
        Voldoening,
        Onderschijding,
    }
    public class Student
    {
        public int Id { get; set; }
        public string Naam { get; set }
        public Graad AfstudeerGraad { get; set; }

        public override string ToString()
        {
            return $"De student met naam {Naam} is met {AfstudeerGraad} afgestudeerd";
        }
    }
}
