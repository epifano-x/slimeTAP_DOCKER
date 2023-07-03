# SlimeTAP - Docker Setup

**[Portuguese]**

SlimeTAP é um jogo divertido baseado na web desenvolvido usando Razor Pages. Este README irá orientá-lo sobre como executar o projeto SlimeTAP em um contêiner Docker, permitindo que você jogue o jogo em seu ambiente local.

## Instalação do Docker

Antes de prosseguir, certifique-se de ter o Docker instalado em seu sistema. Se você ainda não tem o Docker, você pode baixá-lo e instalá-lo para o seu sistema operacional específico a partir do site oficial do Docker: [Docker Website](https://www.docker.com/get-started).

## Construindo a Imagem Docker

Siga os passos abaixo para construir a imagem Docker para o SlimeTAP:

1. Clone este repositório em sua máquina local, se ainda não o fez.

2. Abra um terminal ou prompt de comando.

3. Navegue até o diretório do projeto que contém o Dockerfile.

4. Execute o comando para construir a imagem Docker `docker-compose up --build -d`.

## Executando o SlimeTAP em um Contêiner Docker

Depois de construir a imagem Docker, você pode executar o aplicativo da web SlimeTAP em um contêiner seguindo estes passos:

1. Execute o contêiner Docker usando a imagem que você construiu.

2. Abra seu navegador e acesse `http://localhost:60001` para jogar o SlimeTAP.

Agora, o SlimeTAP deve estar em execução em um contêiner Docker, acessível em `http://localhost:60001`. Você pode começar a tocar na tela para ganhar moedas de ouro e aproveitar o jogo!

## Parando o Contêiner Docker

Quando terminar de jogar o SlimeTAP, você pode parar o contêiner Docker com o comando apropriado.

## Requisitos do Sistema

- Docker
- Navegador web moderno

## Contribuição

Contribuições são bem-vindas! Se você encontrar problemas, tiver ideias para melhorias ou desejar adicionar novos recursos, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença

Este projeto está licenciado sob a [Licença MIT](https://opensource.org/licenses/MIT).




**[English]**

# SlimeTAP - Docker Setup

SlimeTAP is a fun web-based game developed using Razor Pages. This README will guide you on how to run the SlimeTAP project in a Docker container, allowing you to play the game on your local environment.

## Docker Installation

Before proceeding, ensure you have Docker installed on your system. If you don't have Docker yet, you can download and install it for your specific operating system from the official Docker website: [Docker Website](https://www.docker.com/get-started).

## Building the Docker Image

Follow the steps below to build the Docker image for SlimeTAP:

1. Clone this repository to your local machine if you haven't already done so.

2. Open a terminal or command prompt.

3. Navigate to the project directory containing the Dockerfile.

4. Run the command to build the Docker image `docker-compose up --build -d`.

## Running SlimeTAP in a Docker Container

Once you have built the Docker image, you can run the SlimeTAP web application in a container by following these steps:

1. Run the Docker container using the image you built.

2. Open your web browser and access `http://localhost:60001` to play SlimeTAP.

Now, SlimeTAP should be up and running in the Docker container, accessible on `http://localhost:60001`. You can start tapping to earn gold coins and enjoy the game!

## Stopping the Docker Container

When you're done playing SlimeTAP, you can stop the Docker container with the appropriate command.

## System Requirements

- Docker
- Modern web browser

## Contribution

Contributions are welcome! If you encounter any issues, have ideas for improvements, or wish to add new features, feel free to open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).
