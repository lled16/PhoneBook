
# PhoneBook API

Projeto desenvolvido para teste. O mesmo se trata de uma api para uma agenda telefônica, permitindo que o usuário possa criar um contado, definindo até 3 números de telefone, seu nome e sua idade. 

## Tecnologias utilizadas

* Frontend :
  
ReactJS 

* Backend :

C#

dotnet 8

Entity Framework

* Database
* 
SQL Server

## Sobre

Saliento que neste projeto, por ser simples, não seria necessário a utilização da arquitetura limpa, mas introduzi para fixar aluguns fundamentos, o mesmo poderia ser feito contendo apenas a camada de API.

Camadade de IOC não implementada pela simplicidade do projeto, mas as dependências também poderiam ser registradas nesta. 

## Como executar 

* Clone este repositório

* Acesse a classe Program.cs e altere a conexão para seu banco de dados

*  Através do terminal, navegue até o projeto InfraData : cd .\PhoneBook.InfraData\ 

* Execute o comando : update-database para que as migrations sejam carregadas e o banco de dados seja construído

Após isso, já deverá conseguir executar e visualizar o Swagger ! 

* Agora, clone o repositório : https://github.com/lled16/PhoneBookFront.git

* Abra o projeto clonado através do VSCODE, e pelo terminal, execute : npm start.
