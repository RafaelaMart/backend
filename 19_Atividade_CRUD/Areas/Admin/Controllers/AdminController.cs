using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _19_Atividade_CRUD.Context;
using _19_Atividade_CRUD.Models;
using App.Filters;

namespace Produtos_Com_Admin.Areas.Admin.Controllers
{

    [Area("Admin")]
    [AdminAuthorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}