using StBarnabasHospiceTable.Shared;
using System.Collections.Generic;

namespace StBarnabasHospiceTable.Data.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemById(int itemId);
    }
}