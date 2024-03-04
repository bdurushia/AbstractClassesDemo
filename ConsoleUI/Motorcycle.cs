using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /* 
    * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
    * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
    * Provide the implementations for the abstract methods
    * Only in the Motorcycle class will you override the virtual drive method
    */
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"{Name} Motorcycle drives on only TWO WHEELS.\n");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"{Name} Drives REALLY FAST.\n");
        }
    }
}
