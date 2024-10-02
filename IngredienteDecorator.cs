public  abstract class IngredienteDecorator : IHamburguer
{
  protected IHamburguer hamburguer;

  public IngredienteDecorator(IHamburguer hamburguer)
  {
    this.hamburguer = hamburguer;
  }

  public abstract string GetDescricao();
  public abstract double GetCusto();
}