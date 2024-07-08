
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

* Caso o comando acima não funcione, entre no console de gerenciador de pacotes do nuget e execute novamente update-database

![image](https://github.com/lled16/PhoneBook/assets/32556098/2babab4b-db97-4545-8a44-9e7495f4c5c7)


Após isso, já deverá conseguir executar e visualizar o Swagger ! 

* Agora, clone o repositório : https://github.com/lled16/PhoneBookFront.git

* Abra o projeto clonado através do VSCODE, e pelo terminal, execute: npm start.

## Gravação de Logs

Ao deletar um cadastro, o sistema salva o log dessa deleção em um arquivo TXT, presente na raiz do projeto API, dentro da pasta log.

![image](https://github.com/lled16/PhoneBook/assets/32556098/afda78ef-118c-4ed8-a215-41a94a39d68c)


  
