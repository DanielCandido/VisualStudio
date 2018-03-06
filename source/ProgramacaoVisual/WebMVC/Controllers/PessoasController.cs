using System;
using System.Collection.Generic;
using System.Diagnostics;
using System.Ling;
using System.Threading.Tasks;
using Micrpsoft.AspNetCore.Mvc;
using WebMVC.Models;


namespace WebMVC.Controller
{
    public class PessoasController : Controller
    {
        private static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa {id = 1, nome = "Joao"}
            new Pessoa {id = 2, nome = "Jose"}
            new Pessoa {id = 3, nome = "Maria"}
        };
        public IActionResult Index()
        {

        }
    }
}