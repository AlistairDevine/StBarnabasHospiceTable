using StBarnabasHospiceTable.Server.Models;
using StBarnabasHospiceTable.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StBarnabasHospiceTable.Data.Repositories
{
    public class ItemRepository : IItemRepository
    //: Interface repository
    {
        //Connection to the database
        private readonly AppDbContext _appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //Database communication interactions
        //GET Items
        public IEnumerable<Item> GetAllItems()
        {
            return _appDbContext.Items;
        }
        //GET Item by Id
        public Item GetItemById(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(c => c.ItemId == itemId);
        }
    }
}
