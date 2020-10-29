using System;


namespace Cola
{
    class Cola
    {
        int Max;
        int Frente;
        int Final;
        int[] Arreglo;

        public Cola(int tamaño)
        {
            //Declaracion de las variables de control
            //El maximo de elementos que se podran ingresar
            Max = tamaño;
            //El arreglo con "tamaño" elementos.
            Arreglo = new int[tamaño];
        }

        private bool EstaLlena()
        {
            //Comprueba si el contador "Final" es igual que el tope
            if (Final == Max)
                return true;
            else
                return false;
        }

        private bool EstaVacia()
        {
            //Comprueba que el contador "Final" no sea 0
            if (Final == 0)
                return true;
            else
                return false;
        }

        public bool InsertarDato(int dato)
        {
            if (!EstaLlena())
            {
                //Condicion para que frente sea dato en la primera iteracion
                if (Final == 0)
                    Frente = dato;
                //Inserta el elemento datos en la posicion del contador "Final"
                Arreglo[Final] = dato;
                //Aunmento del contador "Final"
                Final = Final + 1;
                //Console.WriteLine("Elemento {0}, insertado exitosamente", dato);
                return true;
            }
            else
                //Console.WriteLine("Elemento {0}, no ha sido insertado",dato);
                return false;
        }

        public bool Eliminar()
        {
            //Comprueba que no este vacia
            if (!EstaVacia())
            {
                //En caso de que la cola tiene un solo elemento
                if (Frente == Final)
                {
                    //Reinicimos la cola
                    Frente = 0;
                    Final = 0;
                }
                else
                {
                    //Frente se vuelve el sig elemento
                    Frente = Arreglo[1];
                    //Ciclo para reordenar
                    for (int i = 0; i < Max-1; i++)
                    {
                        //Condicion para no desbordar
                        if (i+1<Max-1)
                            //Elemento en la posicion n es = a la posicion n+1
                            Arreglo[i] = Arreglo[i + 1];
                        //Elemento en la ultima posicion es igual a 0
                          if (i == Final)
                            Arreglo[i] = 0;
                    }
                    //Decremento de contador
                    Final -= 1;
                }
                //Si se elimino el elemento
                return true;
            }
            else
                //No se elimino el elemento
                return false;
        }

        public string Mostrar()
        {

            string resultado = "\n";
            
            //Comprobacion de cola vacia
            if (!EstaVacia())
            {
                //Ciclo para imprimir elementos
                for (int i = 0; i < Final; i++)
                {
                    Console.WriteLine("i = {0}, {1}", i, Arreglo[i]);
                    resultado = resultado + i + Arreglo[i];
                }
            }
            else
            {
                //Si la cola esta vacia, mostrara este mensaje
                //Console.WriteLine("Cola Vacia");
                resultado = "Cola Vacia";
            }

            //Console.WriteLine("Elemento al inicio {0}, Contador {1}, Tope {2}",Frente,Final,Max);
            resultado = resultado + "   " + Frente;
            resultado = resultado + Final;
            resultado = resultado + Max;
            return resultado;
        }

        public void Vaciar()
        {
            //Console.WriteLine("Vaciando Cola...");
            //Reinicia el contador "Final"
            Frente = 0;
            Final = 0;
        }
    }
}
