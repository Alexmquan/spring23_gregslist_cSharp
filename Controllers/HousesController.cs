using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spring23_gregslist_cSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HousesController : ControllerBase
{

  private readonly HousesService _housesService;

  public HousesController(HousesService housesService)
  {
    _housesService = housesService;
  }

}