using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatoProject
{
    public class Telefone
    {
        private string tipo;
        private string numero;
        private bool principal;

        public Telefone(string tipo, string numero, bool principal)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.principal = principal;
        }

        public string getTipo()
        {
            return this.tipo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string getNumero()
        {
            return this.numero;
        }

        public void setNumero(string numero)
        {
            this.numero = numero;
        }

        public bool getPrincipal() 
        {
            return this.principal;
        }

        public void setPrincipal(bool principal)
        {
            this.principal = principal;
        }
    }
}
