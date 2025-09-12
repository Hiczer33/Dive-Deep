using System.Collections.Generic;

namespace diveDeep.Services
{
    public static class ProductListService
    {
        private static readonly List<int> _ids = new();

        public static IReadOnlyList<int> GetAll() => _ids;

        public static void Add(int productId) => _ids.Add(productId);

        public static void Clear() => _ids.Clear();
    }
}