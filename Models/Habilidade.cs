
namespace GeradorCurriculo.Models;

public class Habilidade {
    public string Nome { get; set; }

    private int _nivel;
    public int Nivel {
        get { return _nivel; }
        set { _nivel = value; }
    }
}