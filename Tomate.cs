public class Tomate : IngredienteDecorator
{
    public Tomate(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return hamburguer.GetDescricao() + " + Tomate";
    }

    public override double GetCusto()
    {
        return hamburguer.GetCusto() + 1.00;
    }
}