using StBarnabasHospiceTable.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StBarnabasHospiceTable.Server.Data.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetAllItems();
        Item GetItemById(int itemId);
    }
}