using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyDictionary
{
    public class DictionaryManager<K , V>
    {
        K[] _keys;
        V[] _values;

        public DictionaryManager()
        {

            _keys = new K[0];
            _values = new V[0];
        }

        public void Add(K key ,V value)
        {
            K[] _tempKey = _keys;
            V[] _tempValues = _values;

            _keys = new K[_keys.Length + 1];
            _values = new V[_values.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _keys[i] = _tempKey[i];
                _values[i] = _tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

        }
   
       

        public void listeleme()
        {
            for (int a = 0; a < _keys.Length; a++)
            {
                Console.WriteLine(" Key : {0} | Value : {1} ", _keys[a] , _values[a]);
            }

        }

      

        public int Length
        {
            get { return _keys.Length; }
           
        }

       

    }

}
