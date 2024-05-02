using _5by5_Pilha_Dinamica;
int opc;
PilhaLivro minhapilha = new PilhaLivro();
do
{
    Console.WriteLine("========= MENU PRINCIPAL =========");
    Console.WriteLine("[1] - Inserir Livro");
    Console.WriteLine("[2] - Remover Livro");
    Console.WriteLine("[3] - Imprimir Pilha");
    Console.WriteLine("[0] - Sair");
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            minhapilha.push(CadastroLivro());
            break;
        case 2:
            minhapilha.pop();
            break;
        case 3:
            minhapilha.print();
            break;
        case 4:
            minhapilha.BuscarLivro();
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }
    
} while (opc != 0);
 Livro CadastroLivro()
{
    Console.WriteLine("Digite o Titulo do Livro");
    return new Livro(Console.ReadLine());

}
