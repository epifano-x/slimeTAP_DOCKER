using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using slimeTAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SlimeTAP.RazorPages.Data;
using Microsoft.AspNetCore.Http;

namespace SlimeTAP.Pages.Login
{
    public class login : PageModel
    {
        private readonly ILogger<login> _logger;
        private readonly RazorPages.Data.AppDbContext _dbContext;
        public login(ILogger<login> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            Usuario = new UsuarioModel();
        }
        

        [BindProperty]
        public UsuarioModel Usuario { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OnPost()
        {
            // Aqui você pode implementar a lógica de autenticação/login

            // Verificar se as credenciais do usuário são válidas com base nos dados do banco de dados
            var user = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == Usuario.UsuarioNome && u.Senha == Usuario.Senha);

            if (user != null)
            {
                // Salvar o nome do usuário nos cookies
                var cookieOptions = new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(7) // Define a expiração do cookie (7 dias a partir de agora)
                };
                HttpContext.Response.Cookies.Append("UsuarioNome", Usuario.UsuarioNome, cookieOptions);

                // Login bem-sucedido, redirecionar para outra página
                return RedirectToPage("/Loading/Loading");
            }
            else
            {
                // Login inválido, exibir mensagem de erro
                ModelState.AddModelError(string.Empty, "Nome de usuário ou senha inválidos.");
                return Page();
            }
        }
    }
}
