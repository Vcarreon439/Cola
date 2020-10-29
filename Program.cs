using System;


namespace Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola Objn = new Cola(3);
            Objn.InsertarDato(1);
            Objn.InsertarDato(2);
            Objn.InsertarDato(3);
            Objn.Eliminar();
            Console.WriteLine(Objn.Mostrar());
            Objn.Vaciar();
            Console.WriteLine(Objn.Mostrar());
            Objn.InsertarDato(4);
            Objn.InsertarDato(5);
            Objn.InsertarDato(6);
            Objn.InsertarDato(7);
            Console.WriteLine(Objn.Mostrar());
            Console.ReadKey();
        }
    }
}
