using System;
using System.Collections.Generic; // Necessário para usar List<T>
using System.Linq;                // Necessário para usar LINQ (FirstOrDefault, Where, Sum)


namespace ConsoleApp1
{
    // ===============================================
    // Classe Produto
    // Representa um produto individual no estoque
    // ===============================================
    public class Produto
    {
        // ----------------------------
        // Atributos (Propriedades)
        // ----------------------------
        public int id;          // Identificador único do produto
        public string nome;     // Nome do produto
        public double preco;    // Preço unitário
        public int quantidade;  // Quantidade em estoque

        // ----------------------------
        // Construtores
        // ----------------------------

        // Construtor padrão: cria um produto sem inicializar atributos
        public Produto() { }

        // Construtor com ID apenas: útil para buscas
        public Produto(int id)
        {
            this.id = id;
        }

        // Construtor completo: inicializa todos os atributos
        public Produto(int id, string nome, double preco, int quantidade)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        // ----------------------------
        // Métodos
        // ----------------------------

        // Exibe as informações do produto no console
        public void mostrar()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Preço: " + preco.ToString("C2")); // "C2" formata como moeda
            Console.WriteLine("Quantidade: " + quantidade);
        }

        // Adiciona uma quantidade ao estoque do produto
        public void adicionar(int quantidade)
        {
            this.quantidade += quantidade;
        }

