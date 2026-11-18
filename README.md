# Cadastro de Aviões

Projeto desenvolvido em C# com Windows Forms e MySQL para praticar a criação de formulários e a integração com banco de dados.

A proposta é ter um sistema simples para cadastrar aviões e relacioná-los às companhias aéreas. O programa permite consultar os dados cadastrados e fazer alterações nos registros.

## Funcionalidades

- Cadastro de aviões com modelo, capacidade, ano de fabricação e companhia aérea;
- Consulta dos aviões cadastrados;
- Alteração e exclusão de registros;
- Cadastro de companhias aéreas.

## Tecnologias utilizadas

- C# e Windows Forms
- MySQL e MySQL Workbench
- Visual Studio
- Biblioteca MySql.Data para conexão com o banco

## Banco de dados

O banco utilizado é o `banco_siscadastro`, com as tabelas `avioes` e `companhias`. Cada avião fica associado a uma companhia por meio do campo `fk_companhia`.

O arquivo `DumpBancoCadastro.sql` contém a estrutura das tabelas. As stored procedures utilizadas pelo programa precisam ser configuradas no MySQL separadamente.

## Como executar

1. Ter o Visual Studio e o MySQL instalados.
2. Criar o banco `banco_siscadastro` e executar o arquivo `DumpBancoCadastro.sql` nele.
3. Configurar as stored procedures e os dados de conexão com o MySQL.
4. Abrir `SistemaCadastro.sln` no Visual Studio e executar o projeto.

Este projeto foi feito como atividade de aprendizagem, principalmente para praticar operações de cadastro, consulta, alteração e exclusão usando C# e banco de dados.
