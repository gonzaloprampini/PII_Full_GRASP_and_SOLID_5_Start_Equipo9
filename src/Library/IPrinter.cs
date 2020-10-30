namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
         /*
            Aplicamos esta interfaz buscando que el programa identifique los objetos IPrinter y los comunique con los IPrintable, 
            mediante la función PrintPrintable(), que recibirá un IPrintable.
            De esta manera es posible que existan muchos tipos distintos de impresoras y sea fácil acceder a sus métodos, 
            lo que quita rigidez y fragilidad al código
        */
        void PrintPrintable(IPrintable printable);
    }
}