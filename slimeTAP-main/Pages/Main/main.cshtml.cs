using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using slimeTAP.Models;
using SlimeTAP.RazorPages.Data;

namespace SlimeTAP.Pages.Main
{
    public class main : PageModel
    {
        private readonly ILogger<main> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly RazorPages.Data.AppDbContext _dbContext;
        public main(ILogger<main> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            Usuario = new UsuarioModel();
        }

        public UsuarioModel Usuario { get; set; }
        public List<SlimeData>? Slimes { get; set; }
        public int UpgradeValue { get; set; }
        public int Level { get; set; }
        public int Moeda { get; set; }
        public int Diamante { get; set; }
        public int Gema { get; set; }
        public string UsuarioNome { get; set; } // Propriedade para armazenar o nome do usuário
        public int Custo { get; set; }
        public int Custo2 { get; set; }
        public int Custo3 { get; set; }
        public int Custo4 { get; set; }
        public int Custo5 { get; set; }
        public int Custo6 { get; set; }
        public float WipeValor { get; set; }
        public int Custo10 { get; set; }
        public int Custo11 { get; set; }
        public int Multiplicador { get; set; }
        public UsuarioModel? existingUser { get; set; }
        public int Nivel { get; set; }
        public int LevelAtual { get; set; }
        public int MoedaAtual { get; set; }
        
        public int Upgrade3 { get; set; }
        
        public void OnGet()
        {
            
            
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            // Resto do código...
            if (!string.IsNullOrEmpty(usuarioNomeCookie))
            {
                UsuarioNome = usuarioNomeCookie;
                existingUser = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
                UpgradeValue = Convert.ToInt32(existingUser.Upgrade1);
                Level = Convert.ToInt32(existingUser.Level);
                Moeda = Convert.ToInt32(existingUser.Moeda);
                Diamante = Convert.ToInt32(existingUser.Diamante);
                Gema = Convert.ToInt32(existingUser.Gema);
                Slimes = GenerateSlimeData(UpgradeValue);
                
                Multiplicador = Convert.ToInt32(existingUser.Upgrade2);
                Custo = UpgradeValue*10;
                Custo2 = Convert.ToInt32(existingUser.Upgrade2)*2;
                Custo3 = Convert.ToInt32(existingUser.Upgrade3)*3;
                Upgrade3 = Convert.ToInt32(existingUser.Upgrade3)*3;
                Custo4 = Convert.ToInt32(existingUser.Upgrade4)*300;
                Custo5 = Convert.ToInt32(existingUser.Upgrade5)*480;
                Custo6 = 7600;





                Custo10 = Convert.ToInt32(existingUser.Upgrade10)*2;
                Custo11 = Convert.ToInt32(existingUser.Upgrade11)*2;
                WipeValor = (float)(Convert.ToInt32(existingUser.Xp) * 0.1) + (float)(Convert.ToInt32(existingUser.MoedaTotal) * 0.001);

                WipeValor = Convert.ToInt32(WipeValor);

            }
        }

 


