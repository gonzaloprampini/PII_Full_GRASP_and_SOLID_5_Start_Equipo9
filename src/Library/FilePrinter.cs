using System.IO;

namespace Full_GRASP_And_SOLID
{
    /*
        FilePrinter utiliza la intefraz IPrinter para comunicarse con Recipe(IPrintable), mediante el método PrintPrintable 
    */
    public class FilePrinter : IPrinter
    {

        public void PrintPrintable(IPrintable printable)
        {
            File.WriteAllText("Recipe.txt", printable.GetTextToPrint());
        }
    }
}