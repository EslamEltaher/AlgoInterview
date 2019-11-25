//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algos_YakshTefla7.DS_Trial
//{
//    public class HashTable <T1, T2>
//    {
//        LinkedList<KeyValuePair<T1, T2>>[]  data;

//        public HashTable()
//        {
//            data = new LinkedList<KeyValuePair<T1,T2>>[int.MaxValue / 10]; 
//        }
//        public void Insert(T1 key, T2 value)
//        {
//            int itemHashCode = getHashCode(key);
//            if (data[itemHashCode] == null)
//                data[itemHashCode] = new LinkedList<KeyValuePair<T1, T2>>();

//            data[itemHashCode].AddLast(new KeyValuePair<T1, T2>(key, value));
//        }

//        public T2 Get(T1 key)
//        {
//            T2 value = default(T2);

//            int itemHashCode = getHashCode(key);

//            if (data[itemHashCode] != null)
//            {
//                foreach (var item in data[itemHashCode])
//                {
//                    if (item.Key.Equals(key))
//                        return value = item.Value;
//                }
//            }

//            return value;
//        }

//        private int getHashCode(T1 item)
//        {
//            return Math.Abs(item.GetHashCode() / 100);
//        }
//    }

//    public class KeyValuePair<T1, T2>
//    {
//        public T1 Key { get; set; }
//        public T2 Value { get; set; }

//        public KeyValuePair(T1 key, T2 value)
//        {
//            Key = key;
//            Value = value;
//        }
//    }
//}
