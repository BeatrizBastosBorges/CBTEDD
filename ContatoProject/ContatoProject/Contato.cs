using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatoProject
{
    public class Contato
    {
        private string nome;
        private string email;
        private Data dtNasc;
        private List<Telefone> Telefones;

        public Contato(string nome, string email, Data dtNasc)
        {
            this.nome = nome;
            this.email = email;
            this.dtNasc = dtNasc;
            this.Telefones = new List<Telefone>();
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public Data getData()
        {
            return this.dtNasc;
        }

        public void setData(Data dtNasc)
        {
            this.dtNasc = dtNasc;
        }

        public List<Telefone> getTelefones()
        {
            return this.Telefones;
        }

        public void setTelefones(List<Telefone> telefones)
        {
            this.Telefones = telefones;
        }

        public void AdicionarTelefone(Telefone t)
        {
            this.Telefones.Add(t);
        }

        public string GetTelefonePrincipal()
        {
            Telefone telefonePrincipal = this.Telefones.FirstOrDefault(t => t.getPrincipal());
            return telefonePrincipal != null ? telefonePrincipal.getNumero() : "Sem telefone principal";
        }

        public int GetIdade()
        {
            var hoje = DateTime.Now;
            int idade = hoje.Year - this.dtNasc.getAno();
            if (hoje.Month < this.dtNasc.getMes() || (hoje.Month == this.dtNasc.getMes() && hoje.Day < this.dtNasc.getDia()))
            {
                idade--;
            }
            return idade;
        }

        public override string ToString()
        {
            string telefonesFormatados = string.Join(", ", this.Telefones.Select(t => $"Número: {t.getNumero()}"));
            return $"Nome: {this.nome}, Email: {this.email}, Data de Nascimento: {this.dtNasc.ToString()}, Idade: {GetIdade()}, Telefone Principal: {GetTelefonePrincipal()}, Telefones: {telefonesFormatados}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Contato contato)
            {
                return this.email.Equals(contato.email);
            }
            return false;
        }
    }
}
