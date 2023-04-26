using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spring23_gregslist_cSharp.Repositories;
public class HousesRepository
{
  private readonly IDbConnection _db;

  public HousesRepository(IDbConnection db)
  {
    _db = db;
  }

  internal int CreateHouse(House houseData)
  {
    string sql = @"
    INSERT INTO houses(
        bedrooms, bathrooms, address, price, description
    )
    values(
        @Bedrooms, @Bathrooms, @Address, @Price, @Description
    );
    SELECT LAST_INSERT_ID();";

    int id = _db.ExecuteScalar<int>(sql, houseData);

    return id;
  }
}