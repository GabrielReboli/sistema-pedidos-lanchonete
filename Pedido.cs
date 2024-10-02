using System;
using System.Collections.Generic;

public class Pedido : ISujeito
{
  private List<IObservador> observadores = new List<IObservador>();
  public string Descricao { get; private set; }
  public string Status { get; private set; }

  public Pedido(string descricao)
  {
    Descricao = descricao;
    Status = "Em produção";
  }

  public void AdicionarObservador(IObservador observador)
  {
    observadores.Add(observador);
  }

  public void RemoverObservador(IObservador observador)
  {
    observadores.Remove(observador);
  }

  public void NotificarObservadores()
  {
    foreach (IObservador observador in observadores)
    {
      observador.Atualizar(this);
    }
  }

  public void AtualizarStatus(string novoStatus)
  {
    Status = novoStatus;
    NotificarObservadores();
  }

  private List<ItemPedido> itens = new List<ItemPedido>();

  public void AdicionarItem(ItemPedido item)
  {
    itens.Add(item);
    Console.WriteLine($"Item '{item.Nome}' adicionado ao pedido");
    NotificarObservadores();
  }

  public double CalcularTotal()
  {
    double total = 0;
    foreach (var item in itens)
    {
      total += item.Preco;
    }
    return total;
  }

  public void ExibirResumoPedido()
  {
      Console.WriteLine("\nResumo do Pedido:");
      foreach (var item in itens)
      {
          Console.WriteLine($"{item.Nome} - {item.Preco.ToString("C")}");
      }
      Console.WriteLine($"Total do pedido: {CalcularTotal().ToString("C")}");
  }
}