using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorIdWeb.Infraestrutura.Map
{
    public static class MapExtensions
    {
        public static object MapTo(this object source)
        {

            var typeMap = Mapper.GetAllTypeMaps().SingleOrDefault(x => x.SourceType == source.GetType());

            if (typeMap == null)
            {
                throw new InvalidOperationException($"Há dois ou mais mapeamentos para o tipo de fonte {source.GetType()}");
            }

            return Mapper.Map(source, source.GetType(), typeMap.DestinationType);
        }

        public static TDest MapTo<TDest>(this object source)
        {
            try
            {
                return (TDest)Mapper.Map(source, source.GetType(), typeof(TDest));
            }
            catch (Exception erro)
            {

                throw;
            }
        }

        public static TDest MapTo<TSource, TDest>(this TSource source, TDest dest)
        {
            return Mapper.Map(source, dest);
        }

        public static IEnumerable<TDest> MapEachTo<TDest>(this IEnumerable<object> source)
        {
            return (IEnumerable<TDest>)Mapper.Map(source, source.GetType(), typeof(IEnumerable<TDest>));
        }
    }
}
