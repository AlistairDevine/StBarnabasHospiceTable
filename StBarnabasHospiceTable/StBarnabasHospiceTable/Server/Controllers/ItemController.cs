using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StBarnabasHospiceTable.Data.Repositories;
using StBarnabasHospiceTable.Shared;

namespace StBarnabasHospiceTable.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        //Connection to the Data repository
        private readonly IItemRepository _itemRepository;
        //
        private static readonly List<Item> items = new List<Item>();

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        //Logger???

        //Http Connection actions
        //GET request for all items method, api/<controller>
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_itemRepository.GetAllItems());
        }
        //GET request for items by Id method, api/<controller>/3
        [HttpGet("{id}")]
        public IActionResult GetItemsById(int id)
        {
            return Ok(_itemRepository.GetItemById(id));
        }
        //POST: api/items
        [HttpPost]
        public void AddItemController([FromBody] Item item)
        {
            items.Add(item);
        }
    }
}
