# Empréstimo de Jogos

Sistema de empréstimos de jogos, é um sistema de controle de empréstimos de jogos de vídeo game.

## 🔥 Introdução

O sistema de empréstimo de jogos, foi feito para criação de um sistema Web com integração com o banco de dados

![- Emprestimos de Jogos](https://github.com/marcostwelve/SistemaEmprestimo/assets/94411600/109b9f5c-c78f-48c7-8e91-495bb4dec3af)

### ⚙️ Pré-requisitos
* Visual Studio
* Entity Framework
* ASP.Net Core
* .Net Core
* Sql Server (Ou outro banco de dados)


### 🔨 Guia de instalação

Para utilizar este projeto, necessário instalar o Entity Framework, e configurar o banco de dados no arquivo appsettings.Development.json, e instalar as migrations para conexão com o banco de dados

Etapas para instalar:

```bash
dotnet tool install --global dotnet-ef
```
Passo 2:
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
Passo 3:
```bash
Install-Package Microsoft.EntityFrameworkCore.Design
```
Passo 4:
```bash
dotnet-ef migrations add (Nome da migration do projeto)
```

Passo 5:
```bash
dotnet-ef database update
```


## 🛠️ Executando os testes (caso tenha testes)

Para executar o projeto, para testes. Digite o seguinte comando no terminal do Visual Studio

```bash
dotnet watch run
```
## Página Inicial
![image](https://github.com/marcostwelve/SistemaEmprestimo/assets/94411600/ffbe7079-051e-4f19-89c6-79c8fb882ccf)

Página inicial do projeto, com navegação para a página com a listagem dos jogos emprestados.

## Página de empréstimos
![image](https://github.com/marcostwelve/SistemaEmprestimo/assets/94411600/091bd4a7-a0c3-497e-baa5-9b3906198322)

Página com a listagem de todos os empréstimos, contendo os dados necessários para empréstimo do jogo.
Botões para cadastrar, editar e excluir.
## Cadastro de empréstimo
Os campos de cadastrar um empréstimo, com validações dos dados do empréstimo.
## Editar empréstimo
Campo para editar um empréstimo já cadastrado
## Excluir Cadastro
Campo que exclui um cadastro, sendo esta uma operação irreversível
## Exportar dados
Operação que realiza exportação e download dos dados cadastrados em uma planilha. Onde pode-se abrir o arquivo em qualquer aplicativo de planilhas.

## 📦 Tecnologias usadas:


* [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/)
* [Entity Framework](https://learn.microsoft.com/pt-br/ef/core/get-started/overview/install)
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
* [ASP .Net Core](https://dotnet.microsoft.com/pt-br/apps/aspnet)
* [Bootstrap](https://getbootstrap.com/)



## 👷 Autores


* **Maurício Marcelino** - *Back-End do projeto* - [Maurício Marcelino](https://github.com/marcostwelve)


## 📄 Licença

Esse projeto está sob a licença (MIT) - acesse os detalhes [LICENSE.md](https://opensource.org/license/mit/).




## 💡 Expressões de gratidão

* Agradeço todos por verificarem o meu projeto. Esotu aberto a sugestões de melhorias e evolução do projeto.
* [Meu linkedin](https://www.linkedin.com/in/mauricio-marcelino/)
