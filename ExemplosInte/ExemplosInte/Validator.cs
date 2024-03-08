using System.Linq.Expressions;

namespace ExemplosInte;

internal static class Validator
{
    public static bool PessoaEhMaiorDeIdade(Pessoa pessoa)
    {
        // Verificar se a pessoa é maior de idade
        return pessoa.Idade >= 18;
    }

    // Método que recebe uma pessoa de qual tipo, e retorna boolean
    // o Segunto parametro é uma func que sabe calcular a idade
    public static bool PessoaEhMaiorDeIdade<TPessoa>(TPessoa pessoa, Func<TPessoa, int> funcCalculaIdade)
    {
        var idade = funcCalculaIdade(pessoa);
        return idade >= 18;
    }

    public static void ForEachRefeito(Pessoa[] pessoas, Action<Pessoa> action)
    {
        foreach (var pessoa in pessoas)
        {
            action(pessoa);
        }
    }

}


public class Pessoa
{
    public int Idade { get; set; }
}

public class PessoaDiferente
{
    public int IdadeDia { get; set; }
    public int IdadeMes { get; set; }
    public int IdadeAno { get; set; }
}

public class PessoaDiferente2
{
    public DateOnly Nascimento { get; set; }
}