using Microsoft.AspNetCore.Mvc;
using sys_backend.Models;

namespace sys_backend.Controllers
{
    public class AccountController : Controller
    {
        // 1. Mostra a página de Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // 2. Recebe os dados quando clicas em "Entrar"
        [HttpPost]
        public IActionResult Login(LoginViewModel modelo)
        {
            // Valida se os campos estão preenchidos
            if (ModelState.IsValid)
            {
                // Verifica a senha (FIXA por enquanto para teste)
                if (modelo.Email == "aluno@fatec.br" && modelo.Senha == "123456")
                {
                    // Se estiver certo, vai para a página inicial
                    return RedirectToAction("Index", "Home");
                }
                
                // Se estiver errado, adiciona erro
                ModelState.AddModelError("", "Email ou senha incorretos!");
            }

            // Se falhar, volta a mostrar a tela de login
            return View(modelo);
        }
    }
}