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

namespace App.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        //Essa marcação quer dizer que este arquivo pertence a área Admin
        [Area("Admin")]
        [AdminAuthorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}