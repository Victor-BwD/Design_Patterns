using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton {
        private static Singleton instance = null;

        public static Singleton GetInstance {
            get {
                if(instance == null) {
                    instance = new Singleton();
                    Console.WriteLine("Bola em jogo");
                }
                return instance;
            }
        }

        public void Mensagem(string msg) {
            Console.WriteLine(msg);
        }
    }
}
