using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1...3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            printer.Merk = nomorPrinter;

            //deklarasi objek
            IPrinter print;
            IPrinter show;

            //pengkondisian
            if (printer.Merk == 1)
            {
                print = new Epson();
                show = new Epson();
            }
            else if (printer.Merk == 2)
            {
                print = new Canon();
                show = new Canon();
            }
            else
            {
                print = new Laserjet();
                show = new Laserjet();
            }
            show.Show(printer);
            print.Print(printer);
            Console.ReadKey();
        }


    }
}