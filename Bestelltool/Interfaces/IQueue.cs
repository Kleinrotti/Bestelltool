using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bestelltool.Interfaces
{
    public interface IQueue<T> : IEnumerable<T>
    {
        void ProcessSingleItem(T item);

        Task ProcessQueue(CancellationToken token);
    }
}