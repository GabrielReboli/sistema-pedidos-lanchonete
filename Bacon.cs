public class Bacon : IngredienteDecorator
{
  public Bacon(IHamburguer hamburguer) : base(hamburguer) { }

  public override string GetDescricao()
  {
    return hamburguer.GetDescricao() + " + Bacon";
  }

  public override double GetCusto()
  {
    return hamburguer.GetCusto() + 2.00;
  }
}