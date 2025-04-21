# 📈 stockexchange.back-end

Um projeto de exemplo para uma aplicação **back-end** utilizando o **.NET Core**.

---

## 🛠️ Ambientes de Desenvolvimento

### 🔧 Pacote de Ferramentas para Back-end
- 🪟 **Windows 10 Pro**  
- ⚙️ **.NET v8.0.408 LTS**  
- 📝 **Visual Studio Code v1.99.3**  
- 🐳 **Docker Desktop v4.40.0**  

### 🎨 Pacote de Ferramentas para Front-end
- 🐧 **Ubuntu 24.04 LTS**  
- 🌐 **Node.js** (versão a ser definida)  

---

## 🚀 Ambientes de Execução

### 💻 Desenvolvimento (Local)

1. Certifique-se de ter o **Pacote de Ferramentas para Back-end** instalado.
2. Execute o seguinte comando no **PowerShell (Windows)** ou **Terminal (Linux)** na pasta do projeto que deseja executar:

```bash
dotnet run
```

3. Após a execução, acesse o link gerado para testar a aplicação:

[http://localhost:PORTA/swagger/index.html](http://localhost:PORTA/swagger/index.html)

---

### 📦 Produção (Docker)

1. Com o **Docker** instalado, execute o comando abaixo na pasta onde está localizado o `Dockerfile`:

```bash
docker build -t stockexchange.webapi .
```

2. Após a imagem ser criada, execute o container com:

```bash
docker run -d -p 7200:80 stockexchange.webapi
```

3. Acesse a aplicação em produção por meio do link:

[http://localhost:7200/swagger/index.html](http://localhost:7200/swagger/index.html)
