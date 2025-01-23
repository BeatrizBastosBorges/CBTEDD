// Desenvolvido por Beatriz Bastos Borges e Miguel Luizatto Alves

namespace Projeto_Medicamento;

public class Medicamentos
{
    private List<Medicamento> listaMedicamentos = new List<Medicamento>();

    public Medicamentos()
    {
        this.listaMedicamentos = new List<Medicamento>();
    }

    public List<Medicamento> getListaMedicamentos()
    {
        return this.listaMedicamentos;
    }
    
    public void Adicionar(Medicamento medicamento)
    {
        listaMedicamentos.Add(medicamento);
    }

    public bool Deletar(Medicamento medicamento)
    {
        if (medicamento.QtdeDisponivel() == 0)
        {
            return listaMedicamentos.Remove(medicamento);
        }

        return false;
    }

    public Medicamento Pesquisar(Medicamento medicamento)
    {
        return listaMedicamentos.FirstOrDefault(m => m.Equals(medicamento)) ?? new Medicamento();
    }
}
