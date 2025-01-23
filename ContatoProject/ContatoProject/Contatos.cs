using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatoProject
{
    public class Contatos
    {
        private readonly List<Contato> agenda = new List<Contato>();

        public bool Adicionar(Contato c)
        {
            Contato contatoExistente = Pesquisar(c);

            if (contatoExistente == null)
            {
                agenda.Add(c);
                return true;
            }
            else
            {
                bool retorno = true;

                foreach (Telefone telefoneNovo in c.getTelefones())
                {
                    bool telefoneExiste = contatoExistente
                        .getTelefones()
                        .Any(telefoneExistente => telefoneExistente.getNumero() == telefoneNovo.getNumero());

                    if (telefoneExiste)
                    {
                        retorno = false;
                    }
                    else
                    {
                        if (c.GetTelefonePrincipal() != "Sem telefone principal")
                        {
                            foreach (Telefone telefone in contatoExistente.getTelefones())
                            {
                                if (telefone.getPrincipal())
                                    retorno = false;
                            }
                        }
                    }

                    if (retorno)
                        contatoExistente.AdicionarTelefone(telefoneNovo);
                }
                return retorno;
            }
        }

        public Contato Pesquisar(Contato c)
        {
            return agenda.FirstOrDefault(contato => contato.Equals(c));
        }

        public bool Alterar(Contato c)
        {
            var contatoExistente = Pesquisar(c);
            if (contatoExistente != null)
            {
                agenda.Remove(contatoExistente);
                agenda.Add(c);
                return true;
            }
            return false;
        }

        public bool Remover(Contato c)
        {
            var contatoExistente = Pesquisar(c);
            if (contatoExistente != null)
            {
                agenda.Remove(contatoExistente);
                return true;
            }
            return false;
        }

        public List<Contato> ListarContatos()
        {
            return agenda;
        }
    }

}
