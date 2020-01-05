using System.Collections.Generic;
using PessoaAPI.Models;
using PessoaAPI.DAO;

namespace PessoaAPI.BLL
{

   public class BPessoa
   {
       public List<Pessoa> RetornarPessoas(){
           return new DAOPessoa().RetornarPessoas();
       }      

       public Pessoa RetornarPessoa(int id){
           return new DAOPessoa().RetornarPessoa(id);
       }      
   }
}