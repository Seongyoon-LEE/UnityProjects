using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_03_CSharp
{

    internal class MainApp8
    {
        static void Main(string[] args)
        {
            var nameCard = new { name = "박상현", age = 17 };
            Console.WriteLine($"이름:{nameCard.name} 나이:{nameCard.age}");

            var complex = new { Real = 3, Imagnary = -12 };
            Console.WriteLine($"Real:{complex.Real}나이:{complex.Imagnary}");
        }
        }
    }
}
