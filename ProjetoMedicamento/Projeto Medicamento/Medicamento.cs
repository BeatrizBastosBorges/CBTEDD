// Desenvolvido por Beatriz Bastos Borges e Miguel Luizatto Alves

namespace Projeto_Medicamento;

public class Medicamento
{
    private int id;
    private string nome, laboratorio;
    private Queue<Lote> lotes;

    public Medicamento()
    {
        this.id = 0;
        this.nome = "";
        this.laboratorio = "";
        this.lotes = new Queue<Lote>();
    }

    public Medicamento(int id, string nome, string laboratorio)
    {
        this.id = id;
        this.nome = nome;
        this.laboratorio = laboratorio;
    }

    public int getId()
    {
        return this.id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public string getNome()
    {
        return this.nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getLaboratorio()
    {
        return this.laboratorio;
    }

    public void setLaboratorio(string laboratorio)
    {
        this.laboratorio = laboratorio;
    }

    public Queue<Lote> Lotes => lotes;

    public int QtdeDisponivel()
    {
        return lotes.Sum(l => l.getQtde());
    }

    public void Comprar(Lote lote)
    {
        lotes.Enqueue(lote);
    }

    public bool Vender(int qtde)
    {
        if (qtde > QtdeDisponivel())
            return false;

        while (qtde > 0 && lotes.Count > 0)
        {
            Lote loteAtual = lotes.Peek();
            if (loteAtual.getQtde() <= qtde)
            {
                qtde -= loteAtual.getQtde();
                lotes.Dequeue();
            }
            else
            {
                int aux = loteAtual.getQtde() - qtde;
                loteAtual.setQtde(aux);
                qtde = 0;
            }
        }

        return true;
    }

    public override string ToString()
    {
        return this.id + " - " + this.nome + "-" + this.laboratorio + " - " + QtdeDisponivel();
    }

    public override bool Equals(object obj)
    {
        if (obj is Medicamento medicamento)
            return id == medicamento.getId();
        return false;
    }
}
