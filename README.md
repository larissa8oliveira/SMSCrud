# SMSCrud CRUD básico com ADO.Net 💻

Este projeto é um CRUD básico desenvolvido em ASP.NET Framework 4.8 que utiliza o ADO.Net para interagir com o banco de dados SQL Server. Ele permite realizar operações de criação, leitura, atualização e exclusão de registros de usuários na tabela "Usuários" do banco de dados "users".

## Requisitos

Antes de começar, certifique-se de que você tenha os seguintes requisitos instalados em seu ambiente de desenvolvimento:

- Visual Studio com suporte a ASP.NET Framework 4.8
- SQL Server (ou SQL Server Express) instalado e em execução
- Conexão à internet para instalação de pacotes NuGet

## Funcionalidades do aplicativo 🪐
- Criar: Permite adicionar novos usuários ao banco de dados, incluindo nome, e-mail datade nascimento e outros campos.
- Ler: Mostra uma lista de usuários cadastrados no banco de dados, permitindo visualizar seus dados.
- Atualizar: Permite editar as informações de um usuário existente no banco de dados, como nome, e-mail data de nascimento, etc.
- Excluir: Remove um usuário selecionado do banco de dados.

## Configuração do Banco de Dados

1. Abra o SQL Server Management Studio (ou outra ferramenta de gerenciamento de banco de dados compatível).

2. Crie um banco de dados chamado "users".

3. Crie a tabela "Usuários" com os campos necessários:
   - Id (INT, chave primária)
   - Nome (NVARCHAR(100), não nulo)
   - Email (NVARCHAR(100), não nulo)
   - Senha (NVARCHAR(100), não nulo)
   - CPF (NVARCHAR(14), não nulo)
   - DataHoraCriacao (DATETIME, não nulo)
   - DataHoraAtualizacao (DATETIME, não nulo)
   - DataNascimento (DATE, não nulo)
   - Perfil (NVARCHAR(50), não nulo)
   - Logradouro (NVARCHAR(200), não nulo)
   - Complemento (NVARCHAR(100))
   - Numero (NVARCHAR(10), não nulo)
   - Cidade (NVARCHAR(100), não nulo)
   - Estado (NVARCHAR(50), não nulo)
   - Pais (NVARCHAR(100), não nulo)
   - CEP (NVARCHAR(10), não nulo)
   - Telefones (NVARCHAR(200), não nulo)

## Build e Execução da Aplicação

Para compilar e executar a aplicação, siga os passos abaixo:

1. Clone este repositório para o seu ambiente de desenvolvimento local.

2. Abra o arquivo Web.config na raiz do projeto e atualize a string de conexão com os dados do seu servidor SQL Server.

3. No Solution Explorer, clique com o botão direito do mouse no projeto "SMSCrud" e selecione "Build" (ou pressione Ctrl + Shift + B) para compilar a aplicação.

4. Após a compilação, pressione F5 para executar a aplicação. Ela será iniciada em um servidor local.

5. Abra o navegador e acesse a aplicação em http://localhost:porta, onde "porta" é a porta em que o servidor local está executando (geralmente é a porta 44300 ou 50550).

Agora você poderá utilizar a aplicação para criar, ler, atualizar e excluir registros de usuários na tabela "Usuários" do banco de dados "users".

## Contribuição
Sinta-se à vontade para contribuir com melhorias, correções de bugs ou novas funcionalidades para este projeto. Basta enviar um pull request!


## Desenvolvimento 🛠️
- ASP.NET: Desenvolvimento de Formulários Web
- Linguagem de programação: C♯
- Linguagens de marcação: HTML e CSS.

## Dependências do Frontend 🌞
- HTML5
- CSS3 

## Dependências do Backend 🌚
- C#

## Contribuição 🤝
Sinta-se à vontade para contribuir com melhorias, correções de bugs ou novas funcionalidades para este projeto. Basta enviar um pull request!
