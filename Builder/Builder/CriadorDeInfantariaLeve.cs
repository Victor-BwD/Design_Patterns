using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aéreo");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Resposta rápida aérea");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicóptero de ataque do exército");
        }
    }
}
