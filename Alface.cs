public class Alface : IngredienteDecorator
{
    public Alface(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return hamburguer.GetDescricao() + " + Alface";
    }

    public override double GetCusto()
    {
        return hamburguer.GetCusto() + 1.00;
    }
}