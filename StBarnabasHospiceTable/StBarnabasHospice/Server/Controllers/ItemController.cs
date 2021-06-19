using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StBarnabasHospice.Server.Data;
using StBarnabasHospice.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StBarnabasHospice.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ItemController> _logger;
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
