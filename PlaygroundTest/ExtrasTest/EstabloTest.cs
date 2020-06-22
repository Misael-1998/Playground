using Playground.Extras;
using Xunit;
using Xunit.Abstractions;

namespace PlaygroundTest.ExtrasTest
{
    public class EstabloTest
    {
        private readonly ITestOutputHelper _console;

        private readonly Vaca[] _vacas =
        {
            new Vaca(0){ TipoDeVaca = Tipo.CARNE},
            new Vaca(1) {TipoDeVaca = Tipo.LECHERA},
            new Vaca(2){TipoDeVaca = Tipo.PARTERA},
            new Vaca(3){TipoDeVaca = Tipo.CUALQUIERA},
            new Vaca(4){TipoDeVaca = Tipo.CUALQUIERA},
            new Vaca(5){TipoDeVaca = Tipo.CUALQUIERA},
            new Vaca(0){ TipoDeVaca = Tipo.CARNE},
            new Vaca(1) {TipoDeVaca = Tipo.LECHERA},
            new Vaca(2){TipoDeVaca = Tipo.PARTERA},
            new Vaca(3){TipoDeVaca = Tipo.CUALQUIERA},
            new Vaca(6){ TipoDeVaca = Tipo.LECHERA},
            new Vaca(7) {TipoDeVaca = Tipo.LECHERA},
            new Vaca(8){TipoDeVaca = Tipo.LECHERA},
            new Vaca(9){TipoDeVaca = Tipo.CUALQUIERA},
        };

        public EstabloTest(ITestOutputHelper console)
        {
            _console = console;
        }

        [Fact]
        public void Deberia_Encontrar_Vaca_Por_Id()
        {
            var vaca = new Establo(_vacas).BuscarPorId(2);
            Assert.NotNull(vaca);
        }

        [Fact]
        public void No_Deberia_Encontrar_Vaca_Por_Id()
        {
            var vaca = new Establo(_vacas).BuscarPorId(5);
            Assert.NotNull(vaca);
        }

        [Fact]
        public void Deberia_Encontrar_Vaca()
        {
            bool seEncontro = new Establo(_vacas).VacaExiste(_vacas[2]);
            Assert.True(seEncontro, "La vaca con id 2 debio ser encontrada");
        }

        [Fact]
        public void No_Deberia_Encontrar_Vaca()
        {
            bool seEncontro = new Establo(_vacas).VacaExiste(new Vaca(8));
            Assert.False(seEncontro, "La vaca encontrada no existe y no deberia poder encontrarse");
        }

        [Fact]
        public void Deberian_Ser_Solo_Lecheras()
        {
            Vaca[] lecheras = new Establo(_vacas).ObtenerLecheras();
            var soloLecheras = true;
            foreach (var vaca in lecheras)
            {
                _console.WriteLine($"Vaca: {vaca.Id} es de tipo {vaca.TipoDeVaca}");
                if (vaca.TipoDeVaca == Tipo.LECHERA) continue;
                soloLecheras = false;
            }
            Assert.True(soloLecheras, "No todas las vacas son lecheras");
        }
        
        [Fact]
        public void Deberian_Estar_Ordenadas_Por_taza_De_Produccion()
        {
            Vaca[] vacas = new Establo(_vacas).OrdenarPorTazaDeProduccion();
            if (_vacas.Length != vacas.Length)
            {
                _console.WriteLine($"Habian {_vacas.Length} y ordenaste {vacas.Length}");
                Assert.True(false);
            }
            var ordenadas = true;
            string _base = "";
            float maximo = vacas[0].TazaDeProccion;
            for (var i = 1; i < _vacas.Length; i++)
            {
                if (maximo <= vacas[i].TazaDeProccion)
                {
                    maximo = vacas[i].TazaDeProccion;
                    _base += $"< {maximo}";
                }
                else
                {
                    ordenadas = false;
                    _base += $"!< {vacas[i].TazaDeProccion}";
                    break;
                }
            }
            _console.WriteLine(_base);
            Assert.True(ordenadas, "Las vacas no estan ordenadas de menor a mayor");
        }

    }
}