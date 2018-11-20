/*
Created		01/10/2017
Modified		01/10/2017
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/


Create table [Projeto]
(
	[IdProjeto] Integer Identity(1,1) NOT NULL,
	[IdSituacaoProjeto] Integer NOT NULL,
	[Titulo] Varchar(100) NOT NULL,
	[Descricao] Text NOT NULL,
	[DataInicio] Datetime NOT NULL,
	[DataFim] Datetime NULL,
Primary Key ([IdProjeto])
) 
go

Create table [Curso]
(
	[IdCurso] Integer Identity(1,1) NOT NULL,
	[Descricao] Varchar(100) NOT NULL,
Primary Key ([IdCurso])
) 
go

Create table [SituacaoProjeto]
(
	[IdSituacaoProjeto] Integer Identity(1,1) NOT NULL,
	[Descricao] Varchar(100) NOT NULL,
Primary Key ([IdSituacaoProjeto])
) 
go

Create table [Papel]
(
	[IdPapel] Integer Identity(1,1) NOT NULL,
	[Descricao] Varchar(100) NOT NULL,
Primary Key ([IdPapel])
) 
go

Create table [TipoEntrega]
(
	[IdTipoEntrega] Integer Identity(1,1) NOT NULL,
	[Descricao] Varchar(100) NOT NULL,
Primary Key ([IdTipoEntrega])
) 
go

Create table [TipoParticipante]
(
	[IdTipoParticipante] Integer Identity(1,1) NOT NULL,
	[Descricao] Varchar(100) NOT NULL,
Primary Key ([IdTipoParticipante])
) 
go

Create table [MatriculaCurso]
(
	[IdAluno] Integer NOT NULL,
	[IdCurso] Integer NOT NULL,
	[DataMatricula] Datetime NOT NULL,
Primary Key ([IdAluno],[IdCurso])
) 
go

Create table [Pessoa]
(
	[IdPessoa] Integer Identity(1,1) NOT NULL,
	[Nome] Varchar(200) NOT NULL,
Primary Key ([IdPessoa])
) 
go

Create table [UsuarioPapel]
(
	[IdUsuario] Integer NOT NULL,
	[IdPapel] Integer NOT NULL,
	[DataInicioVigencia] Datetime NOT NULL,
	[DataFimVigencia] Datetime NULL,
Primary Key ([IdUsuario],[IdPapel])
) 
go

Create table [Usuario]
(
	[IdUsuario] Integer Identity(1,1) NOT NULL,
	[IdPessoa] Integer NOT NULL,
	[Usuario] Varchar(50) NOT NULL,
	[Senha] Varchar(32) NOT NULL,
Primary Key ([IdUsuario])
) 
go

Create table [Entrega]
(
	[IdEntrega] Integer Identity(1,1) NOT NULL,
	[IdProjeto] Integer NOT NULL,
	[IdTipoEntrega] Integer NOT NULL,
	[DataEntrega] Datetime NOT NULL,
Primary Key ([IdEntrega])
) 
go

Create table [Aluno]
(
	[IdAluno] Integer NOT NULL,
	[Matricula] Varchar(8) NOT NULL,
Primary Key ([IdAluno])
) 
go

Create table [ProjetoAluno]
(
	[IdAluno] Integer NOT NULL,
	[IdProjeto] Integer NOT NULL,
	[IdTipoParticipante] Integer NOT NULL,
	[DataRegistro] Datetime NOT NULL,
Primary Key ([IdAluno],[IdProjeto])
) 
go

Create table [Anexo]
(
	[IdAnexo] Integer Identity(1,1) NOT NULL,
	[IdEntrega] Integer NOT NULL,
	[NomeLogico] Varchar(200) NOT NULL,
	[CaminhoFisico] Varchar(255) NOT NULL,
Primary Key ([IdAnexo])
) 
go


Alter table [ProjetoAluno] add  foreign key([IdProjeto]) references [Projeto] ([IdProjeto])  on update no action on delete no action 
go
Alter table [Entrega] add  foreign key([IdProjeto]) references [Projeto] ([IdProjeto])  on update no action on delete no action 
go
Alter table [MatriculaCurso] add  foreign key([IdCurso]) references [Curso] ([IdCurso])  on update no action on delete no action 
go
Alter table [Projeto] add  foreign key([IdSituacaoProjeto]) references [SituacaoProjeto] ([IdSituacaoProjeto])  on update no action on delete no action 
go
Alter table [UsuarioPapel] add  foreign key([IdPapel]) references [Papel] ([IdPapel])  on update no action on delete no action 
go
Alter table [Entrega] add  foreign key([IdTipoEntrega]) references [TipoEntrega] ([IdTipoEntrega])  on update no action on delete no action 
go
Alter table [ProjetoAluno] add  foreign key([IdTipoParticipante]) references [TipoParticipante] ([IdTipoParticipante])  on update no action on delete no action 
go
Alter table [Aluno] add  foreign key([IdAluno]) references [Pessoa] ([IdPessoa])  on update no action on delete no action 
go
Alter table [Usuario] add  foreign key([IdPessoa]) references [Pessoa] ([IdPessoa])  on update no action on delete no action 
go
Alter table [UsuarioPapel] add  foreign key([IdUsuario]) references [Usuario] ([IdUsuario])  on update no action on delete no action 
go
Alter table [Anexo] add  foreign key([IdEntrega]) references [Entrega] ([IdEntrega])  on update no action on delete no action 
go
Alter table [MatriculaCurso] add  foreign key([IdAluno]) references [Aluno] ([IdAluno])  on update no action on delete no action 
go
Alter table [ProjetoAluno] add  foreign key([IdAluno]) references [Aluno] ([IdAluno])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


