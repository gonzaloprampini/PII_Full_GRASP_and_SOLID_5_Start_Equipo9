using System;

namespace Full_GRASP_And_SOLID
{
    /*
        ConsolePrinter utiliza la intefraz IPrinter para comunicarse con Recipe(IPrintable), mediante el método PrintPrintable 
    */
    public class ConsolePrinter : IPrinter
    {
        public void PrintPrintable(IPrintable printable)
        {
            Console.WriteLine(printable.GetTextToPrint());
        }
    }
}