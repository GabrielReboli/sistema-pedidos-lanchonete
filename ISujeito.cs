public interface ISujeito
{
  void AdicionarObservador(IObservador observador);
  void RemoverObservador(IObservador observador);
  void NotificarObservadores();
}