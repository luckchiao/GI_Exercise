using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public static class MyLinq
    {
        public static IEnumerable<TResult> MyWhere<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> func)
        {
            var index = 0;
            foreach (var item in source)
            {
                yield return func(item, index++);
            }
        }
        
    }
}
