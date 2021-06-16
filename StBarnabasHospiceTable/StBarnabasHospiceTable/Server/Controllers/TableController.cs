using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StBarnabasHospiceTable.Server.Data.Repositories;

namespace StBarnabasHospiceTable.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        //Connection to the Data repository
        private readonly ITableRepository _tableRepository;

        public TableController(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }
        //Logger???

        //Http communication actions
        //GET request for all tables method, api/<controller>
        [HttpGet]
        public IActionResult GetTables()
        {
            return Ok(_tableRepository.GetAllTables());
        }
        //GET request for a table by Id method, api/<controller>/3
        [HttpGet("{id}")]
        public IActionResult GetTableById(int id)
        {
            return Ok(_tableRepository.GetTableById(id));
        }
    }
}
