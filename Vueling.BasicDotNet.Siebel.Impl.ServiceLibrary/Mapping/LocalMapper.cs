using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Vueling.Extensions.Library.DI;
using Vueling.ObjectMapper.Contracts.ServiceLibrary;

namespace Vueling.XXX.Impl.ServiceLibrary.Mapping
{
    [RegisterService]
    public class LocalMapper : ILocalMapper
    {
        #region .: Boilerplate Code :.

        private readonly IMapper _mapper;

        private object _customSyncRoot = new object();
        private static bool _customRegPerformed;

        public LocalMapper(IMapper mapper)
        {
            _mapper = mapper;

            if (!_customRegPerformed)
            {
                lock (_customSyncRoot)
                {
                    if (!_customRegPerformed)
                    {
                        RegisterCustomMappings();
                        _customRegPerformed = true;
                    }
                }
            }
        }

        public TDest Map<TSource, TDest>(TSource source)
        {
            return _mapper.Map<TSource, TDest>(source);
        }

        public IList<TDest> MapCollection<TSource, TDest>(IList<TSource> source)
        {
            return _mapper.MapCollection<TSource, TDest>(source);
        }

        public IEnumerable<TDest> MapCollection<TSource, TDest>(IEnumerable<TSource> source)
        {
            return _mapper.MapCollection<TSource, TDest>(source);
        }

        #endregion .: Boilerplate Code :.


        private void RegisterCustomMappings()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Trace.TraceError("Failed to register custom mappings: " + ex);
                throw;
            }
        }
    }
}
