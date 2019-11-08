using Bestelltool.Interfaces;
using Bestelltool.Structs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bestelltool.Classes
{
    internal class OrderProcessor : IQueue<Order>
    {
        private static IList<Order> _queue = new List<Order>();

        public int Count => _queue.Count;

        public void Add(Order item)
        {
            _queue.Add(item);
        }

        public bool Remove(Order item)
        {
            return _queue.Remove(item);
        }

        public void Clear()
        {
            _queue.Clear(); ;
        }

        public bool Contains(Order item)
        {
            return _queue.Contains(item);
        }

        public IEnumerator<Order> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        public int IndexOf(Order item)
        {
            throw new NotImplementedException();
        }

        public void ProcessSingleItem(Order item)
        {
            throw new NotImplementedException();
        }

        public Task ProcessQueue(CancellationToken token)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}