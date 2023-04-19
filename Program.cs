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
string resposta;
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

Console.WriteLine(@$"
     sistema de cadastro de produtos
 digite 1 para mostrar o menu de opções
ou digite 0 para finalizar o programa
");
int opcao1 = int.Parse(Console.ReadLine());

do
{
    if (opcao1 == 1)
    {
        Console.WriteLine(@$"
            digite 1 para cadastrar produto
            digite 2 para listar produtos
            digite 0 para fechar o programa
            ");
        int opcao2 = int.Parse(Console.ReadLine());


        if (opcao2 == 1)
            do
            {

                for (var i = 0; i < 5; i++)
                {


                    Console.WriteLine($"Digite o nome do produto: ");
                    nomProd[i] = Console.ReadLine();
                    Console.WriteLine($"Escreva o preço do produto: ");
                    preco[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Esse produto está em promoção? Digite S para se ele estiver e N se não estiver");
                    char p = char.Parse(Console.ReadLine().ToLower());
                }
                Console.WriteLine($"Deseja cadastrar mais um produto digite s para s e n para não?");
                resposta = Console.ReadLine().ToLower();


            } while (resposta == "s");

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
        else
        {
            Console.WriteLine($"Opção inválida");
        }
    }
}



            break;
        case 0:
            Console.WriteLine($"Fim do programa!");

break;
default:
            Console.WriteLine($"Erro digite uma opção");

break;
    }
}while (opcao1 != 0) ;

