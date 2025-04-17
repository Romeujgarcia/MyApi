# MyApi

## Descrição

MyApi é uma aplicação ASP.NET Core que implementa uma API RESTful para gerenciar produtos. A aplicação utiliza o padrão de arquitetura em camadas, seguindo os princípios do SOLID, para garantir um código limpo, manutenível e escalável.

## Estrutura do Projeto

A estrutura do projeto é organizada da seguinte forma:
MyApi
│
├── Controllers
│   └── ProductsController.cs
│
├── Data
│   └── MyDbContext.cs
│
├── Models
│   └── Product.cs
│
├── Repositories
│   └── IProductRepository.cs
│   └── ProductRepository.cs
│
├── Services
│   └── IProductService.cs
│   └── ProductService.cs
│
├
├── Program.cs
└── MyApi.csproj


## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para construção de aplicações web e APIs.
- **Entity Framework Core**: ORM (Object-Relational Mapper) para interagir com o banco de dados.
- **PostgreSQL**: Sistema de gerenciamento de banco de dados relacional utilizado para armazenar os dados da aplicação.
- **Dependency Injection**: Implementação de injeção de dependência para gerenciar as instâncias de serviços e repositórios.

## Arquitetura

A arquitetura do projeto é baseada no padrão **Camadas** (Layered Architecture), que separa as responsabilidades em diferentes camadas:

1. **Controllers**: Responsáveis por receber as requisições HTTP, processar as entradas e retornar as respostas. Utilizam os serviços para realizar operações de negócios.
  
2. **Services**: Contêm a lógica de negócios da aplicação. Interagem com os repositórios para acessar os dados e aplicar regras de negócio.

3. **Repositories**: Responsáveis pela interação com o banco de dados. Implementam a lógica de acesso a dados e são utilizados pelos serviços.

4. **Models**: Representam as entidades do domínio da aplicação. No caso, a classe `Product` representa um produto.

5. **Data**: Contém o contexto do banco de dados, que é responsável por gerenciar as entidades e suas interações com o banco de dados.

## Como Executar o Projeto

### Pré-requisitos

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/) (ou outro banco de dados de sua escolha)

### Passos

1. Clone o repositório:

   ```bash
   git clone https://github.com/Romeujgarcia/MyApi.git
   cd MyApi
   dotnet restore
   "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=MyDatabase;Username=myuser;Password=mypassword"
   }

   dotnet ef migrations add InitialCreate
   dotnet ef database update

   
### Personalização

- **Descrição**: Adapte a descrição do projeto para refletir melhor o que ele faz.
- **Tecnologias**: Adicione ou remova tecnologias conforme necessário.
- **Instruções de Execução**: Certifique-se de que as instruções de execução estão corretas e refletem o que é necessário para rodar o projeto.
- **Contribuição **e Licença**: Inclua informações sobre como os colaboradores podem contribuir e a licença sob a qual o projeto está disponível. 

## Testes

Para garantir a qualidade do código, você pode incluir testes unitários e de integração. Utilize o framework de testes do .NET para criar e executar os testes.

### Executando os Testes

1. Navegue até o diretório do projeto de testes (se houver).
2. Execute os testes com o seguinte comando:

   ```bash
   dotnet test
