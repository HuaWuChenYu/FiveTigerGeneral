using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using BLL;

namespace UICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        Bll _bll = new Bll();
        //public DefaultController(Bll bll)
        //{
        //    _bll = bll;
        //}
        [HttpGet]
        public List<Store> Show()
        {
            return _bll.GetStores();
            
        }
    }
}