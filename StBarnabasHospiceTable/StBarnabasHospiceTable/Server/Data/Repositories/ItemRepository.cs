using Microsoft.EntityFrameworkCore;
using StBarnabasHospiceTable.Server.Data;
using StBarnabasHospiceTable.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StBarnabasHospiceTable.Server.Data.Repositories
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
        public async Task<IEnumerable<Item>> GetAllItems()
        {
            return await _appDbContext.Items.OrderByDescending(image => image.Id).ToListAsync();
        }
        //GET Item by Id
        public Item GetItemById(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(c => c.Id == itemId);
        }
    }
}
