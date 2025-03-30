using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace crud.Repositorios
{
    public class PessoaRepositorio
    {
        public void Inserir(Pessoa pessoa)
        {
            using MySqlConnection conexao =  (MySqlConnection) new DbConexao().GetConnection();
            conexao.Execute("INSERT INTO PESSOA (NOME,EMAIL,CPF) VALUES(@nome,@email,@cpf);",
                new
                {
                    nome = pessoa.Nome,
                    email = pessoa.Email,
                    cpf = pessoa.Cpf,
                });
        }

        public void Atualizar(Pessoa pessoa)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            conexao.Execute("UPDATE PESSOA SET NOME = @nome, EMAIL = @email, CPF = @cpf WHERE ID = @id;",
                new
                {
                    nome = pessoa.Nome,
                    email = pessoa.Email,
                    cpf = pessoa.Cpf,
                    id = pessoa.Id
                });
        }

        public void Deletar(int id)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            conexao.Execute("DELETE FROM PESSOA WHERE ID = @id;",
                new
                {
                    id
                });
        }

        public Pessoa? BuscarPessoaPeloId(int id)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            return conexao.QueryFirstOrDefault<Pessoa>(@"SELECT * FROM PESSOA WHERE ID = @id", new { id });
        }

        public IEnumerable<Pessoa> BuscarTodasPessoas()
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            return conexao.Query<Pessoa>(@"SELECT * FROM PESSOA ");
        }
    }
}
