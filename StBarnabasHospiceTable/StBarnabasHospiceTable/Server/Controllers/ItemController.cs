using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StBarnabasHospiceTable.Server.Data;
using StBarnabasHospiceTable.Server.Data.Repositories;

using StBarnabasHospiceTable.Shared;

namespace StBarnabasHospiceTable.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        //Connection to the Data repository
        private readonly IItemRepository _itemRepository;

        private readonly AppDbContext _context;
        private readonly ILogger<ItemController> _logger;
        //
        private static readonly List<Item> items = new List<Item>();

        public ItemController(ILogger<ItemController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        //Logger???

        //Http Connection actions
        //GET request for all items method, api/<controller>
        [HttpGet]
        public async Task<IEnumerable<Item>> GetItems()
        {
            return await _context.Items.OrderByDescending(image => image.Id).ToListAsync();
        }
        //GET request for items by Id method, api/<controller>/3
        [HttpGet("{id}")]
        public IActionResult GetItemsById(int id)
        {
            return Ok(_itemRepository.GetItemById(id));
        }
        //POST: api/item
        [HttpPost]
        public async Task<IActionResult> AddItemController(Item item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();

            return Ok(item);
        }
    }
}
