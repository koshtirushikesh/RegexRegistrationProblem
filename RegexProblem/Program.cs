﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexPatten regexPatten = new RegexPatten();
            regexPatten.ValidateFirstName("Rushi");
            Console.ReadLine();

        }
    }
}