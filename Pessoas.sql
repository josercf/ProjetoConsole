-------------------------------------------------------------------------
--Cria a tabela formulario
	if not exists(select * from INFORMATION_SCHEMA.tables where table_name = 'Pessoa') 
	begin
	create table Pessoa
	(
		id_pessoas integer identity(1,1) constraint PK_id_pessoas primary key,
		nome varchar(255) not null,
		email varchar(40),
		senha varchar(30)
	)
	end
	go

-- Esse if pesquisa na net ai

-- reseta o id no sql
-- DBCC CHECKIDENT('Pessoa', RESEED, 0)

-- select * from Pessoa

-- drop table Pessoa
