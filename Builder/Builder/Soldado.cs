﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    public abstract class Soldado {
        public string Arma { get; protected set; }
        public string Transporte { get; protected set; }
        
        public string Foco { get; protected set; }

        public abstract void EscolherArma(string arma);
        public abstract void EscolherTransporte(string transporte);
        public abstract void DefinirFoco(string foco);

    }
}
