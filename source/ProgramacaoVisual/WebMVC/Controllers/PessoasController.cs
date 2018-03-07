using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;


namespace WebMVC.Controller
{
    public class PessoasController
    {
        private static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa {id = 1, nome = "Joao"},
            new Pessoa {id = 2, nome = "Jose"},
            new Pessoa {id = 3, nome = "Maria"}
        };
        public IActionResult Index()
        {

            var viewModel = new PessoaViewModel
            {
                Items = pessoaList
            };

            return View(viewModel);
        }
    }
}