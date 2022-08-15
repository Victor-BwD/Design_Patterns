using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SoldadoForcaEspecial : Soldado {
        public override void DefinirFoco(string foco) {
            Foco = foco;
        }

        public override void EscolherArma(string arma) {
            Arma = arma;
        }

        public override void EscolherTransporte(string transporte) {
            Transporte = transporte;
        }
    }
}
