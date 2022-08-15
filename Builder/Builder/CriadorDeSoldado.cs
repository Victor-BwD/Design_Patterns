using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class CriadorDeSoldado
    {
        protected Soldado _soldado;

        public Soldado ObterSoldado()
        {
            return _soldado;
        }

        public abstract void Arma();
        public abstract void Transporte();
        public abstract void Foco();
    }
}
