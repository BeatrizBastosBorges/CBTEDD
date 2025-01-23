# Proj. MVC Vendedores

### Desenvolvido por: Beatriz Bastos Borges e Miguel Luizatto Alves

Uma empresa possui wm seu departamento comercial, uma equipe composta por 10 vendedores.

Dentro de um mesmo mês, é feito diariamente um registro da quantidade de vendas realizadas por cada um deles, bem como o valor total dessas vendas.

Utiliza o diagrama de classes apresentado à para desenvolver uma aplicação com as opções descritas abaixo:

|Venda|
|-|
|- qtde: int|
|- valor: double|
||
|+ valorMedio(): double|

|Vendedor| 
|-|
|- id: int|
|- nome: string|
|- percComissao: double|
|- asVendas: Venda[31]|
||
|+ registrarVenda(int dia, Venda venda): void|
|+ valorVendas(): double|
|+ valorComissao(): double|

|Vendedores| 
|-|
|- osVendedores: Vendedor[]|
|- max: int|
|- qtde: int|
||
|+ addVendedor(Vendedor v): bool|
|+ delVendedor(Vendedor v): bool|
|+ searchVendedor(Vendedor v): Vendedor|
|+ valorVendas(): double|
|+ valorVendas(): double|
|+ valorComissao(): double|

OPÇÕES:

0. Sair
1. Cadastrar vendedor (*)
2. Consultar vendedor (**)
3. Excluir vendedor   (***)
4. Registrar venda
5. Listar vendedores  (****)


(*)    - Limitar o quantitativo de vendedores cadastrados (máximo 10).

(**)   - Quando encontrado, deverá ser informado o id, nome, o valor total das vendas, o valor da comissão devida e  o valor médio das vendas diárias (de cada dia que houve registro de venda).

(***)  - O vendedor só poderá ser excluído enquanto não houver nenhuma venda associada a ele.

(****) - Deverá ser informado, para cada vendedor, o id, nome, valor total das vendas e o valor da comissão devida. Ao final da listagem, esses valores deverão ser totalizados.
