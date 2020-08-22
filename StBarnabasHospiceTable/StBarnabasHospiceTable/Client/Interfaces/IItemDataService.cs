using StBarnabasHospiceTable.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StBarnabasHospiceTable.Client.Services
{
    public interface IItemDataService
    {
        Task<Item> AddItem(Item item);
        Task<IEnumerable<Item>> GetAllItems();
        Task<Item> GetItemById(int itemId);
    }
}