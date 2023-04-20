// Os produtos terão os seguintes atributos:
// - string Nome
// - float Preco
// - bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// - CadastrarProduto
// - ListarProdutos
// - MostrarMenu

string[] nomProd = new string[5];
float[] preco = new float[5];
bool[] promo = new bool[5];
string resposta = "s";
static bool VouF(char promo)
{

    if (promo == 's')
    {
        return true;
    }
    else
    {
        return false;
    }
}
int opcao1 = 0;
do
{


    Console.WriteLine(@$"
     sistema de cadastro de produtos
 digite 1 para mostrar o menu de opções
ou digite 0 para finalizar o programa
");
    opcao1 = int.Parse(Console.ReadLine());


    if (opcao1 == 1)
    {
        int opcao2 = 0;
        do
        {
            Console.WriteLine(@$"
            digite 1 para cadastrar produto
            digite 2 para listar produtos
                digite 0 para voltar
            ");
            opcao2 = int.Parse(Console.ReadLine());


            if (opcao2 == 1)

                for (var i = 0; i < 5; i++)
                {


                    Console.WriteLine($"Digite o nome do produto: ");
                    nomProd[i] = Console.ReadLine();
                    Console.WriteLine($"Escreva o preço do produto: ");
                    preco[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Esse produto está em promoção? Digite S para se ele estiver e N se não estiver");
                    char p = char.Parse(Console.ReadLine().ToLower());
                }



            else if (opcao2 == 2)
            {
                for (var i = 0; i < nomProd.Length; i++)
                {
                    Console.WriteLine(@$"
                        Nome do produto: {nomProd[i]}
                        Preço do produto: R${preco[i]}
                        O produto está em promoção: {promo[i]}
                        ");

                }

            }
            else if (opcao2 == 0)
            {

            }
            else
            {
                Console.WriteLine($"Opção inválida");
            }
        } while (opcao2 != 0);
    }

    else if (opcao1 == 0)
    {
        Console.WriteLine($"Fim do programa");

    }
    else
    {
        Console.WriteLine($"código inválido");

    }
} while (opcao1 != 0);








