using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    public class Pessoa
    {
        private Pessoa() { }
        public Pessoa(int id, string? nome, string? email, string? cpf)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }

        public int Id { get; private set; }
        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public string? Cpf { get; private set; }
    }
}
