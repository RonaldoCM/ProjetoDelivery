using Model;
using DataAccess;

namespace BusinessObjects
{
    public class PessoaBO
    {
        private PessoaDA _pessoaDA;

        public PessoaBO()
        {
            _pessoaDA = new PessoaDA(); 
        }

        public int AdicionarPessoa(Pessoa p)
        {
            if (string.IsNullOrWhiteSpace(p.Nome))
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }
            
            var inserido = _pessoaDA.InsertPerson(p);

            return inserido;
        }

        public List<Pessoa> ObterPessoas()
        {
            return _pessoaDA.GetPessoas();
        }

        public bool ValidarPessoa(Pessoa pessoa)
        {
            return _pessoaDA.ValidarPessoa(pessoa);
        }
    }
}
