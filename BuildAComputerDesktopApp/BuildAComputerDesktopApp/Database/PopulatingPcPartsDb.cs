using BuildAComputerDesktopApp.Classes;
using System;

namespace BuildAComputerDesktopApp.Database
{
    class PopulatingPcPartsDb
    {
        private static void InsertCPU(string name)
        {
            var popCPU = new CPU
            {
                brand = name
            };
            using (var context=new PcPartsContext())
            {
                context.CPU.Add(popCPU);
                context.SaveChanges();
                context.Database.Log = Console.WriteLine;
            }

        }
    }
}
