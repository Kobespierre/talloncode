using FinalFantasyAPI.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalFantasyAPI.Controllers
{
    public class AppController : ControllerBase
    {
        protected readonly FF_DbContext _context;
        public AppController(FF_DbContext context) => _context = context;
    }
}
