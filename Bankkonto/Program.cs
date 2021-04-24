using Bankkonto.Classes.UI;
using System;
using System.Collections.Generic;

namespace Bankkonto
{
    class Program
    {            
        
        static void Main(string[] args)
        {
                List<Konto> kontos = new List<Konto>();
                MainMenu mm = new MainMenu();
                mm.PrintMenuFunction(kontos);
        }
    }
}
