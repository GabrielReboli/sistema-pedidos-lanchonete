public class Queijo : IngredienteDecorator
{
  public Queijo(IHamburguer hamburguer) : base(hamburguer) { }

  public override string GetDescricao()
  {
    return hamburguer.GetDescricao() + " + Queijo";
  }

  public override double GetCusto()
  {
    return hamburguer.GetCusto() + 1.50;
  }
}