        public IActionResult OnPostIncrementSlime()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                if(Usuario.Level > 10){
                    Custo = Convert.ToInt32(Usuario.Upgrade1)*10;
                    Usuario.Level -= Custo;
                    if(Usuario.Level >=0 ){
                        Usuario.Upgrade1 += 1;
                        _dbContext.SaveChanges(); // Salva as alterações no banco de dados
                        return RedirectToPage("/Main/main");
                    }else{
                        return RedirectToPage("/Main/main");
                    }
                    return RedirectToPage("/Main/main");
                }else{
                    return RedirectToPage("/Main/main");
                }
            }
            return BadRequest();
        }

        public IActionResult OnPostIncrementMultiplicador()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                if(Usuario.Level > 1){
                    
                    Custo2 = Convert.ToInt32(Usuario.Upgrade2)*2;
                    Usuario.Level -= Custo2;
                    
                    if(Usuario.Level >=0 ){
                        System.Console.WriteLine(Usuario.Level);
                        Usuario.Upgrade2 += 1;
                        _dbContext.SaveChanges();
                        return RedirectToPage("/Main/main");
                    }else{
                        return RedirectToPage("/Main/main");
                    }
                    
                }else{
                    return RedirectToPage("/Main/main");
                }
            }
            return BadRequest();
        }
        public IActionResult OnPostIncrementMultiplicadorGema()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                if(Usuario.Gema > 1){
                    
                    Custo10 = Convert.ToInt32(Usuario.Upgrade10)*2;
                    Usuario.Gema -= Custo10;
                    
                    if(Usuario.Gema >=0 ){
                        System.Console.WriteLine(Usuario.Gema);
                        Usuario.Upgrade10 += 1;
                        _dbContext.SaveChanges();
                        return RedirectToPage("/Main/main");
                    }else{
                        return RedirectToPage("/Main/main");
                    }
                    return RedirectToPage("/Main/main");
                }else{
                    return RedirectToPage("/Main/main");
                }
            }
            return BadRequest();
        }

        public IActionResult OnPostIncrementMultiplicadorXp()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                System.Console.WriteLine(Usuario.Nivel);
                if(Usuario.Level > 1){
                    
                    Custo3 = Convert.ToInt32(Usuario.Upgrade3)*2;
                    Usuario.Level -= Custo3;
                    
                    if(Usuario.Level >=0 ){
                        
                        Usuario.Upgrade3 += 1;
                        _dbContext.SaveChanges();
                        return RedirectToPage("/Main/main");
                    }else{
                        return RedirectToPage("/Main/main");
                    }
                    return RedirectToPage("/Main/main");
                }else{
                    return RedirectToPage("/Main/main");
                }
            }
            return BadRequest();
        }  

        public IActionResult OnPostIncrementDobroMoedas()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                
                if(Usuario.Moeda > 1){
                    
                    Custo4 = Convert.ToInt32(Usuario.Upgrade4)*300;
                    Usuario.Moeda -= Custo4;
                    
                    if(Usuario.Moeda >=0 ){
                        if(Usuario.Upgrade4<100){
                            Usuario.Upgrade4 += 1;
                        _dbContext.SaveChanges();
                        }
                        return RedirectToPage("/Main/main");
                    }else{
                        return RedirectToPage("/Main/main");
                    }
                    return RedirectToPage("/Main/main");
                }else{
                    return RedirectToPage("/Main/main");
                }
            }
            return BadRequest();
        }  

        public IActionResult OnPostIncrementDobroXp()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                
                if(Usuario.Moeda > 1){
                    
                    Custo5 = Convert.ToInt32(Usuario.Upgrade5)*480;
                    Usuario.Moeda -= Custo5;
                    
                    if(Usuario.Moeda >=0 ){
                        if(Usuario.Upgrade5<100){
                            Usuario.Upgrade5 += 1;
                        _dbContext.SaveChanges();
                        }
                        return RedirectToPage("/Main/main");
                    }else{
                        return RedirectToPage("/Main/main");
                    }
                    return RedirectToPage("/Main/main");
                }else{
                    return RedirectToPage("/Main/main");
                }
            }
            return BadRequest();
        }  
 
        public IActionResult OnPostIncrementMultiplicadorXpGema()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                System.Console.WriteLine(Usuario.Nivel);
                if(Usuario.Gema > 1){
                    
                    Custo11 = Convert.ToInt32(Usuario.Upgrade11)*2;
                    Usuario.Gema -= Custo11;
                    
                    if(Usuario.Gema >= 0 ){
                         
                        Usuario.Upgrade11 += 1;
                        _dbContext.SaveChanges();
                        return RedirectToPage("/Main/main");
                    }else{
                        return RedirectToPage("/Main/main");
                    }
                    return RedirectToPage("/Main/main");
                }else{
                    return RedirectToPage("/Main/main");
                }
            }
            return BadRequest();
        }  

        public IActionResult OnPostIncrementMoeda()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                Random random = new Random();
                Usuario.Nivel += Convert.ToInt32(Usuario.Upgrade11)+(1*(Convert.ToInt32(Usuario.Upgrade3)));
                if(Usuario.Nivel>=100 && Usuario.Nivel<=200){
                    if (random.Next(0, 100) < Usuario.Upgrade5){
                        Usuario.Level++;
                        Usuario.Xp+=2;
                        Usuario.Diamante += 4;
                        Usuario.Nivel -= 100;
                    }else{
                        Usuario.Level++;
                        Usuario.Xp++;
                        Usuario.Diamante += 2;
                        Usuario.Nivel -= 100; 
                    } 
                }else if(Usuario.Nivel>=200){
                    if (random.Next(0, 100) < Usuario.Upgrade5){
                        Usuario.Level+=2;
                        Usuario.Xp+=4;
                        Usuario.Diamante += 8;
                        Usuario.Nivel -= 200;
                    }else{
                        Usuario.Level+=2;
                        Usuario.Xp+=2;
                        Usuario.Diamante += 4;
                        Usuario.Nivel -= 200;
                    } 
                }
                if(Usuario.Upgrade1 == 1){
                    if (random.Next(0, 100) < Usuario.Upgrade4)
                    {
                        // Valor dobrado
                        Usuario.Moeda += ((Convert.ToInt32(Usuario.Upgrade2)*1)*2);
                        Usuario.MoedaTotal += ((Convert.ToInt32(Usuario.Upgrade2)*1)*2);
                        _dbContext.SaveChanges(); // Salva as alterações no banco de dados    
                        return RedirectToPage("/Main/main");

                    }else{
                                               // Valor dobrado
                        Usuario.Moeda += (Convert.ToInt32(Usuario.Upgrade2)*1);
                        Usuario.MoedaTotal += (Convert.ToInt32(Usuario.Upgrade2)*1);
                        _dbContext.SaveChanges(); // Salva as alterações no banco de dados    
                        return RedirectToPage("/Main/main"); 
                    }
                    
                }else{
                    Usuario.Moeda += Convert.ToInt32(Usuario.Upgrade10)+(Convert.ToInt32(Usuario.Upgrade2)*1)*(10*(Convert.ToInt32(Usuario.Upgrade1)-1));
                    Usuario.MoedaTotal += Convert.ToInt32(Usuario.Upgrade10)+(Convert.ToInt32(Usuario.Upgrade2)*1)*(10*(Convert.ToInt32(Usuario.Upgrade1)-1));
                    _dbContext.SaveChanges(); // Salva as alterações no banco de dados    
                    return RedirectToPage("/Main/main");
                }

                
            }
            return BadRequest();
        }







        public class SlimeData
        {
            public int X { get; set; }
            public int Y { get; set; }
            public string? ImageFileName { get; set; }
            public int ZIndex { get; set; }
        }

        private List<SlimeData> GenerateSlimeData(int upgradeValue)
        {
            List<SlimeData> data = new List<SlimeData>();

            List<string> slimeImageFiles = new List<string>
            {
                "slime1.png",
                "slime2.png",
                "slime3.png",
                "slime4.png",
                "slime5.png",
                "slime6.png",
                "slime7.png",
                "slime8.png",
                "slime9.png",
                // Adicione mais nomes de arquivos de imagem para cada tipo de slime
            };

            int containerWidth = 50; // Largura do contêiner em porcentagem
            int containerHeight = 100; // Altura do contêiner em porcentagem

            int slimeWidth = 30; // Largura do slime em porcentagem
            int slimeHeight = 100; // Altura do slime em porcentagem

            int spacing = (containerWidth - upgradeValue * slimeWidth) / (upgradeValue + 1); // Espaçamento entre os slimes em porcentagem

            int totalWidth = upgradeValue * slimeWidth + (upgradeValue + 1) * spacing;
            int offsetX = (containerWidth - totalWidth) / 2; // Deslocamento em porcentagem para o centro dos slimes

            for (int i = 0; i < upgradeValue; i++)
            {
                int x = offsetX + (i + 1) * spacing + i * slimeWidth;
                int y = (containerHeight - slimeHeight) / 2; // Posição Y centralizada

                SlimeData slime = new SlimeData
                {
                    X = x,
                    Y = y,
                    ImageFileName = slimeImageFiles[i % slimeImageFiles.Count], // Obtenha o nome de arquivo de imagem com base no índice
                };

                data.Add(slime);
            }

            return data;
        }


        public IActionResult OnPostWipe()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                
                WipeValor = (float)(Convert.ToInt32(Usuario.Xp) * 0.1) + (float)(Convert.ToInt32(Usuario.MoedaTotal) * 0.001);


                Usuario.Gema += Convert.ToInt32(WipeValor);
                Usuario.Moeda = 0 ;
                Usuario.Level = 1 ;
                Usuario.MoedaTotal = 0;
                Usuario.Diamante = 0;
                Usuario.Xp = 0;
                Usuario.Nivel = 1;
                Usuario.Upgrade1 = 1;
                Usuario.Upgrade2 = 1;
                Usuario.Upgrade3 = 1;
                Usuario.Upgrade4 = 1;
                Usuario.Upgrade5 = 1;
                Usuario.Upgrade6 = 1;
                Usuario.Upgrade7 = 1;
                Usuario.Upgrade8 = 1;
                Usuario.Upgrade9 = 1;
                _dbContext.SaveChanges(); // Salva as alterações no banco de dados    
                return RedirectToPage("/Main/main");

                
            }
            return BadRequest();
        }
    }
}