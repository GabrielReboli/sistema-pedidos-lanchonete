public class ItemPedido
{
  public string Nome { get; private set; }
  public double Preco { get; private set; }

  public ItemPedido(string nome, double preco)
  {
    Nome = nome;
    Preco = preco;
  }
}