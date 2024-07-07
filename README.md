
# PhoneBook API

Projeto desenvolvido para teste. Trata-se de uma api para uma agenda telefônica, permitindo que o usuário possa criar um contato, definindo até 3 números de telefone, seu nome e sua idade. 

## Tecnologias utilizadas

* Frontend :
  
ReactJS 

* Backend :

C#

dotnet 8

Entity Framework

* Database
 
SQL Server

## Sobre

Saliento que neste projeto, por ser simples, não seria necessário a utilização da arquitetura limpa, mas introduzi para demonstrar como poderia ser feito em caso de um projeto mais complexo.

Camada de de IOC não implementada pela simplicidade do projeto, mas as dependências também poderiam ser registradas nesta. 

## Como executar 

* Clone este repositório

* Acesse a classe Program.cs e altere a conexão para seu banco de dados

*  Através do terminal, navegue até o projeto InfraData : cd .\PhoneBook.InfraData\ 

* Execute o comando: update-database para que as migrations sejam carregadas e o banco de dados seja construído

Após isso, já deverá conseguir executar e visualizar o Swagger ! 

* Agora, clone o repositório : https://github.com/lled16/PhoneBookFront.git

* Abra o projeto clonado através do VSCODE, e pelo terminal, execute: npm start.
