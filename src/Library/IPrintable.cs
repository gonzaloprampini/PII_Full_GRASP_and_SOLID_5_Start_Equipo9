  
namespace Full_GRASP_And_SOLID
{
    public interface IPrintable
    {
         /*
            Aplicamos esta interfaz buscando que el programa identifique los objetos IPrinter y los comunique con los IPrintable, 
            mediante la función PrintPrintable(), que recibirá un IPrintable.  
            De esta manera es posible que existan varias clases que sean "imprimibles", lo que quita rigidez y fragilidad al código.
        */
        string GetTextToPrint();
    }
}