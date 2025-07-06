# UserManagementAPI

API simples para gerenciamento de usuários usando ASP.NET Core e Entity Framework Core.

## Funcionalidades

- CRUD completo de usuários
- Validação básica dos dados
- Documentação e testes via Swagger
- Banco de dados SQL Server configurável via `appsettings.json`

## Tecnologias utilizadas

- .NET 7
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger (Swashbuckle.AspNetCore)

## Como rodar localmente

1.  Clone o repositório:

    ```bash
    git clone https://github.com/cnthigu/UserManagementAPI.git
    ```

2.  Entre na pasta do projeto:

    ```bash
    cd UserManagementAPI
    ```

3.  Configure a connection string no arquivo `appsettings.json`, por exemplo:

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=UserManagementAPI;Trusted_Connection=True;TrustServerCertificate=True;"
    }
    ```

4.  Rode as migrations para criar o banco de dados:

    ```bash
    dotnet ef database update
    ```

5.  Execute a API:

    ```bash
    dotnet run
    ```

6.  Abra o navegador e acesse a documentação Swagger:

    ```bash
    https://localhost:<porta>/swagger/index.html
    ```

## Endpoints principais

-   `GET /api/users` - Lista todos os usuários
-   `GET /api/users/{id}` - Busca usuário por ID
-   `POST /api/users` - Cria novo usuário
-   `PUT /api/users/{id}` - Atualiza usuário existente
-   `DELETE /api/users/{id}` - Remove usuário

## Contato

Higor Vinicius. — [LinkedIn](https://www.linkedin.com/in/higor-cnt-vinicius/) — higorzen77@gmail.com
