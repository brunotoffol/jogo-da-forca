# Jogo da Forca

## Introdu��o

Jogo cl�ssico de passatempo nas escolas onde o jogador deve adivinhar a palavra secreta ou acaba indo desta para melhor.

### Exemplo

![](https://i.imgur.com/XNGzBmi.gif)

### Funcionalidades

- Cinco tentativas para tentar acertar a palavra correta, sendo demostrado na tela atr�ves do desenho do boneco o progresso do jogador.
- Sorteio aleat�rio de uma fruta a ser adivinhada com base em uma lista contendo 29 frutas.
- Jogador consegue visualizar as letras acertadas e suas posi��es atr�ves de uma linha de texto.

### Como utilizar:
1. Clone o reposit�rio ou baixe o c�digo fonte
2. Abre o terminal ou prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as dep�ncias do projeto

```
dotnet restore
```
4. Em seguida, compile a solu��o utilizando o comando:
```
dotnet build --configuration Release
```
5. Para Executar o projeto compilando em tempo real
```
dotnet run --project JogoDaForca.ConsoleApp
```
6. Para executar o arquivo compilado, navegue at� a pasta ./JogoDaForca.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
JogoDaForca.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.