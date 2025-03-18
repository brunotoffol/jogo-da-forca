namespace JogoDaForca.ConsoleApp
{
    class FuncoesJogo
    {
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
        public string palavraEscolhida;
        public char[] letrasEncontradas;
        public int quantidadeDeErros;
        public bool jogadorGanhou;
        public bool jogadorPerdeu;

        public void IniciarJogo()
        {
            SortearPalavra();
            FazOsTracos();

            quantidadeDeErros = 0;
            jogadorGanhou = false;
            jogadorPerdeu = false;

            do
            {
                DesenharForca();
                ChuteJogador();
                FimDoJogo();

            } while (jogadorGanhou == false && jogadorPerdeu == false);

            Console.ReadLine();
        }
        public void SortearPalavra()
        {
            Random geradorDeNumeros = new Random();
            int indiceEscolhido = geradorDeNumeros.Next(palavras.Length);
            palavraEscolhida = palavras[indiceEscolhido];
        }
        public void FazOsTracos()
        {
            letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractereAtual = 0; caractereAtual < letrasEncontradas.Length; caractereAtual++)
            {
                letrasEncontradas[caractereAtual] = '_';
            }
        }
        public void DesenharForca()
        {
            string cabecaDoDesenho = quantidadeDeErros >= 1 ? " o " : " ";
            string troncoDoDesenho = quantidadeDeErros >= 2 ? "x" : " ";
            string troncoInferiorDoDesenho = quantidadeDeErros >= 3 ? " |" : " ";
            string bracoEsquerdoDoDesenho = quantidadeDeErros >= 4 ? "/" : " ";
            string bracoDireitoDoDesenho = quantidadeDeErros >= 5 ? "\\" : " ";
            string pernasDoDesenho = quantidadeDeErros >= 5 ? "/ \\" : " ";

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
            Console.WriteLine("Erros do jogador: " + quantidadeDeErros);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Palavra escolhida:" + String.Join("", letrasEncontradas));
            Console.WriteLine("----------------------------------------------");
        }
        public void ChuteJogador()
        {
            Console.Write("Digite uma letra válida: ");
            string entradaInicial = Console.ReadLine().ToUpper();

            if (entradaInicial.Length > 1)
            {
                Console.WriteLine("Informe apenas um caractere.");
                return;
            }

            char chute = entradaInicial[0];
            VerificarChute(chute);
        }
        public void VerificarChute(char chute)
        {
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
                quantidadeDeErros++;
        }
        public void FimDoJogo()
        {
            string palavraEncontradaCompleta = String.Join("", letrasEncontradas);

            // Condição de Vitória
            jogadorGanhou = palavraEncontradaCompleta == palavraEscolhida;
            // Condição de Derrota
            jogadorPerdeu = quantidadeDeErros > 5;

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
        }
    }
}