# 📈 StockExchange.Back-end

Aplicativo financeiro criado para avaliar conceitos de .NET Core (C#) e Angular (Typescript).
Este repositório contém uma aplicação **back-end** desenvolvida em **.NET Core** para o setor financeiro com o objetivo de aprender e exercitar novas tecnologias e conceitos.

## 📦 Conteúdo do Repositório

Este repositório possui 1 aplicações, sendo:
- StockExchange.WebAPI: Back-end .NET Core responsável por fornecer os serviços financeiros via API REST.
- StockExchange.WebAPI.Test: NUnit .NET Core responsável por testar o Back-end .NET Core de forma integrada e automática.

## 🛠️ Ferramentas Utilizadas

- Sistema Operacional 1: [Windows 10 Pro](#)
- Sistema Operacional 2: [Ubuntu 24.04 LTS](https://ubuntu.com/download/desktop)  
- Editor de Código 1: [Visual Studio Code v1.99.3](https://code.visualstudio.com/download)
- Editor de Código 2: [Visual Studio 2022 Community v17.13.6](https://visualstudio.microsoft.com/pt-br/downloads)  
- Gerenciador de Contêineres: [Docker Desktop v4.40.0](https://www.docker.com/products/docker-desktop)
- Analisador de Código Estático e Testes: [SonarQube Cloud](https://sonarcloud.io)  

### 🔧 Pacotes Utilizados no Back-end .NET Core

- Framework: [.NET v6.0.36 (LTS)](https://dotnet.microsoft.com/pt-br/download/dotnet/6.0) com suporte ao [.NET v8.0.408 (LTS)](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)  
- Framework de Teste da Microsoft: [Microsoft.NET.Test.Sdk v17.8.0](https://www.nuget.org/packages/Microsoft.NET.Test.Sdk/17.8.0)  
- Framework de Teste: [NUnit v3.14.0](https://www.nuget.org/packages/NUnit/3.14.0)  
- Ferramenta para Coletar Code Coverage: [coverlet.collector v6.0.4](https://www.nuget.org/packages/coverlet.collector/6.0.4)  
  
### 🎨 Pacotes Utilizados no Front-end Angular

- Runtime JavaScript: [Node.js v22.14.0](https://nodejs.org/pt)  
- Gerenciador de Pacotes: [NPM v10.9.2](https://www.npmjs.com/package/npm/v/10.9.2)  
- Framework Front-end: [Angular CLI v19.2.8](https://github.com/angular/angular-cli)
- Estilização: [Angular Material v19.2.10](https://github.com/angular/angular-cli)  

## 🚀 Ambientes de Execução

**IMPORTANTE:**
Certifique-se de que todas as ferramentas e pacotes utilizados estejam instaladas e funcionando.
Antes de executar, verifique se a porta 5041 está disponível.
Os comandos a seguir podem ser executados no **PowerShell (Windows)** ou no **Terminal (Linux)**.

1. Baixe o repositório do [GitHub](https://github.com/rodrigocdellu/stockexchange.back-end)

```
git clone git@github.com:rodrigocdellu/stockexchange.back-end.git;
```

2. Execute a API Web (Back-end .NET Core):

```
cd stockexchange/StockExchange.WebAPI/; dotnet run
```

3. Após a execução, você pode acessar a aplicação atravé do seguinte endereço:

- Back-end .NET Core: [http://localhost:5041](http://localhost:5041)

## 💻 Ambiente de Desenvolvimento

**IMPORTANTE:**
Certifique-se de que todas as ferramentas e pacotes utilizados estejam instaladas e funcionando.
Antes de executar, verifique se a porta 5041 está disponível.
Os comandos a seguir podem ser executados no **PowerShell (Windows)** ou no **Terminal (Linux)**.

1. Com os repositório já baixados, execute os seguintes comandos para desenvolver o Back-end .NET Core:

```
cd stockexchange/StockExchange.WebAPI/; code .
```

## 🐳 Ambiente de Produção (Docker)

1. Com o **Docker** devidamente instalado, execute o seguinte comando na pasta 'stockexchange-back-end' para criar uma imagem do Back-end .NET Core

```
docker build -t stockexchange.webapi .
```

2. Após a criação da imagem, inicie o contêiner do Back-end .NET Core com o comando:

```
docker run --name stockexchange.webapi -d -p 7200:80 stockexchange.webapi
```

5. Após a execução do container, você pode acessar a aplicação através do seguinte endereço:

- Back-end .NET Core: [http://localhost:7200](http://localhost:7200)

4. Caso não consiga construir a imagem, você pode baixá-la do meu Docker Hub:

- [Back-end .NET Core](https://hub.docker.com/r/rodrigocdellu/stockexchange.webapi)

## ❤ Clean Code

Aqui disponibilizo os [resultados da analise estática de cógido](https://sonarcloud.io/project/overview?id=rodrigocdellu_stockexchange-back-end) com as configurações padrão do SonarQube Cloud.

## 🤝 Contribuições

Contribuições são bem-vindas! Se você deseja sugerir melhorias, corrigir bugs ou adicionar novas funcionalidades, sinta-se à vontade para abrir uma [Issue](https://github.com/rodrigocdellu/stockexchange.back-end/issues) ou enviar um *Pull Request*.

Por favor, siga as boas práticas de desenvolvimento e, se possível, adicione testes automatizados relacionados às suas alterações.

## 📄 Licença

Este projeto está licenciado sob os termos da **MIT License**. Para mais informações, consulte o arquivo [`LICENSE`](./LICENSE.md).

## 📬 Contato

Caso tenha dúvidas, sugestões ou feedbacks, entre em contato:

- Email: [rodrigocdellu.trabalho@outlook.com](mailto:rodrigocdellu.trabalho@outlook.com)
- LinkedIn: [linkedin.com/in/rodrigocdellu](https://linkedin.com/in/rodrigocdellu)

---

> "_O SENHOR é misericordioso e compassivo, tardio em irar-se e grande em amor leal._"  
> — Salmos 145:8
