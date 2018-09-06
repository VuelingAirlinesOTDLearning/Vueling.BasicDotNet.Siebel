using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vueling.XXX.WCF.REST.WebService.Mapping
{
    public interface ILocalMapper
    {
        TDest Map<TSource, TDest>(TSource source);
        IList<TDest> MapCollection<TSource, TDest>(IList<TSource> source);
        IEnumerable<TDest> MapCollection<TSource, TDest>(IEnumerable<TSource> source);
    }
}
