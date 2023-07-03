using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using slimeTAP.Models;
using SlimeTAP.RazorPages.Data;

namespace SlimeTAP.Pages.Register
{
    public class RegisterModel : PageModel
    {
        private readonly ILogger<RegisterModel> _logger;
        private readonly AppDbContext _dbContext;

        public RegisterModel(ILogger<RegisterModel> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;

            Usuario = new UsuarioModel();
            ConfirmarSenha = "";
        }

        [BindProperty]
        public UsuarioModel Usuario { get; set; }

        [BindProperty]
        public string ConfirmarSenha { get; set; }

        public void OnGet()
        {
            // Este método é chamado quando a página é carregada.
            // Você pode adicionar algum código aqui, se necessário.
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Verificar se o nome de usuário já está em uso
                var existingUser = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == Usuario.UsuarioNome);

                if (existingUser != null)
                {
                    ModelState.AddModelError(string.Empty, "Nome de usuário já está em uso.");
                    return Page();
                }

                // Verificar se o tamanho do nome de usuário é maior que 5 caracteres
                if (Usuario.UsuarioNome.Length <= 5)
                {
                    ModelState.AddModelError(string.Empty, "O nome de usuário deve ter no minimo 6 caracteres.");
                    return Page();
                }

                // Verificar se a senha tem mais que 8 caracteres
                if (Usuario.Senha.Length <= 8)
                {
                    ModelState.AddModelError(string.Empty, "A senha deve ter mais de 8 caracteres.");
                    return Page();
                }

                // Verificar se o email é válido usando DataAnnotations
                if (!IsValidEmail(Usuario.Email))
                {
                    ModelState.AddModelError(string.Empty, "O email fornecido é inválido.");
                    return Page();
                }

                // Verificar se as senhas coincidem
                if (Usuario.Senha != ConfirmarSenha)
                {
                    ModelState.AddModelError(string.Empty, "As senhas não coincidem.");
                    return Page();
                }

                // Criar um novo usuário
                UsuarioModel newUser = new UsuarioModel
                {
                    UsuarioNome = Usuario.UsuarioNome,
                    Email = Usuario.Email,
                    Senha = Usuario.Senha
                };

                // Adicionar o novo usuário ao banco de dados
                _dbContext.Cliente.Add(newUser);
                _dbContext.SaveChanges();

                // Redirecionar para a página de sucesso
                return RedirectToPage("/Login/Login");
            }

            return Page();
        }

        // Método para verificar se o email é válido usando DataAnnotations
        private bool IsValidEmail(string email)
        {
            try
            {
                var emailAttribute = new EmailAddressAttribute();
                return emailAttribute.IsValid(email);
            }
            catch
            {
                return false;
            }
        }
    }
}
