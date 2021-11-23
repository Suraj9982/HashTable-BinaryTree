using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAndBinary
{
    class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int Getarrayposition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = Getarrayposition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = Getarrayposition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key = key, value = value };
            linkedlist.AddLast(item);
        }
        public void Remove(K key)
        {
            int position = Getarrayposition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            bool itemfound = false;
            KeyValue<K, V> founditem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    itemfound = true;
                    founditem = item;
                }
            }
            if (itemfound)
            {
                linkedlist.Remove(founditem);
            }
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int postion)
        {
            LinkedList<KeyValue<K, V>> linkedlst = items[postion];
            if (linkedlst == null)
            {
                linkedlst = new LinkedList<KeyValue<K, V>>();
                items[postion] = linkedlst;
            }
            return linkedlst;
        }
    }
    public struct KeyValue<k, v>
    {
        public k key { get; set; }
        public v value { get; set; }
    }
}
