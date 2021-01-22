using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<S1, S2>
    {
        S1[] _key;
        S2[] _value;
        S1[] _tempKey;
        S2[] _tempValue;


        public MyDictionary()
        {
            _key = new S1[0];
            _value = new S2[0];
        }

        public void Add(S1 item1, S2 item2)
        {
            _tempKey = _key;
            _tempValue = _value;
            _key = new S1[_key.Length + 1];
            _value = new S2[_value.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _key[_key.Length - 1] = item1;
            _value[_value.Length - 1] = item2;
        }


        public int Count
        {
            get { return _key.Length; }
        }


    }
}
