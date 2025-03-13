namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Geração das palavras a serem adivinhadas aleatoriamente
            string[] palavras = {
            "ABACATE",
            "ABACAXI",
            "ACEROLA",
            "ACAI",
            "ARACA",            
            "BACABA",
            "BACURI",
            "BANANA",
            "CAJA",
            "CAJU",
            "CARAMBOLA",
            "CUPUACU",
            "GRAVIOLA",
            "GOIABA",
            "JABUTICABA",
            "JENIPAPO",
            "MACA",
            "MANGABA",
            "MANGA",
            "MARACUJA",
            "MURICI",
            "PEQUI",
            "PITANGA",
            "PITAYA",
            "SAPOTI",
            "TANGERINA",
            "UMBU",
            "UVA",
            "UVAIA"
            };

            Random geradorDeNumeros = new Random();

            int indiceEscolhido = geradorDeNumeros.Next(palavras.Length);

            string palavraEscolhida = palavras[indiceEscolhido];

            // transformar os valores dentro do array para '_'
            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractereAtual = 0; caractereAtual < letrasEncontradas.Length; caractereAtual++)
            {
                letrasEncontradas[caractereAtual] = '_';
            }

            //variaveis de condição de vítoria e derrota
            int quantidaDeErros = 0;
            bool jogadorGanhou = false;
            bool jogadorPerdeu = false;

           


            do
                {
                //desenho da forca
                //Operadores ternários - Condicional dentro de uma atribuição de valor
                string cabecaDoDesenho = quantidaDeErros >= 1 ? " o " : " ";
                    string troncoDoDesenho = quantidaDeErros >= 2 ?  "x" : " ";
                    string troncoInferiorDoDesenho = quantidaDeErros >= 3 ? " |" : " ";
                    string bracoEsquerdoDoDesenho = quantidaDeErros >= 4 ? "/" : " ";
                    string bracoDireitoDoDesenho = quantidaDeErros >= 5 ? "\\" : " ";
                    string pernasDoDesenho = quantidaDeErros >= 5 ? "/ \\" : " ";


                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/        |        ");
                    Console.WriteLine(" |        {0}       ", cabecaDoDesenho);
                    Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdoDoDesenho, troncoDoDesenho, bracoDireitoDoDesenho);
                    Console.WriteLine(" |        {0}       ", troncoInferiorDoDesenho);
                    Console.WriteLine(" |        {0}       ", pernasDoDesenho);
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Erros do jogador: " + quantidaDeErros);
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Palavra escolhida:" + String.Join("", letrasEncontradas));
                    Console.WriteLine("----------------------------------------------");

                    //Dado um caracter avaliar se está na palavra secreta

                    Console.Write("Digite uma letra válida: ");
                    string entradaInicial = Console.ReadLine().ToUpper();

                    if (entradaInicial.Length > 1)
                    {
                        Console.WriteLine("Informe apenas um caractere.");
                        continue;
                    }

                //lógica do jogo

                char chute = entradaInicial[0];

                bool letraFoiEncontrada = false;

                for (int contadorCaracteres = 0; contadorCaracteres < palavraEscolhida.Length; contadorCaracteres++)
                {
                    char caractereAtual = palavraEscolhida[contadorCaracteres];

                    if (chute == caractereAtual)
                    {
                        letrasEncontradas[contadorCaracteres] = caractereAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    quantidaDeErros++;

                string palavraEncontradaCompleta = String.Join("", letrasEncontradas); // Palavra inteira é acertada

                //Condição de Vitória
                jogadorGanhou = palavraEncontradaCompleta == palavraEscolhida;
                //Condição de Derrota
                jogadorPerdeu = quantidaDeErros > 5;

                if (jogadorGanhou)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"Você ganhou! A palavra era: {palavraEscolhida}");
                    Console.WriteLine("----------------------------------------------");
                }
                else if (jogadorPerdeu)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"Você perdeu! A palavra era: {palavraEscolhida}");
                    Console.WriteLine("----------------------------------------------");
                }
              


                } while (jogadorGanhou == false && jogadorPerdeu == false); // do + while            

            Console.ReadLine();
        }
    }
}
