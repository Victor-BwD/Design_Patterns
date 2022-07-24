using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class LiuKang : IPersonagem
    {
        void IPersonagem.Escolhido()
        {
            Console.WriteLine("Liu Kang");
        }
    }
}
