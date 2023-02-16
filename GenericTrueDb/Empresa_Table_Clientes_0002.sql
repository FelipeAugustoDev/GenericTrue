use [ENTERPRISE]

create table CLIENTES
(
	id int identity(1,1) primary key,
	nome varchar(50),
	cpf varchar(15),
	endereco varchar(100),
	datanascimento datetime,
	telefone varchar(20),
	email varchar(100)
)