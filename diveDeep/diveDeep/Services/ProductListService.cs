using System.Collections.Generic;
using diveDeep.Models;

namespace diveDeep.Services
{
    public static class ProductListService
    {
        private static readonly List<ListEntry> _items = new();

        public static IReadOnlyList<ListEntry> GetAll() => _items;

        public static void Add(string category, int productId)
            => _items.Add(new ListEntry { Category = category, ProductId = productId });

        public static void Clear() => _items.Clear();
    }
}