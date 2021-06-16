using StBarnabasHospiceTable.Shared;
using System.Collections.Generic;

namespace StBarnabasHospiceTable.Server.Data.Repositories
{
    public interface ITableRepository
    {
        IEnumerable<Table> GetAllTables();
        Table GetTableById(int tableId);
    }
}