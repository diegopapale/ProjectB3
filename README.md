# ProjectB3

Este é um projeto que inclui uma Web API construída com .NET Framework 4.8, um conjunto de testes para a API e um front-end desenvolvido com Angular. 
Este documento fornece instruções sobre como configurar, construir, testar e contribuir para o projeto.

## Pré-requisitos

Antes de começar, você precisará ter os seguintes softwares instalados:

- [.NET Framework 4.8 SDK](https://dotnet.microsoft.com/download/dotnet-framework)
- [Node.js](https://nodejs.org/) (inclui npm)
- [Git](https://git-scm.com/)

## Instalação e Configuração

### Clonar o Repositório

Clone o repositório do projeto:

cd existing_repo
git remote add origin https://gitlab.com/testes6095534/projectb3.git
git branch -M main
git push -uf origin main

## Execução do Projeto Angular

Necessário apontar o endereço/porta onde a API está rodando, no arquivo: environment.ts

## Execução do Projeto API

Devido à políticas de segurança de CORS (Cross-Origin Resource Sharing), caso tenha problemas,
é necessário incluir o endereço/porta onde o Projeto Front (Angular) está rodando nos arquivos WebApiConfig.cs e InvestmentController.cs

Web API .Net Framework não possui por padrão Swagger para documentação de APi, porém nessa aplicação, usei a biblioteca Swashbuckle para integrar o Swagger. 
Exemplo de acesso ao Swagger:
https://localhost:44332/swagger