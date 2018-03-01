using Mapster;
using Nelibur.ObjectMapper;
using System;

namespace Flexi.Shared.Helper
{
    public class MapHelper
    {
        private static readonly Lazy<MapHelper> lazy = new Lazy<MapHelper>(() => new MapHelper());
        public static MapHelper Instance { get { return lazy.Value; } }


        private MapHelper()
        {
        }

        public T MapObject<T, K>(K oldObject)
        {
            T result = TinyMapper.Map<T>(oldObject);
            return result;
        }

        public T MapObjectWithExpress<T, K>(K oldObject)
        {
            IAdapter adapter = new Adapter();
            var result = adapter.Adapt<T>(oldObject);
            return result;
        }
    }
}
