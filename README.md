# Sistema de Pedidos para Lanchonete

Este projeto é um sistema de gerenciamento de pedidos para uma lanchonete fictícia. Os clientes podem personalizar seus hambúrgueres com ingredientes extras e adicionar itens adicionais ao pedido, como bebidas e sobremesas. O sistema utiliza os padrões de projeto **Decorator** e **Observer** para gerenciar a personalização e notificação de pedidos.

## Funcionalidades

- Escolha de hambúrguer base e personalização com ingredientes adicionais, como:
  - Bacon
  - Queijo
  - Alface
  - Tomate
- Adição de itens extras ao pedido, como:
  - Refrigerante
  - Batata frita
  - Sobremesa
- Notificação automática para a equipe de produção e montagem ao fazer ou atualizar um pedido.
- Cálculo automático do preço total do pedido.

## Padrões de Projeto Utilizados

### Decorator
O padrão **Decorator** é utilizado para permitir a adição de ingredientes personalizados ao hambúrguer base. Cada ingrediente é implementado como um decorador que adiciona descrição e custo ao hambúrguer base.

### Observer
O padrão **Observer** é utilizado para notificar os monitores da produção e montagem da lanchonete sempre que um pedido é criado ou modificado.

## Estrutura do Projeto

- **IHamburguer**: Interface para definir a estrutura de hambúrgueres e decoradores.
- **HamburguerSimples**: Implementa a interface `IHamburguer`, representando o hambúrguer básico.
- **IngredienteDecorator**: Classe abstrata que implementa `IHamburguer` e serve de base para os decoradores de ingredientes.
- **Bacon, Queijo, Alface, Tomate**: Decoradores que adicionam ingredientes ao hambúrguer.
- **Pedido**: Classe que gerencia os itens e status do pedido e notifica os observadores (produzido, montagem).
- **MonitorProducao e MonitorMontagem**: Observadores que recebem atualizações sobre o status do pedido.
- **ItemPedido**: Representa itens adicionais como refrigerantes, batatas fritas, e sobremesas.


