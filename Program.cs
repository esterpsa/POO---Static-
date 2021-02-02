using System;

namespace POO___Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamamos nossa classe estatica, sem precisar estanciar
            Console.WriteLine( Conversor.DolarParaReal(4f) );


            Console.WriteLine( Conversor.RealParaDolar(50f) );

            //Exemplo classe Math
             Console.WriteLine( Math.Pow(2, 4) );

            Pedido p = new Pedido();
            p.Testar();

        }

        void Testar(){

        }

      
    }
}
