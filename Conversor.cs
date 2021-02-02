namespace POO___Static
{
    public static class Conversor
    {
        //Classes estaticas não podem ser instanciadas 
        private static float cotacaoDolar = 5.07f;

        public static float RealParaDolar(float valorRS){
                return valorRS / cotacaoDolar;
        }

        public static float DolarParaReal(float valorDolar){
            return valorDolar * cotacaoDolar;
        }

    }
}