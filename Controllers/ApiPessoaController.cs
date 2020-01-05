using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PessoaAPI.BLL;
using PessoaAPI.Models;

namespace PessoaAPI.Controllers
{
    [Route("api/[controller]")]
    public class ApiPessoaController : Controller
    {
        // GET api/values
        [HttpGet]
        public List<Pessoa> GetAll()
        {
            return new BPessoa().RetornarPessoas();
        }

        [HttpGet("{id}")]
        public Pessoa Get(int id)
        {
            return new BPessoa().RetornarPessoa(id);
        }
    }
}