        // Remove uma quantidade do estoque, evitando valores negativos
        public void remover(int quantidade)
        {
            if (this.quantidade >= quantidade)
            {
                this.quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente para remover.");
            }
        }
    }

    // ===============================================
    // Classe Estoque
    // Representa um conjunto de produtos
    // ===============================================
    public class Estoque
    {
        // Lista de produtos no estoque
        public List<Produto> produtos;

        // Construtor: inicializa a lista de produtos
        public Estoque()
        {
            produtos = new List<Produto>();
        }

        // ----------------------------
        // Métodos
        // ----------------------------

        // Adiciona um novo produto ao estoque
        public void adicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        // Remove um produto pelo ID
        public bool removerProduto(int id)
        {
            Produto produto = produtos.FirstOrDefault(p => p.id == id); // LINQ: busca pelo ID
            if (produto != null)
            {
                produtos.Remove(produto);
                return true;
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
                return false;
            }
        }

        // Limpa toda a lista de produtos
        public void apagarListaProdutos()
        {
            produtos.Clear(); // Remove todos os elementos
            Console.WriteLine("Lista de produtos apagada.");
        }

        // Busca um produto pelo ID
        public Produto buscarProdutoPorId(int id)
        {
            return produtos.FirstOrDefault(p => p.id == id); // Retorna null se não encontrado
        }

        // Adiciona quantidade a um produto
        public bool addQuantidadeProduto(int id, int quantidade)
        {
            Produto produto = buscarProdutoPorId(id);
            if (produto != null)
            {
                produto.adicionar(quantidade);
                return true;
            }
            Console.WriteLine("Produto não encontrado.");
            return false;
        }

        // Subtrai quantidade de um produto
        public bool subQuantidadeProduto(int id, int quantidade)
        {
            Produto produto = buscarProdutoPorId(id);
            if (produto != null)
            {
                produto.remover(quantidade);
                return true;
            }
            Console.WriteLine("Produto não encontrado.");
            return false;
        }

        // Exibe todos os produtos ou filtra pelo nome
        public void mostrarProdutos(string filtro = "")
        {
            var produtosFiltrados = produtos.Where(p => p.nome.Contains(filtro)).ToList(); // LINQ: filtra produtos
            if (produtosFiltrados.Count == 0)
            {
                Console.WriteLine("Nenhum produto encontrado.");
            }
            else
            {
                foreach (var produto in produtosFiltrados)
                {
                    produto.mostrar();
                    Console.WriteLine();
                }
            }
        }

        // Calcula e exibe o valor total do estoque
        public void calcularValorTotalEstoque()
        {
            double valorTotal = produtos.Sum(p => p.preco * p.quantidade); // LINQ: soma total
            Console.WriteLine("Valor total do estoque: " + valorTotal.ToString("C2"));
        }
    }

    // ===============================================
    // Classe Principal (Program)
    // ===============================================
    internal class Program
    {
        // ----------------------------
        // Funções auxiliares
        // ----------------------------

        // Exibe texto no console sem quebrar linha
        public static void print(string texto)
        {
            Console.Write(texto);
        }

        // Lê entrada do usuário, opcionalmente exibindo uma mensagem
        public static string read(string text_info = "")
        {
            if (text_info != "")
            {
                print(text_info);
            }
            return Console.ReadLine();
        }

        // ----------------------------
        // Método Main: ponto de entrada
        // ----------------------------
        static void Main(string[] args)
        {
            // Cria um estoque vazio
            Estoque estoque = new Estoque();

            // Loop infinito do menu
            do
            {
                // ----------------------------
                // Menu de opções
                // ----------------------------
                print("\nMenu:");
                print("\n1. Adicionar Produto");
                print("\n2. Remover Produto");
                print("\n3. Buscar Produto por ID");
                print("\n4. Adicionar Quantidade a Produto");
                print("\n9. Diminuir Quantidade de um Produto");
                print("\n5. Mostrar Produtos");
                print("\n6. Apagar lista de produtos");
                print("\n7. Valor do estoque");
                print("\n8. Sair");
                print("\nEscolha uma opção: ");

                // Lê a opção do usuário
                string opcao = read();
                Console.Clear(); // Limpa a tela

                // ----------------------------
                // Switch-case: trata cada opção
                // ----------------------------
                switch (opcao)
                {
                    case "1":
                        // Adicionar produto
                        int id = int.Parse(read("Digite o ID do produto: "));

                        // Valida ID único
                        if (estoque.buscarProdutoPorId(id) != null)
                        {
                            print("\nID já existe. Use outro.\nPressione Enter para continuar\n");
                            read();
                            continue; // volta ao menu
                        }

                        // Cria e adiciona novo produto
                        Produto novoProduto = new Produto(
                            id,
                            read("Digite o nome do produto: "),
                            double.Parse(read("Digite o preço do produto: ")),
                            int.Parse(read("Digite a quantidade do produto: "))
                        );
                        estoque.adicionarProduto(novoProduto);
                        print("Produto adicionado com sucesso!");
                        read();
                        Console.Clear();
                        break;

                    case "2":
                        // Remover produto
                        int idRemover = int.Parse(read("Digite o ID do produto a ser removido: "));
                        if (estoque.removerProduto(idRemover))
                        {
                            print("Produto removido com sucesso!");
                        }
                        read();
                        Console.Clear();
                        break;

                    case "3":
                        // Buscar produto por ID
                        int idBuscar = int.Parse(read("Digite o ID do produto a ser buscado: "));
                        Produto produtoBuscado = estoque.buscarProdutoPorId(idBuscar);
                        if (produtoBuscado != null)
                        {
                            produtoBuscado.mostrar();
                        }
                        else
                        {
                            print("Produto não encontrado.");
                        }
                        read();
                        Console.Clear();
                        break;

                    case "4":
                        // Adicionar quantidade a produto
                        int idAdicionar = int.Parse(read("Digite o ID do produto: "));
                        int quantidadeAdicionar = int.Parse(read("Digite a quantidade a ser adicionada: "));

                        if (estoque.addQuantidadeProduto(idAdicionar, quantidadeAdicionar))
                        {
                            print("Quantidade adicionada com sucesso!");
                        }
                        read();
                        Console.Clear();
                        break;

                    case "5":
                        // Mostrar produtos (com filtro opcional)
                        string filtro = read("Digite um filtro para buscar produtos (deixe em branco para mostrar todos): ");
                        estoque.mostrarProdutos(filtro);
                        read();
                        Console.Clear();
                        break;

                    case "6":
                        // Apagar toda a lista
                        estoque.apagarListaProdutos();
                        read();
                        Console.Clear();
                        break;

                    case "7":
                        // Calcular valor total do estoque
                        estoque.calcularValorTotalEstoque();
                        read();
                        Console.Clear();
                        break;

                    case "8":
                        // Sair do programa
                        print("Saindo...");
                        return;

                    case "9":
                        // Diminuir quantidade de produto
                        int idDiminuir = int.Parse(read("Digite o ID do produto: "));
                        int quantidadeDiminuir = int.Parse(read("Digite a quantidade a ser diminuída: "));

                        if (estoque.subQuantidadeProduto(idDiminuir, quantidadeDiminuir))
                        {
                            print("Quantidade diminuída com sucesso!");
                        }
                        read();
                        Console.Clear();
                        break;
                }

            } while (true); // Loop continua até o usuário sair
        }
    }
}

// 1  POO (Programação Orientada a Objetos)
// •	Classes: Produto, Estoque
// •	Objetos: Instâncias das classes (novoProduto, estoque)
// •	Atributos: Variáveis internas que definem o estado do objeto
// •	Métodos: Funções que definem comportamentos do objeto
// •	Construtores: Inicializam objetos de forma prática
// 2 List<T> e LINQ
// •	List<Produto> armazena vários objetos Produto
// •	FirstOrDefault(), Where(), Sum() ajudam a buscar, filtrar e somar itens
// 3  Entrada e Saída (Console)
// •	Console.ReadLine() lê dados do usuário
// •	Console.Write e Console.WriteLine exibem informações
// 4  Validação de Dados
// •	Evita duplicidade de ID
// •	Impede remover mais quantidade do que existe
// 5  Menu interativo
// •	do-while mantém o programa ativo
// •	switch-case organiza a lógica de opções
