# Especificação “Projeto Medicamento” – Console Application 

|Lote|
|-|
|- id: int|
|- qyde: int|
|venc: DateTime|
||
|+ Lote()|
|+ Lote(int id, int qtde, DateTime venc|
|+ toString(): string ➡️ retornar id + "-" + qtde + "-" + venc|

|Medicamento|
|-|
|- id: int|
|- nome: string|
|- laboratorio: string|
|- lotes: Queue<Lote>|
||
|+ Medicamento()|
|+ Medicamento(int id, string nome, string laboratorio)|
|+ qtdeDisponivel(): int ➡️ Retornar disponibilidade do medicamento em todos os lotes|
|+ comprar(Lote lote): void ➡️ Colocar o lote comprado na fila de lotes|
|+ vender(int qtde): bool ➡️ Se houver saldo possível para ser vendido, realizar a venda e retornar o sucesso, abatendo a quantidade vendida de tantos lotes quanto necessário. Quando o lote tiver a sua quantidade zerada, deverá ser retirado da fila. Não havendo quantidade disponível para venda, retornar o fato.|
|+ toString(): string ➡️ retornar id + “-“ + nome + “-“ + laboratorio + “-“ + qtdeDisponivel()|
|+ Equals(object obj): bool ➡️ Permitir comparação pelo id do medicamento|

|Medicamentos|
|-|
|- listaMedicamentos: List<Medicamento>|
||
|+ Medicamentos()|
|+ adicionar(Medicamento medicamento): void ➡️ Adicionar o medicamento na lista de medicamentos|
|+ deletar(Medicamento medicamento): bool ➡️ Remover o medicamento da lista somente se a quantidade disponível for 0 (zero). Indicar sucesso/fracasso da operação com true/false|
|+ pesquisar(Medicamento medicamento): Medicamento ➡️ Procurar o medicamento indicado na lista de Medicamentos utilizando o id do objeto como chave. Caso encontrado, retornar o objeto completo. Caso não encontrado, retornar um objeto vazio.|

### **Deverá contemplar um seletor com as seguintes opções:**

0. Finalizar processo
1. Cadastrar medicamento
2. Consultar medicamento (sintético: informar dados1)
3. Consultar medicamento (analítico: informar dados1 + lotes2)
4. Comprar medicamento (cadastrar lote)
5. Vender medicamento (abater do lote mais antigo)
6. Listar medicamentos (informando dados sintéticos) 

Legenda:
1) Dados do medicamento: ID + NOME + LABORATÓRIO + QTDE DISPONÍVEL
2) Dados do lote: ID + QTDE + DATA DE VENCIMENTO

*Desenvolvido por Beatriz Bastos Borges e Miguel Luizatto Alves*
