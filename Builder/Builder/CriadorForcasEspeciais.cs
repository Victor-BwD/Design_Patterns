using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CriadorForcasEspeciais : CriadorDeSoldado
    {
        public CriadorForcasEspeciais()
        {
            _soldado = new SoldadoForcaEspecial();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Combate terrestre");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Carro de operações especiais");
        }
    }
}
