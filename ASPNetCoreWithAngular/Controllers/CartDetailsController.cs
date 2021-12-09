using ASPNetCoreWithAngular.Data.Context;
using ASPNetCoreWithAngular.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWithAngular.Controllers
{
    [Route("api/cartdetails")]
    [ApiController]
    public class CartDetailsController : ControllerBase
    {
        private readonly ItemContext _context;
        public CartDetailsController(ItemContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("Details")]
        public IEnumerable<ItemDetails> GetItemDetails()
        {
            return _context.ItemDetails;

        }
    }
}
