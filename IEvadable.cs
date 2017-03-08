namespace Kata5 {
  public interface IEvadable {
    float ChanceToEvade { get; set; }
    bool AttemptEvasion();
  }
}
