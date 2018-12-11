using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.ChainOfResponsability
{
    public class DoctorC : Investigate
    {
        public String investigatePacient()
        {
            return "Buna ziua! Ma numesc Garaba Elena.";
        }
    }
}
