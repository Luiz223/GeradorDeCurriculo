namespace GeradorCurriculo.Models;

public class Curriculo {
    public Pessoa DadosPessoais { get; set; } = new Pessoa();
    public Habilidade Habilidade { get; set; } = new Habilidade();
    public Formacao Formacao { get; set; } = new Formacao();
    public Formacao FormacaoAcademica { get; set; }
}