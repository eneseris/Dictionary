using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydictionary<int, string> mydictionary = new Mydictionary<int, string>();

            mydictionary.Add(1, "enes");
            mydictionary.Add(2, "koray");
            mydictionary.Add(3, "eriş");
            mydictionary.Add(4, "enes eriş");


        }



        class Mydictionary<k, v>
        {
            k[] keyList;
            v[] valueList;

            k[] tmpKey;
            v[] tmpValue;

            public Mydictionary()
            {
                keyList = new k[0];
                valueList = new v[0];
            }
            public void Add(k key,v value)
            {
                tmpKey = keyList;
                tmpValue = valueList;
                keyList = new k[keyList.Length + 1];
                valueList = new v[valueList.Length + 1];
                for(int i = 0; i < tmpKey.Length; i++)
                {
                    keyList[i] = tmpKey[i];
                    valueList[i] = tmpValue[i];
                }
                keyList[keyList.Length - 1] = key;
                valueList[valueList.Length - 1] = value;
            }
        }
    }
}
