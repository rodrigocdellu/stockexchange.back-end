# 📈 stockexchange.back-end

Este repositório contém um projeto de exemplo para uma aplicação **back-end** desenvolvida com **.NET Core**.

---

## 🛠️ Ambiente de Desenvolvimento

### 🔧 Ferramentas Utilizadas para o Back-end

- 🪟 **Sistema Operacional**: Windows 10 Pro  
- ⚙️ **Framework**: .NET v8.0.408 (LTS)  
- 📝 **Editor de Código**: Visual Studio Code v1.99.3  
- 🐳 **Gerenciador de Contêineres**: Docker Desktop v4.40.0  

### 🎨 Ferramentas Utilizadas para o Front-end

- 🐧 **Sistema Operacional**: Ubuntu 24.04 LTS  
- 🌐 **Runtime JavaScript**: Node.js v22.14.0  
- 📦 **Gerenciador de Pacotes**: NPM v10.9.2  
- 🧰 **Framework Front-end**: Angular CLI v19.2.8  

---

## 🚀 Ambientes de Execução

### 💻 Ambiente de Desenvolvimento (Local)

1. Certifique-se de que todas as ferramentas listadas no pacote de back-end estejam instaladas.
2. Navegue até o diretório do projeto desejado e execute o comando abaixo no **PowerShell (Windows)** ou no **Terminal (Linux)**:

```bash
dotnet run
```

3. Após a execução, acesse a aplicação através do seguinte endereço:

[http://localhost:PORTA/swagger/index.html](http://localhost:PORTA/swagger/index.html)

---

### 📦 Ambiente de Produção (Docker)

1. Com o **Docker** devidamente instalado, execute o seguinte comando no diretório que contém o arquivo `Dockerfile`:

```bash
docker build -t stockexchange.webapi .
```

2. Após a criação da imagem, inicie o contêiner com o comando:

```bash
docker run -d -p 7200:80 stockexchange.webapi
```

3. A aplicação poderá ser acessada em ambiente de produção pelo endereço:

[http://localhost:7200/swagger/index.html](http://localhost:7200/swagger/index.html)

---

## 🤝 Contribuições

Contribuições são bem-vindas! Se você deseja sugerir melhorias, corrigir bugs ou adicionar novas funcionalidades, sinta-se à vontade para abrir uma [Issue](https://github.com/seu-usuario/seu-repositorio/issues) ou enviar um *Pull Request*.

Por favor, siga as boas práticas de desenvolvimento e, se possível, adicione testes automatizados relacionados às suas alterações.

---

## 📄 Licença

Este projeto está licenciado sob os termos da **MIT License**. Para mais informações, consulte o arquivo [`LICENSE`](./LICENSE).

---

## 📬 Contato

Caso tenha dúvidas, sugestões ou feedbacks, entre em contato:

- 📧 Email: [rodrigocdellu.trabalho@outlook.com](mailto:rodrigocdellu.trabalho@outlook.com)
- 💼 LinkedIn: [linkedin.com/in/rodrigocdellu](https://linkedin.com/in/rodrigocdellu)

---

> "_O SENHOR é misericordioso e compassivo, tardio em irar-se e grande em amor leal._"  
> — Salmos 145:8
