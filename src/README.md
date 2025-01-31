# Projeto C# com .NET 8.0, AutoMapper, FluentValidation e MediatR

Este projeto demonstra o uso do C# com o .NET 8.0, juntamente com as bibliotecas AutoMapper, FluentValidation e MediatR, para criar uma API Web. O projeto oferece flexibilidade na configuração do banco de dados, permitindo o uso tanto do SQL Server quanto do SQLite.

## Configuração do Banco de Dados

O projeto oferece duas opções para configurar o banco de dados:

1.  **SQL Server:**

    *   No arquivo `appsettings.json` do projeto WebApi, localize a ConnectionString chamada `DefaultConnection` e ajuste-a com os valores da sua instância do SQL Server.
    *   Caso não possua uma instância do SQL Server, você pode utilizar o SQLite, que é um banco de dados leve e de arquivo único.
    *   O projeto inclui um arquivo `docker-compose.yml` na camada de Infrastructure que permite subir um container com o banco de dados SQL Server utilizando o Docker. Para utilizá-lo, siga os seguintes passos:
        1.  Na linha de comando, navegue até o diretório da camada Infrastructure.
        2.  Execute o comando `docker-compose up -d`.
        3.  Após a execução do comando, o container com o SQL Server estará em execução.

2.  **SQLite:**

    *   Para configurar o SQLite, utilize a ConnectionString chamada `Sqlite` no arquivo `appsettings.json` que já está com o valor default.
    
## Selecionando o Banco de Dados

Na camada de Infrastructure, no arquivo `ServiceExtensions`, você pode configurar qual banco de dados deseja utilizar. Basta comentar ou descomentar a linha de código correspondente ao banco de dados desejado:

```csharp
// Para usar SQL Server
services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

// Para usar SQLite
services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(Configuration.GetConnectionString("Sqlite")));        

## Executando a API

Para executar a API, utilize o profile "http" que está configurado para apontar para a porta `http://localhost:5106`.

## Tecnologias Utilizadas

*   **C#:** Linguagem de programação utilizada no desenvolvimento do projeto.
*   **.NET 8.0:** Framework utilizado para construir a API Web.
*   **AutoMapper:** Biblioteca para mapeamento de objetos.
*   **FluentValidation:** Biblioteca para validação de objetos.
*   **MediatR:** Biblioteca para implementação do padrão Mediator.
*   **SQL Server:** Banco de dados relacional.
*   **SQLite:** Banco de dados leve e de arquivo único.
*   **Docker:** Plataforma para criação e gerenciamento de containers.

## Observações

*   Certifique-se de ter o .NET 8.0 SDK instalado em sua máquina.
*   Caso utilize o SQL Server, ajuste a ConnectionString de acordo com sua instância.
*   Caso utilize o Docker, certifique-se de tê-lo instalado em sua máquina.

Este README fornece as informações necessárias para configurar e executar o projeto. Em caso de dúvidas, consulte a documentação das tecnologias utilizadas ou entre em contato com os desenvolvedores do projeto.