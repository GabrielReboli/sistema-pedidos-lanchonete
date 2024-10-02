using System;

public class MonitorMontagem : IObservador
{
  public void Atualizar(Pedido pedido)
  {
    Console.WriteLine($"Montagem notificada: Pedido '{pedido.Descricao}' está '{pedido.Status}'.");
  }
}