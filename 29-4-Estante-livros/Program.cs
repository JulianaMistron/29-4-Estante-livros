//criar estante de livros, onde a estante é um vetor de 10 livros fixo e depois imprimir a estante inteira ou a
//posição q eu escoher, informações relevantes a um livro; titulo, autor/es, data lancamento, editora, edição,
//isbn, qtde pg,...inserção sequencial

int size = 10;
Livro[] livros = new Livro[size];

for (int i = 0; i < size; i++)
{
    Livro l1 = new Livro();
    int numeroDoLivro = i + 1;

    Console.WriteLine($"Livro {numeroDoLivro}: ");
    l1.DefinirTitulo(Console.ReadLine());

    Console.WriteLine("Digite o autor/es: ");
    l1.DefinirAutor(Console.ReadLine());

    Console.WriteLine("Digite a data de lançamento: ");
    l1.DefinirDataLancamento(DateOnly.Parse(Console.ReadLine()));

    Console.WriteLine("Digite a editora: ");
    l1.DefinirEditora(Console.ReadLine());

    Console.WriteLine("Digite o número da edição: ");
    l1.DefinirEdicao(int.Parse(Console.ReadLine()));

    Console.WriteLine("Digite o ISBN: ");
    l1.DefinirIsbn(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de páginas: ");
    l1.DefinirQtPag(int.Parse(Console.ReadLine()));

    livros[i] = l1;
}

Console.ReadKey();

Console.WriteLine("Informe a opção desejada: ");
Console.WriteLine("1 - Imprimir todos os livros: ");
Console.WriteLine("2 - Escolher a posição do livro na estante: ");

int opcao = int.Parse(Console.ReadLine());
Livro livro = new Livro();
if (opcao == 1)

    livro.ImprimirLivros(livros);
else
{
    Console.WriteLine("Digite a posição do livro na estante"); 
    int posicao = int.Parse(Console.ReadLine());
    livro.ImprimirLivro(livros, posicao);
}