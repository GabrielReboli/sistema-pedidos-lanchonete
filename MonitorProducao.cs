using System;

public class MonitorProducao : IObservador
{
  public void Atualizar(Pedido pedido)
  {
    Console.WriteLine($"Produção notificada: Pedido '{pedido.Descricao}' está '{pedido.Status}'.");
  }
}