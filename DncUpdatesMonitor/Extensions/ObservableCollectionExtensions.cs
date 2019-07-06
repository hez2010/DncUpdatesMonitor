using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DncUpdatesMonitor
{
    static class ObservableCollectionExtensions
    {
        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> data)
        {
            foreach(var i in data)
            {
                collection.Add(i);
            }
        }
    }
}
