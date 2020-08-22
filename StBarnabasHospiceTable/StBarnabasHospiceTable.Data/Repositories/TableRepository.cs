using System.Collections.Generic;
using System.Linq;
using StBarnabasHospiceTable.Server.Models;
using StBarnabasHospiceTable.Shared;

namespace StBarnabasHospiceTable.Data.Repositories
{
    public class TableRepository : ITableRepository
    //: Interface repository
    {
        //Connection to the database
        private readonly AppDbContext _appDbContext;
        public TableRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //Database communication interactions
        //GET Table
        public IEnumerable<Table> GetAllTables()
        {
            return _appDbContext.Tables;
        }
        //GET Table Item by Id
        public Table GetTableById(int tableId)
        {
            return _appDbContext.Tables.FirstOrDefault(c => c.TableId == tableId);
        }
    }
}
