using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode
{
    public class HashTable
    {
        public KeyValPair[] data;
        public HashTable(int size)
        {
            this.data = InitializeArray<KeyValPair>(size);
        }

        T[] InitializeArray<T>(int length) where T : new()
        {
            T[] array = new T[length];
            for (int i = 0; i < length; ++i)
            {
                array[i] = new T();
            }

            return array;
        }

        public int HashKey(string key)
        {
            int position = 0;
            int result = 0;

            var chars = key.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                var charPosition = char.ToUpper(chars[i]) - 64;
                result += charPosition;
            }

            position = result % this.data.Length;
            return position;
        }

        public void Set(string Key, int Value)
        {
            var hashKey = HashKey(Key);
            this.data[hashKey] = new KeyValPair{Key = Key, Value = Value};
        }

        public KeyValPair Get(string key)
        {
            var hashKey = HashKey(key);
            var result = new KeyValPair();
            result.Key = this.data[hashKey].Key;
            result.Value = this.data[hashKey].Value;

            return result;
        }

        public string[] GetKeys()
        {
            List<string> result = new List<string>();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Key != null)
                {
                    result.Add(data[i].Key);
                }
            }

            return result.ToArray();

        }
    }

     
    public class KeyValPair
    {
        public string Key { get; set; }
        public int Value { get; set; }

    }
}
