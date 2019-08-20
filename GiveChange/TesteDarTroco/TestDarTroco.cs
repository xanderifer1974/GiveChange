using GiveChange.Domain.Tests;
using Xunit;
using FluentAssertions;

namespace TesteDarTroco
{
    public class TestDarTroco
    {
        [Theory]
        [InlineData(100.00,380.00,280.00)]
        [InlineData(100.00, 50.00, -50.00)]
        public void TestaValorTroco(double vlProd,double vlPago, double troco)
        {
            double resultado = DarTroco.ReceberTroco(vlProd, vlPago);
            resultado.Should().Be(troco, $"Troco não corresponde ao valor esperado({troco})");
        }

        [Theory]
        [InlineData(100.00, 500.00, 4)]
        [InlineData(100.00, 600.00, 5)]
        public void TestarTrocoNota100(double vlProd, double vlPago, int nota100)
        {
            double resultado = DarTroco.TrocoNotas100(vlProd, vlPago);
            resultado.Should().Be(nota100, $"Total de notas de 100 diferente do valor esperado({nota100})");
        }

        [Theory]
        [InlineData(100.00, 500.00, 8)]
        [InlineData(100.00, 600.00, 10)]
        public void TestarTrocoNota50(double vlProd, double vlPago, int nota50)
        {
            double resultado = DarTroco.TrocoNotas50(vlProd, vlPago);
            resultado.Should().Be(nota50, $"Total de notas de 50 diferente do valor esperado({nota50})");
        }

        [Theory]
        [InlineData(100.00, 500.00, 20)]
        [InlineData(100.00, 600.00, 25)]
        public void TestarTrocoNota20(double vlProd, double vlPago, int nota20)
        {
            double resultado = DarTroco.TrocoNotas20(vlProd, vlPago);
            resultado.Should().Be(nota20, $"Total de notas de 20 diferente do valor esperado({nota20})");
        }

        [Theory]
        [InlineData(100.00, 500.00, 40)]
        [InlineData(100.00, 600.00, 50)]
        public void TestarTrocoNota10(double vlProd, double vlPago, int nota10)
        {
            double resultado = DarTroco.TrocoNotas10(vlProd, vlPago);
            resultado.Should().Be(nota10, $"Total de notas de 20 diferente do valor esperado({nota10})");
        }




    }
}
