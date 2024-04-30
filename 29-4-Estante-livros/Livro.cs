using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


public class Livro
{
    public string titulo;
    public string autor;
    public DateOnly lancamento;
    public string editora;
    public int edicao;
    public int isbn;
    public int qtpag;

    public Livro()
    {
    }

    public void DefinirTitulo(string t)
    {
        this.titulo = t;
    }
    public void DefinirAutor(string a)
    {
        this.autor = a;
    }
    public void DefinirDataLancamento(DateOnly l)
    {
        this.lancamento = l;
    }
    public void DefinirEditora(string e)
    {
        this.editora = e;
    }
    public void DefinirEdicao(int ed)
    {
        this.edicao = ed;
    }
    public void DefinirIsbn(int isb)
    {
        this.isbn = isb;
    }
    public void DefinirQtPag(int pag)
    {
        this.qtpag = pag;
    }
    public void ImprimirLivro(Livro[] livros, int posicao)
    {
        Console.WriteLine("\nLivro da posição: " + posicao);
        Console.WriteLine("\nLivro da posição: " + livros[posicao].titulo);
        Console.WriteLine("Título: " + livros[posicao].autor);
        Console.WriteLine("Autor: " + livros[posicao].lancamento);
        Console.WriteLine("Data de lançamento: " + livros[posicao].editora);
        Console.WriteLine("Editora: " + livros[posicao].edicao);
        Console.WriteLine("ISBN: " + livros[posicao].isbn);
        Console.WriteLine("Quantidade de páginas: " + livros[posicao].qtpag);

    }

    public void ImprimirLivros(Livro[] livros)
    {
        for (int i = 0; i < livros.Length; i++)
        {
            Console.WriteLine("\nLivro da posição: " + (i + 1));
            Console.WriteLine("Título: " + livros[i].titulo);
            Console.WriteLine("Autor: " + livros[i].autor);
            Console.WriteLine("Data de lançamento: " + livros[i].lancamento);
            Console.WriteLine("Editora: " + livros[i].editora);
            Console.WriteLine("Edição: " + livros[i].edicao);
            Console.WriteLine("ISBN: " + livros[i].isbn);
            Console.WriteLine("Quantidade de páginas: " + livros[i].qtpag);
            Console.WriteLine("**********************************");
        }
    }
}