# Jogo da Forca

## Introdução

Jogo clássico de passatempo nas escolas onde o jogador deve adivinhar a palavra secreta ou acaba indo desta para melhor.

### Exemplo

![](https://i.imgur.com/XNGzBmi.gif)

### Funcionalidades

- Cinco tentativas para tentar acertar a palavra correta, sendo demostrado na tela atráves do desenho do boneco o progresso do jogador.
- Sorteio aleatório de uma fruta a ser adivinhada com base em uma lista contendo 29 frutas.
- Jogador consegue visualizar as letras acertadas e suas posições atráves de uma linha de texto.

### Como utilizar:
1. Clone o repositório ou baixe o código fonte
2. Abre o terminal ou prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as depências do projeto

```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5. Para Executar o projeto compilando em tempo real
```
dotnet run --project JogoDaForca.ConsoleApp
```
6. Para executar o arquivo compilado, navegue até a pasta ./JogoDaForca.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
JogoDaForca.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.