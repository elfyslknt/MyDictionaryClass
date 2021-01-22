using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,P>
    {
        T[] Key;
        P[] Value;

        public MyDictionary()
        {
            Key = new T[0];
            Value = new P[0];
        }
        public void add(T key,P value)
        {
            T[] tempKey = Key;
            P[] tempValue = Value;
            Key = new T[Key.Length + 1];
            Value = new P[Value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Key[i] = tempKey[i];
                Value[i] = tempValue[i];
            }
            Key[Key.Length - 1] = key;
            Value[Value.Length - 1] = value;
          


        }

    }
}
