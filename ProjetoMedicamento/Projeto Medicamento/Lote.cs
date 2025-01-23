// Desenvolvido por Beatriz Bastos Borges e Miguel Luizatto Alves

using System.Runtime.CompilerServices;

namespace Projeto_Medicamento;

public class Lote
{
    private int id, qtde;
    private DateTime venc;
    
    public Lote()
    {
        this.id = 0;
        this.qtde = 0;
        this.venc = DateTime.Now;
    }

    public Lote(int id, int qtde, DateTime venc)
    {
        this.id = id;
        this.qtde = qtde;
        this.venc = venc;
    }

    public int getId()
    {
        return this.id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public int getQtde()
    {
        return this.qtde;
    }

    public void setQtde(int qtde)
    {
        this.qtde = qtde;
    }

    public DateTime getVenc()
    {
        return this.venc;
    }

    public void setVenc(DateTime venc)
    {
        this.venc = venc;
    }

    public override string ToString()
    {
        return this.id.ToString() + " - " + this.qtde.ToString() + " - " + this.venc.ToString();
    }
}

