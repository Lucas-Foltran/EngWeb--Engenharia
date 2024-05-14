using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Site2.Models;

namespace Site2.Controllers
{
    public class LoginController : Controller
    {
       // private readonly dbContext _context;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string user, string pwd)
        {
            try
            {
                var login = new Login
                {
                    nome = user,
                    senha = pwd
                };
                dbContext _context = new dbContext();

                _context.Logins.Add(login);
                _context.SaveChanges();

                return Ok(true);
            }
            catch (Exception ex) {
                throw ex;
            }
            
        }

        [HttpPost]
        public IActionResult Post(string nome, string senha)
        {
            try
            {
                var login = new Login
                {
                    nome = nome,
                    senha = senha
                };
                dbContext _context = new dbContext();

                _context.Logins.Add(login);
                _context.SaveChanges();

                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
