
# Gerenciamento de Pedidos - Delivery

Sistema desenvolvido em C# com frontend Windows Forms e banco de dados MySql para atender uma emergência de cadastramento e organização de um Delivery.

## Requisitos Funcionais
Por se tratar de um software desktop desenvolvido em plataforma Windows o requisito principal é o Sistema operacional Windows.
O framework selecionado é o .NET 8 e o Sistema gerenciador de banco de dados é o MySql.

* Sistema Operacional Windows
* .NET 8
* MySql

## Descrição
O sistema Delivery foi desenvolvido para atendimento particular de um negócio em desenvolvimento. A ideia principal é cadastrar produtos, pedidos, cadastrar e imprimir cupom não fiscal e a partir disso consolidar algumas informações visuais que customizadamente potencializam o negócio.

O frontend está sendo desenvolvido em Windows forms.
Usando uma abordagem aproximada ao MVC. Implementando no controller as ações de cada formulário, tornando os objetos de interação com o usuário mais leves.
O backend foi organizado em camadas : 

<img src="https://github.com/RonaldoCM/ProjetoDelivery/blob/main/Imagens/Camadas.png" alt="Camadas">

A camada DataAccess tem a responsabilidade de implementar os objetos responsáveis por acesso, conexão e execução de sentenças SQL em banco de dados.

A camada BusinessObjects tem a responsabilidade de implementar os objetos responsáveis pela lógica e processamento de rotinas em Servidor.

A camada Model tem a responsabilidade de implementar as classes (entidades fortes) do sistema.

A camada View tem a responsabilidade de implementação dos formulários e objetos visuais que interarão com o usuário.

## Modelo de Entidade e Relacionamento
O banco de dados da aplicação foi criado préviamente e evidentemente pode sofrer modificações a depender das evoluções e aprendizados durante os processos de implementação.

<img src="https://github.com/RonaldoCM/ProjetoDelivery/blob/main/Imagens/ImagemER_v1.png" alt="Entidade e Relacionamento">

### Telas do sistema

<img src="https://github.com/RonaldoCM/ProjetoDelivery/blob/main/Imagens/LogIn.png" alt="LogIn">

Para usuário ou senha inválidos, será apresentado o popUp informativo.

<img src="https://github.com/RonaldoCM/ProjetoDelivery/blob/main/Imagens/PopUpLogIn.png" alt="PopUpLogIn">

A partir do acesso da tela de log in o sistema abrirá a tela de Menu.

<img src="https://github.com/RonaldoCM/ProjetoDelivery/blob/main/Imagens/Menu.png" alt="Menu">

No Menu temos as opções:

* Gerenciador de Pedidos
* Cadastro de Pessoas
* Cadastro de Produtos
* Configurações

Até o momento as implementações só estão realizadas no Gerenciador de Pedidos.

Os demais botões serão implementados futuramente.

Acessando o botão Gerenciador de Pedidos abritá o painel de pedidos.

<img src="https://github.com/RonaldoCM/ProjetoDelivery/blob/main/Imagens/PainelDePedidos.png" alt="Painel de Pedidos">

O painel de pedidos tem a ideia de exibir todo o tempo os pedidos cadastrados e seus status.

* Finalizado
* Em Execução
* Em Entrega
* Em Preparação

O painel possui três opções de ações:

* Novo Pedido
* Editar Pedido
* Cancelar Pedido

Para Editar ou Cancelar um pedido basta seleciona-lo no painel Pedidos e apertar respectivo botão.

Ao apertar o Novo Pedido abrirá a tela de Criação e Edição de pedidos.

<img src="https://github.com/RonaldoCM/ProjetoDelivery/blob/main/Imagens/InserePedido.png" alt="Editar Pedido">

Nessa tela o usuário pode inserir os itens e a cada item inserido o valor total do pedido irá sendo calculado acima do grid. Ao remover algum item (no botão Remover de dentro do grid) o valor total se atualizará também. Os valores de cada item estão em cadastro no banco de dados.

Ao salvar, o sistema pedirá o valor do frete e salvará o cliente, endereço e o pedido com seus itens e valor atualizado com frete.

<img src="https://github.com/RonaldoCM/ProjetoDelivery/blob/main/Imagens/frete.png" alt="Frete">

Por fim, como plano futuro teremos a impressão de cupom não fiscal para controle da produção do pedido.

Após a inserção o pedido aparecerá no painel de Pedidos.

## Observações Gerais

Esse projeto nasceu de uma necessidade imediata para controlar o cadastro de pedidos de um Delivery de batatas recheadas, como estão cadastrados em banco e aparecem na tela de inserção e edição de pedidos.
Evidentemente não tem a pretensão de se tornar um produto de mercado. A ideia é ter apenas essas funções descritas.
Juntamente com a necessidade, estou aplicando alguns conceitos e usando o banco de dados MySql para aprender com a prática. E aplicando o framework .NET 8.
Novas atualizações no ReadMe virão a partir da evolução do projeto.

## Autor
Ronaldo Costa Miranda
