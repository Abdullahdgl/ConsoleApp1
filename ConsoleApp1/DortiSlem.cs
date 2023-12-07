using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonaryMyList
{
    public class DortiSlem
    {
        //aşağıdaki topla metodun aritmatik işlemler yapabilmekteyiz.
        //başka yerlerde
        public int topla(int x, int y)
        {
            return x+y;
        }

        //lakin void ile olan metotda ise bir işlem yapamayız.
        public void topla2(int x, int y)
        {
            Console.WriteLine(x+y);
          
        }

    }
}
