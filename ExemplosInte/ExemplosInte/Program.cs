


using ExemplosInte;

var pessoa = new Pessoa
{
    Idade = 20
};

var pessoaDiferente = new PessoaDiferente
{
    IdadeAno = 1996,
    IdadeDia = 20,
    IdadeMes = 1
};

var pessoaDiferente2 = new PessoaDiferente2
{
    Nascimento = DateOnly.FromDateTime(DateTime.Now.AddDays(-18))
};

//var ehMaiorDeIdade = Validator.PessoaEhMaiorDeIdade(pessoa);

//var ehMaiorDeIdade = Validator.PessoaEhMaiorDeIdade(pessoaDiferente, p => DateTime.Now.Year - p.IdadeAno);
var ehMaiorDeIdade = Validator.PessoaEhMaiorDeIdade(pessoaDiferente2, p => DateTime.Now.Year - p.Nascimento.Year);

Console.WriteLine($"Pessoa é maior de idade: {ehMaiorDeIdade}");


Pessoa[] pessoas = [];

pessoas.ToList().Max



//Func<string, Pessoa, int> => int QualQuerNome(string qual, Pessoa qual);
//Action => void QualQuerNome();
//Action<Pessoa> => void QualQuerNome(Pessoa pessoa);
//Predicate => bool QualQuerNome();
//Predicate<Pessoa> => bool QualQuerNome(Pessoa pessoa);