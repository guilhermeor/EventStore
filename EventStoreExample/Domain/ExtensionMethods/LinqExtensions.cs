using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class LinqExtensions
    {
        public static bool None<TSource>(this IEnumerable<TSource> source)
        {
            return !source.Any();
        }

        public static bool None<TSource>(this IEnumerable<TSource> source,
                                 Func<TSource, bool> predicate)
        {
            return !source.Any(predicate);
        }
    }
}
