using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Auto.Controllers
{
    public class CadastrosController : Controller
    {
        public IActionResult Veiculo()
        {
            return View();
        }
    }
}
