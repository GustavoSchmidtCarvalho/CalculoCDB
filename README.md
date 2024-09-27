# CalculoCDB
Aplicação .net 6 com Angular CLI

# CalculoCDB
Aplicação .net 6 com Angular CLI

Tecnologias e frameworks usados na solução:

API rest com .NET 6 <br />
FrontEnd com Angular versão 18.2.6  Node.js com versão 22.9.0<br />

# Clone do repositório

Execute o comando <br />

<b>git clone https://github.com/GustavoSchmidtCarvalho/CalculoCDB.git</b>

# Estrutura das pastas

1. Aplicações:

2. Na solução CalculoCDB.sln se encontram os projetos: <br />

 - CalculoCDBApi: contém o projeto WebApi .net <br />
 - CalculoCDBApi.Tests: contém o projeto de testes da WebAPi CalculoCDBApi <br />
 - ClientApp: Contém a aplicação web em Angular <br />

2. Vá até a pasta onde se encontra o arquivo com a solução CalculoCDB.sln e execute <br />
<b>dotnet build</b> 

## Executando a aplicação CalculoCDBApi

1. Navegue até o diretório CalculoCDBApi e execute o comando <br />  
<b> dotnet run </b>  <br />

A aplicação ira executar em [CalculoCDBApi] (http://localhost:5153) <br />

Link [Swagger] (http://localhost:5153/swagger/index.html) <br />

## Executando testes unitários em CalculoCDBApi.Tests. 

Navegue até a pasta CalculoCDBApi.Tests e execute o comando  <br />
<b> dotnet test<br />

## Executando a aplicação ClientApp

Navegue até app/ClientApp e execute os comandos: <br /> 

<b> npm install </b>  <br /> ## Para instalar os recursos do Angular

<b> ng serve </b>  <br /> ## Para executar a aplicação

A aplicação ira executar em [app] (http://localhost:4200/) <br />

## Executando os Testes unitários no Angular

Navegue até app/ClientApp e execute  <br /> 
<b> ng test </b>  <br />