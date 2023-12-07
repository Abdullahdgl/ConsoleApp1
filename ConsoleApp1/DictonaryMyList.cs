using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonaryMyList
{
  public  class DictonaryMyList<K, V>

    {
        K[] itemsKey;
        V[] itemsValue;
        public DictonaryMyList()
        {
            itemsKey = new K[0];
            itemsValue = new V[0];
        }
        
        public void Add(K key, V value)

        {
            K[] tempKeys = itemsKey;
            V[] tempValues = itemsValue;

            itemsKey= new K[tempKeys.Length + 1 ];
            itemsValue = new V[tempValues.Length + 1 ];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                itemsKey[i] = tempKeys[i];
                itemsValue[i] = tempValues[i];
            }

            itemsKey[itemsKey.Length - 1] = key;
            itemsValue[itemsKey.Length - 1] = value;






        }




    }
}
