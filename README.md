# UserManagementAPI

API RESTful simples para gerenciamento de usuários, desenvolvida com ASP.NET Core e Entity Framework Core, incluindo autenticação JWT.

## Funcionalidades

-   **CRUD Completo de Usuários:** Operações de Criação, Leitura, Atualização e Exclusão de usuários.
-   **Autenticação JWT:** Sistema de login seguro com JSON Web Tokens para proteger os endpoints da API.
-   **Validação de Dados:** Validação básica dos dados de entrada para usuários e credenciais de login.
-   **Documentação Interativa:** Testes e documentação da API via Swagger UI.
-   **Banco de Dados SQL Server:** Configuração flexível do banco de dados via `appsettings.json`.

## Tecnologias Utilizadas

-   **.NET 7:** Framework para desenvolvimento de aplicações.
-   **ASP.NET Core Web API:** Para construção da API RESTful.
-   **Entity Framework Core:** ORM para interação com o banco de dados.
-   **SQL Server:** Sistema de gerenciamento de banco de dados.
-   **Swagger (Swashbuckle.AspNetCore):** Para documentação e testes interativos da API.
-   **JWT (JSON Web Tokens):** Para autenticação e autorização.

## Como Rodar Localmente

Siga os passos abaixo para configurar e executar o projeto em sua máquina local:

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/cnthigu/UserManagementAPI.git
    ```

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd UserManagementAPI
    ```

3.  **Configure a Connection String:**
    Abra o arquivo `appsettings.json` e configure a string de conexão para o seu SQL Server local. Exemplo:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=UserManagementDb;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```

4.  **Configure a Chave Secreta JWT:**
    No mesmo arquivo `appsettings.json`, adicione ou atualize a seção `JwtSettings` com uma chave secreta forte. **Lembre-se de usar uma chave complexa e segura em ambientes de produção!**
    ```json
    "JwtSettings": {
      "Secret": "SuaChaveSecretaMuitoForteAquiQueDeveTerPeloMenos32Caracteres"
    }
    ```

5.  **Restaure as dependências:**
    ```bash
    dotnet restore
    ```

6.  **Aplique as Migrações do Banco de Dados:**
    Isso criará ou atualizará o banco de dados e as tabelas necessárias.
    ```bash
    dotnet ef database update
    ```
    *   **Dica:** Se encontrar erros relacionados ao `dotnet-ef`, certifique-se de que a ferramenta esteja instalada globalmente: `dotnet tool install --global dotnet-ef`.

7.  **Execute a API:**
    ```bash
    dotnet run
    ```
    A API será iniciada, e você verá a porta em que ela está rodando no console (geralmente `https://localhost:7001`).

## Endpoints da API

### Autenticação

-   `POST /api/Auth/login`
    *   **Descrição:** Autentica um usuário e retorna um token JWT.
    *   **Corpo da Requisição (JSON):**
        ```json
        {
          "email": "seuemail@exemplo.com",
          "password": "suasenha"
        }
        ```
    *   **Resposta de Sucesso (200 OK):**
        ```json
        {
          "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
        }
        ```

### Gerenciamento de Usuários (Requer Autenticação JWT)

Todos os endpoints abaixo requerem um token JWT válido no cabeçalho `Authorization` no formato `Bearer <token>`.

-   `GET /api/Users`
    *   **Descrição:** Lista todos os usuários cadastrados.

-   `GET /api/Users/{id}`
    *   **Descrição:** Busca um usuário específico pelo seu ID.

-   `POST /api/Users`
    *   **Descrição:** Cria um novo usuário.
    *   **Corpo da Requisição (JSON):**
        ```json
        {
          "name": "Nome do Usuário",
          "email": "usuario@exemplo.com",
          "password": "senhaSegura123"
        }
        ```

-   `PUT /api/Users/{id}`
    *   **Descrição:** Atualiza um usuário existente pelo seu ID.
    *   **Corpo da Requisição (JSON):** (Mesmo formato do POST, com os dados atualizados)

-   `DELETE /api/Users/{id}`
    *   **Descrição:** Remove um usuário pelo seu ID.

## Testando a API com Swagger UI

1.  **Acesse o Swagger:** Após executar a API (`dotnet run`), abra seu navegador e vá para `https://localhost:<porta>/swagger/index.html`.
2.  **Crie um Usuário:** Use o endpoint `POST /api/Users` para cadastrar um novo usuário (este endpoint não requer autenticação inicialmente, mas você pode protegê-lo se desejar).
3.  **Faça Login e Obtenha o Token:** Utilize o endpoint `POST /api/Auth/login` com as credenciais do usuário criado. Copie o token JWT retornado.
4.  **Autorize no Swagger:** No canto superior direito do Swagger UI, clique no botão "Authorize" (ou no ícone de cadeado). No campo de valor, digite `Bearer ` (com um espaço após "Bearer") seguido do token JWT que você copiou. Clique em "Authorize" e "Close".
5.  **Teste Endpoints Protegidos:** Agora você pode testar os endpoints do `UsersController`. Eles devem funcionar corretamente, pois o token será enviado nas requisições.

## Contato

Seu Nome — [LinkedIn](https://www.linkedin.com/in/higor-cnt-vinicius/) — higorzen77@gmail.com