using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    internal class MyDictionary<Tkey, TValue>
    {
        public KeyValuePair<Tkey, TValue>[] Cars;

        public MyDictionary()
        {
            Cars = new KeyValuePair<Tkey, TValue>[0];
        }
            
        public void Add(Tkey key, TValue value)
        {
            KeyValuePair<Tkey, TValue>[] tempArray = Cars;
            Cars =new KeyValuePair<Tkey, TValue>[Cars.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Cars[i] = tempArray[i];
            }
            Cars[Cars.Length - 1] = new KeyValuePair<Tkey, TValue>(key, value);
        }
    }
} 
