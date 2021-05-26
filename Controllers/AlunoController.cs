using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAlunos.Data;
using WebAlunos.Models;

namespace WebAlunos.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebAlunosContext _dbContext;
        
        public AlunoController(ILogger<HomeController> logger, WebAlunosContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult CadastroAluno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroAluno(AlunoModel model)
        {
            if(ModelState.IsValid)
            {
                _dbContext.Add(model);
                _dbContext.SaveChanges();
            }
            else
            {
                return View(model);
            }
            
            return View();
        }
    }
}