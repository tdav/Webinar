using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webinar.Utils
{
    public static class CList
    {
        public static Task<List<T>> ToListAsync<T>(this IQueryable<T> list)
        {
            return Task.Run(() => list.ToList());
        }
        
        public static Task<List<T>> ToListAsync<T>(this IEnumerable<T> list)
        {
            return Task.Run(() => list.ToList());
        }
    }
}
