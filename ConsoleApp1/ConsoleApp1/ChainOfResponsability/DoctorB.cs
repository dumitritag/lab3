﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.ChainOfResponsability
{
    public class DoctorB : Investigate
    {
        public String investigatePacient()
        {
            return "Buna ziua! Ma numesc Lupu Cristian.";
        }
    }
}
