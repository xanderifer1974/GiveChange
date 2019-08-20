namespace GiveChange.Domain.Tests
{
    public static class DarTroco
    {
        
        public static double ReceberTroco(double valorProduto,double valorPago)
        {
            double valorTroco;
            return valorTroco = valorPago - valorProduto;

        }

        public static int TrocoNotas100(double valorProduto, double valorPago)
        {
            double valorTroco;
            int Nota100;
            Nota100 = 0;
            valorTroco = valorPago - valorProduto;

            while (valorTroco >= 100)
            {
                valorTroco -= 100;
                Nota100 ++;
            }

            return Nota100;
        }

        public static int TrocoNotas50(double valorProduto, double valorPago)
        {
            double valorTroco;
            int Nota50;
            Nota50 = 0;
            valorTroco = valorPago - valorProduto;

            while (valorTroco >= 50)
            {
                valorTroco -= 50;
                Nota50++;
            }

            return Nota50;
        }

        public static int TrocoNotas20(double valorProduto, double valorPago)
        {
            double valorTroco;
            int Nota20;
            Nota20 = 0;
            valorTroco = valorPago - valorProduto;

            while (valorTroco >= 20)
            {
                valorTroco -= 20;
                Nota20++;
            }

            return Nota20;
        }

        public static int TrocoNotas10(double valorProduto, double valorPago)
        {
            double valorTroco;
            int Nota10;
            Nota10 = 0;
            valorTroco = valorPago - valorProduto;

            while (valorTroco >= 10)
            {
                valorTroco -= 10;
                Nota10++;
            }

            return Nota10;
        }






    }
}
