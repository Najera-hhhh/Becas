using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Control;
using Control.Repositories;
using Microsoft.AspNetCore.Http;

namespace Proyecto
{
    public class LoginModel : PageModel
    {
        private readonly IAccoutRepository repository;
        public IEnumerable<Student> Students { get; private set; }

        [BindProperty]
        public string Correo { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public LoginModel(IAccoutRepository repository)
        {
            this.repository = repository;
        }

        public void OnGet()
        {

        }


        public IActionResult OnPost(){
            IActionResult result =  RedirectToPage();
            
            Account account =  repository.Validate(new Account{
                Correo = this.Correo,
                Password = this.Password
            });


            if(account.Id > 0)
            {
                TypeAccount type = (TypeAccount)account.Type;

                switch(type)
                {
                    case TypeAccount.STUDENT:
                        result = RedirectToPage("Profile","OnGet",account);        
                    break;
                    
                    case TypeAccount.ADMIN:
                        result = RedirectToPage("EstudioSocioeconomico","OnGet",account);        
                    break;

                    case TypeAccount.EVALUATOR:
                        result = RedirectToPage("Evaluatios");        
                    break;
                }                
            } 
                return result;
        }
    }
}
